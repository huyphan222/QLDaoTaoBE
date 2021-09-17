using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Domain.Request.HocVien
{
   public class TaoHocVienReq
    {
        private string _maHV;
        private string _hoTen;
        private DateTime _ngaySinh;
        private string _noiSinh;
        private string _diaChi;
        private string _gioiTinh;
        private string _sDT;
        private string _hinhAnh;
        private string _email;
        //NBT Người bảo trợ
        private string _hoTenNBT;
        private string _sDTNBT;
        private string _trinhDo;
        private string _chuyenNganh;
        private string _ngheNghiep;
        private string _nguyenQuan;
        private string _danToc;
        private string _soQDHocNghe;
        private string _soBHXH;
        private string _tenCoQuan;
        private string _chucVu;
        private string _ghiChu;
        private int _lopHoc_Id;

        public string MaHV { get => _maHV; set => _maHV = value; }

        public string HoTen { get => _hoTen; set => _hoTen = value; }

        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }

        public string NoiSinh { get => _noiSinh; set => _noiSinh = value; }

        public string DiaChi { get => _diaChi; set => _diaChi = value; }

        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }

        public string SDT { get => _sDT; set => _sDT = value; }

        public string HinhAnh { get => _hinhAnh; set => _hinhAnh = value; }

        public string Email { get => _email; set => _email = value; }

        public string HoTenNBT { get => _hoTenNBT; set => _hoTenNBT = value; }

        public string SDTNBT { get => _sDTNBT; set => _sDTNBT = value; }

        public string TrinhDo { get => _trinhDo; set => _trinhDo = value; }

        public string ChuyenNganh { get => _chuyenNganh; set => _chuyenNganh = value; }

        public string NgheNghiep { get => _ngheNghiep; set => _ngheNghiep = value; }

        public string NguyenQuan { get => _nguyenQuan; set => _nguyenQuan = value; }

        public string DanToc { get => _danToc; set => _danToc = value; }

        public string SoQDHocNghe { get => _soQDHocNghe; set => _soQDHocNghe = value; }

        public string SoBHXH { get => _soBHXH; set => _soBHXH = value; }

        public string TenCoQuan { get => _tenCoQuan; set => _tenCoQuan = value; }

        public string ChucVu { get => _chucVu; set => _chucVu = value; }

        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }

        public int LopHoc_Id { get => _lopHoc_Id; set => _lopHoc_Id = value; }
    }
}
