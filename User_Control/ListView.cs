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
    public partial class ListView : UserControl
    {
        public event EventHandler ButtonClick;
        public ListView()
        {
            InitializeComponent();
            listBoxControl1.HorizontalScrollbar = false;            
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        public void SetData()
        {
            listBoxControl1.Items.Add((listBoxControl1.ItemCount+1).ToString());
        }
        private void listBoxControl1_Click(object sender, EventArgs e)
        {
        }

        public int GetFocusIndex()
        {
            return listBoxControl1.SelectedIndex;
        }
        public int GetCount()
        {
            return listBoxControl1.Items.Count;
        }

        public void SetSelectedIndex(int index)
        {
            listBoxControl1.SelectedIndex = index;
        }

        public string GetFocusText()
        {
            int index = listBoxControl1.SelectedIndex;
            return listBoxControl1.Items[index].ToString();
        }
        public void Remove(int index)
        {
            listBoxControl1.Items.RemoveAt(index);
        }
        public void Insert(string text)
        {
            listBoxControl1.Items.Add(text);
        }
        public void Clear()
        {
            listBoxControl1.Items.Clear();
        }
    }
}

