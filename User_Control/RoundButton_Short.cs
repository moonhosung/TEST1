using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace User_Control
{
    public partial class RoundButton_Short : UserControl
    {
        public event EventHandler ButtonClick;
        public RoundButton_Short()
        {
            InitializeComponent();
        }

        public void SetColor(Color color)
        {
            this.toggleSwitch1.LookAndFeel.SkinMaskColor = color;
        }

        public void SetText(string Onstr , string Offstr)
        {
            this.toggleSwitch1.Properties.OffText = Offstr;
            this.toggleSwitch1.Properties.OnText = Onstr;
        }

        public void SetEnable(bool enable)
        {
            toggleSwitch1.ReadOnly = !enable;
           // this.toggleSwitch1.Refresh();
        }
        public bool GetEnable()
        {
            return toggleSwitch1.ReadOnly;
            // this.toggleSwitch1.Refresh();
        }
        public void SetToggle()
        {
            toggleSwitch1.Toggle();
            //this.toggleSwitch1.Refresh();
        }
        public bool GetCheck()
        {
            return toggleSwitch1.IsOn;
        }
        private void toggleSwitch1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
        
    }
}
