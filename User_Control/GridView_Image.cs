using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.IO;

namespace User_Control
{
    public partial class GridView_Image : UserControl
    {

        public event EventHandler ButtonClick;
        public GridView_Image()
        {
            InitializeComponent();
        }


        GalleryItemGroup galleryItemGroup1 = new GalleryItemGroup();
        

        public void SetImage(string Path,string name)
        {
            GalleryItem item = new GalleryItem();
            
            item.Caption = name;
            item.ImageOptions.Image = Image.FromFile(Path);

            galleryItemGroup1.Items.Add(item);
        }

        private void GridView_Image_Load(object sender, EventArgs e)
        {


        }
        
        public void SetItems()
        {
            galleryControl1.Gallery.Groups.AddRange(new GalleryItemGroup[] {
            galleryItemGroup1});
        }

        private void galleryControl1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        public string GetFileName()
        {
            GalleryItem temp;
            temp = galleryControl1.Gallery.GetCheckedItem();
            if(temp==null)
            {
                return "";
            }
            return temp.Caption;
        }
    }
}
