using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QLKaraoke
{
    class QuanLyNguoiDung
    {
        public int CheckConfig()
        {
            if (GUI_QlKaraoke.Properties.Settings.Default.connect_karaoke == String.Empty)
            {
                return 0;//chuỗi cấu hình không tồn tại
            }
            try
            {
                SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.connect_karaoke);

                if (_Sqlconn.State == ConnectionState.Closed)
                {
                    _Sqlconn.Open();

                }
                return 1;//Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {

                return 2;//Chuỗi cấu hình không phù hợp 
            }

        }

        public int QLUser(string user, string pass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE TENDANGNHAP = '" + user + "' AND MATKHAU = '" + pass + "'", Properties.Settings.Default.connect_karaoke);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 0;//User không tồn tại
            }
            else
            {
                if (dt.Rows[0][2] == null || dt.Rows[0][2] == "0")//Kiểm tra trạng thái của tài khoản
                {
                    return 2;//Tài khoản không hoạt động
                }

            }
            return 1;//Kết nối thành công

        }

        public DataTable getServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable getDatabaseName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
            "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " +
            pPass + "");
            da.Fill(dt);
            return dt;

        }

        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            GUI_QlKaraoke.Properties.Settings.Default.connect_karaoke = "Data Source=" + pServer +
            ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            GUI_QlKaraoke.Properties.Settings.Default.Save();
        }
    }
}
