using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Domain.Entities
{
   public class CTDaoTao
    {
        private int _ctDaoTao_Id;
        private string _maCT;
        private string _tenCT;
        private float _thoiGianDaotao;
        private double _hocPhi;
        private DateTime _ngayBanHanh;
        private string _noiDungCT;
        private string _quyDinhBanHanh;
        private string _ghiChu;

        [Key]
        public int CTDaoTao_Id { get => _ctDaoTao_Id; set => _ctDaoTao_Id = value; }
        [Required]
        [MaxLength(32)]
        public string MaCT { get => _maCT; set => _maCT = value; }

        [Required]
        [MaxLength(128)]
        public string TenCT { get => _tenCT; set => _tenCT = value; }

        [Required]
        public float ThoiGianDaotao { get => _thoiGianDaotao; set => _thoiGianDaotao = value; }

        [Required]
        public double HocPhi { get => _hocPhi; set => _hocPhi = value; }
  
        public DateTime NgayBanHanh { get => _ngayBanHanh; set => _ngayBanHanh = value; }

        public string NoiDungCT { get => _noiDungCT; set => _noiDungCT = value; }

        public string QDBanHanh { get => _quyDinhBanHanh; set => _quyDinhBanHanh = value; }

        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }

    }
}
