using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control
{
    public partial class Light_Button : UserControl
    {
        public Light_Button()
        {
            InitializeComponent();
        }
        public void SetOnOff(bool OnOff)
        {
            if (OnOff)
            {
                PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_btlight_on;
            }
            else
            {
                PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_btlight_off;
            }
        }
    }

}
