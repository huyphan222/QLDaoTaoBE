using QLDT.Domain.Entities;
using QLDT.Domain.Request.HocVien;
using QLDT.Domain.Response.HocVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.BAL.Interface
{
   public interface IHocVienService
    {
        Task<TaoHocVienRes> TaoHocVien(TaoHocVienReq request);

        Task<IEnumerable<HocVien>> DanhSachHocVien();

        Task<SuaHocVienRes> SuaHocVien(SuaHocVienReq request);

        Task<IEnumerable<HocVien>> LayDanhSachHocVienTheoLopHoc(int LopHoc_Id);

        Task<HocVien> LayHocVienBangId(int id);

        Task<int> XoaHocVien(int id);
    }
}
