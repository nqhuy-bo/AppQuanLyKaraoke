using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using AppQuanLyQuanKaraoke;
using System.Drawing;

namespace AppQuanLyQuanKaraoke
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
            
            
        }
        private Form IsActive(Type ftype)// kiểm tra xem form có đang hiện hay ko
        
        {
            foreach (Form f in this.MdiChildren) 
            {
                if (f.GetType() == ftype)
                    return f;
            }
            return null;
        }
       

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themmes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themmes.LookAndFeel.SkinName = "Office 2010 Silver"; // Đây là tên giao diện muốn hiển thị lúc khởi động from
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();

        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap dn = null;
            if (dn == null || dn.IsDisposed) 
            {
                dn = new frmDangNhap();
                dn.ShowDialog();
            }
           
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSanPhamDichVu_Click(object sender, EventArgs e)
        {
            Form f = IsActive(typeof(frmSanPhamDichVu));// kiểm tra xem form có đang hiện hay ko


            if (f == null)
            {
                frmSanPhamDichVu dv = new frmSanPhamDichVu();
                dv.MdiParent = this;
                dv.Show();
            }
            else
                f.Activate();
        }

       

        

      
    }
}