using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKaraoke
{
    public class DTO_NhanVien
    {
        private int _MaNhanVien;
        private string _TenNhanVien;
        private string _TenDangNhap;
        private string _MatKhau;
        private int _PhanQuyen; //1 là quản lý 0 là nhân viên

        public int MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        

        public string TenNhanVien
        {
            get { return _TenNhanVien; }
            set { _TenNhanVien = value; }
        }
        

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }
        

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        

        public int PhanQuyen
        {
            get { return _PhanQuyen; }
            set { _PhanQuyen = value; }
        }

        public DTO_NhanVien(int ma, string hoten, string tendangnhap, string matkhau, int phanquyen)
        {
            this.MaNhanVien = ma;
            this.TenNhanVien = hoten;
            this.TenDangNhap = tendangnhap;
            this.MatKhau = matkhau;
            this.PhanQuyen = phanquyen;
        }

    }
}
