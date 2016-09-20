using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyncTracker.Logic
{
    class ControlsEnabler
    {
        List<Control> _ctrlList = new List<Control>();

        public void AddControl(Control ctrl)
        {
            _ctrlList.Add(ctrl);
        }

        public void CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in _ctrlList)
                ctrl.Enabled = ((CheckBox)sender).Checked;
        }
    }
}
