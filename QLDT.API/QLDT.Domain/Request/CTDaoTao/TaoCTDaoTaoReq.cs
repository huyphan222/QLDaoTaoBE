using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Domain.Request.CTDaoTao
{
    public class TaoCTDaoTaoReq
    {
        private string _maCT;
        private string _tenCT;
        private float _thoiGianDaotao;
        private double _hocPhi;      
        private DateTime _ngayBanHanh;
        private string _noiDungCT;
        private string _quyDinhBanHanh;
        private string _ghiChu;

        public string MaCT { get => _maCT; set => _maCT = value; }
        public string TenCT { get => _tenCT; set => _tenCT = value; }
        public float ThoiGianDaotao { get => _thoiGianDaotao; set => _thoiGianDaotao = value; }
        public double HocPhi { get => _hocPhi; set => _hocPhi = value; }       
        public DateTime NgayBanHanh { get => _ngayBanHanh; set => _ngayBanHanh = value; }
        public string NoiDungCT { get => _noiDungCT; set => _noiDungCT = value; }
        public string QDBanHanh { get => _quyDinhBanHanh; set => _quyDinhBanHanh = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
    }
}
