using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI_QlKaraoke
{
    public partial class frmDangNhap : Form
    {
        QuanLyNguoiDung ql = new QuanLyNguoiDung();
        public frmDangNhap()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
            }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int kq = ql.CheckConfig();
            if (kq == 1)
            {
                XuLyDangNhap();
            }
            else if (kq == 0)
            {
                MessageBox.Show("Chuỗi kết nối không tồn TẠI");
                SettingConnect();
            }
            else
            {
                MessageBox.Show("Chuỗi kết nối không Phù hợp");
                SettingConnect();
            }
        }

        private void SettingConnect()
        {
            new frmThietLapKetNoi().Show();
        }

        private void XuLyDangNhap()
        {
            int kq;
            kq = ql.QLUser(txtTaiKhoan.Text.ToString(), txtMatKhau.Text.ToString());
            if (kq == 1)
            {
                frmTrangChu frm = new frmTrangChu();
                frm.Show();
            }
            else
                if (kq == 2)
                {
                    MessageBox.Show("Tài khoản không hoạt động");
                }
                else
                {
                    MessageBox.Show("tài khoản không tồn tại");
                }
           
        }
                
        }

        



       
    
}
