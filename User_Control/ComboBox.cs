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
    public partial class ComboBox : UserControl
    {
        public event EventHandler ButtonClick;
        public ComboBox()
        {
            InitializeComponent();
        }
        public string GetSelectedItem()
        {
            if(comboBoxEdit1.SelectedIndex==-1)
            {
                return "";
            }
            return comboBoxEdit1.Properties.Items[comboBoxEdit1.SelectedIndex].ToString();
        }

        public void SetSelectedItem(string str)
        {
            comboBoxEdit1.SelectedText = str;
        }
        public void InsertItem(string str)
        {
            comboBoxEdit1.Properties.Items.Add(str);
        }
        public void ClearItem()
        {
            comboBoxEdit1.Properties.Items.Clear();
        }

        public void SetSelectedIndex(int index)
        {
            comboBoxEdit1.SelectedIndex = index;
        }

        public int GetSelectedIndex()
        {
            return comboBoxEdit1.SelectedIndex;
        }

        public int GetCount()
        {
            return comboBoxEdit1.Properties.Items.Count;
        }
        private void comboBoxEdit1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
