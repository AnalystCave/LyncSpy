using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LyncTracker.Logic;
using LyncTracker.Properties;
using Microsoft.Lync.Model;

namespace LyncTracker
{
    public partial class MainForm : Form
    {
        Tracker tracker;

        public MainForm()
        {
            InitializeComponent();
            InitializeImageList();
            InitializeGroups();
            InitializeCheckList();
        }

        void InitializeCheckList()
        {
            for(int i = 0; i < clbStatuses.Items.Count;++i)
                clbStatuses.Items[i].Checked = true;
        }

        void InitializeImageList()
        {
            ImageList il = new ImageList();
            il.Images.Add("grey", Resources.grey);
            il.Images.Add("yellow", Resources.yellow);
            il.Images.Add("red", Resources.red);
            il.Images.Add("green", Resources.green);
            lvList.SmallImageList = il;
        }

        void InitializeGroups()
        {
            //Send mail
            ControlsEnabler ctrlEnabler = new ControlsEnabler();
            ctrlEnabler.AddControl(tbSendEmail);
            cbSendActive.CheckedChanged += ctrlEnabler.CheckedChanged;
            //Save to log
            ctrlEnabler = new ControlsEnabler();
            ctrlEnabler.AddControl(tbLog);
            ctrlEnabler.AddControl(bSearch);
            cbSaveActive.CheckedChanged += ctrlEnabler.CheckedChanged;
            //
            cbSendActive.Checked = cbSaveActive.Checked = false;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length > 0)
                lvList.Items.Add(tbEmail.Text, "grey");
            tbEmail.Text = "";
        }

        private void rbOn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOn.Checked)
            {
                if (cbSendActive.Checked && tbSendEmail.Text.Length == 0)
                {
                    MessageBox.Show("Please input the email to which notifications are to be sent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbSaveActive.Checked && tbLog.Text.Length == 0)
                {
                    MessageBox.Show("Please input the csv log path to which notifications are to be save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ChangeAdapter ca = new ChangeAdapter(this);
                try
                {
                    tracker = new Tracker(ca);
                    tracker.Start(ToStringList(lvList.Items), GetStatusList());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lync not turned on", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    rbOn.Checked = false;
                    ca.SetStatus("Off");
                    ca = null;
                }
                
            }
            else
            {
                if (tracker != null)
                {
                    tracker.Stop();
                    tracker = null;
                }
                tsslStatus.Text = "Off";
            }
        }

        private List<ContactAvailability> GetStatusList()
        {
            List<ContactAvailability> statusList = new List<ContactAvailability>();
            System.Windows.Forms.ListView.CheckedListViewItemCollection s = clbStatuses.CheckedItems;
            IEnumerable<ListViewItem> checkedList = (IEnumerable<ListViewItem>)s.Cast<ListViewItem>();
   
            if (checkedList.Any(it=>it.Text=="Available"))
            {
                statusList.Add(ContactAvailability.Free);
                statusList.Add(ContactAvailability.FreeIdle);
            }
            if (checkedList.Any(it=>it.Text=="Away"))
                statusList.Add(ContactAvailability.Away);
            if (clbStatuses.CheckedItems.ContainsKey("Busy"))
            {
                statusList.Add(ContactAvailability.Busy);
                statusList.Add(ContactAvailability.BusyIdle);
            }
            if (clbStatuses.CheckedItems.ContainsKey("Do not disturb"))
                statusList.Add(ContactAvailability.DoNotDisturb);
            return statusList;
        }

        List<string> ToStringList(System.Windows.Forms.ListView.ListViewItemCollection oc)
        {
            List<string> sList = new List<string>();
            foreach (ListViewItem lvi in oc)
                sList.Add(lvi.Text);
            return sList;
        }


        
        private void bRemove_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lvList.SelectedItems)
                lvList.Items.Remove(lvi);
        }


        private void bSearch_Click(object sender, EventArgs e)
        {
            sfdSave.Filter = "CSV (*.csv)|*.*";
            if (sfdSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbLog.Text = sfdSave.FileName.Contains(".csv") ? sfdSave.FileName : sfdSave.FileName+".csv";
        }

    }
}
