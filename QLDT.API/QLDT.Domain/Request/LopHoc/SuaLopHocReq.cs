using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Domain.Request.LopHoc
{
   public class SuaLopHocReq
    {
        private int _lopHoc_Id;
        private int _cTDaoTao_Id;
        private string _maLop;
        private string _tenLop;
        private DateTime _ngayKhaiGiang;
        private DateTime _ngayKetThuc;
        private int _soLuongHV;
        private string _qDMoLop;
        private string _thoiKhoaBieu;
        private string _ghiChu;


        public int LopHoc_Id { get => _lopHoc_Id; set => _lopHoc_Id = value; }

        public int CTDaoTao_Id { get => _cTDaoTao_Id; set => _cTDaoTao_Id = value; }

        public string MaLop { get => _maLop; set => _maLop = value; }

        public string TenLop { get => _tenLop; set => _tenLop = value; }

        public DateTime NgayKhaiGiang { get => _ngayKhaiGiang; set => _ngayKhaiGiang = value; }

        public DateTime NgayKetThuc { get => _ngayKetThuc; set => _ngayKetThuc = value; }

        public int SoLuongHV { get => _soLuongHV; set => _soLuongHV = value; }

        public string QDMoLop { get => _qDMoLop; set => _qDMoLop = value; }

        public string ThoiKhoaBieu { get => _thoiKhoaBieu; set => _thoiKhoaBieu = value; }

        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        
    }
}
