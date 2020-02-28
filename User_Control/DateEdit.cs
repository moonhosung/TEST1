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
    public partial class DateEdit : UserControl
    {
        public event EventHandler Mouseclick;
        public event EventHandler Closed;
        public DateEdit()
        {
            InitializeComponent();
        }

        private void dateEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

            if (this.Closed != null)
                this.Closed(this, e);
        }
        public void SetDate(DateTime date)
        {
            dateEdit1.Properties.MinValue = date;
        }
        public DateTime GetDate()
        {
            return dateEdit1.DateTime;
        }
        public void SetMaxDate()
        {
            dateEdit1.Properties.MaxValue = DateTime.Now;
        }
        private void dateEdit1_Click(object sender, EventArgs e)
        {
            dateEdit1.ShowPopup();
            if (this.Mouseclick != null)
                this.Mouseclick(this, e);
        }
    }
}
