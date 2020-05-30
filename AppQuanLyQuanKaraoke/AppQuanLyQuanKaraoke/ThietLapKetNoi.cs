using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLKaraoke
{
    public partial class frmThietLapKetNoi : Form
    {
        QuanLyNguoiDung qlnd = new QuanLyNguoiDung();
        public frmThietLapKetNoi()
        {
            InitializeComponent();
        }

        private void cbServerName_DropDown(object sender, EventArgs e)
        {
            /*cbServerName.DataSource = qlnd.getServerName();
            cbServerName.DisplayMember = "ServerName";*/
        }

        private void cbDataBaseName_DropDown(object sender, EventArgs e)
        {
            cbDataBaseName.DataSource = qlnd.getDatabaseName(cbServerName.Text, txtUsername.Text, txtPassword.Text);
            cbDataBaseName.DisplayMember = "name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            qlnd.SaveConfig(cbServerName.Text, txtUsername.Text, txtPassword.Text, cbDataBaseName.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThietLapKetNoi_Load(object sender, EventArgs e)
        {
            cbServerName.DataSource = qlnd.getServerName();
            cbServerName.DisplayMember = "ServerName";
        }

    }
}
