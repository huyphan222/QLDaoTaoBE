using QLDT.Domain.Entities;
using QLDT.Domain.Request.HocVien;
using QLDT.Domain.Response.HocVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DAL.Interface
{
   public interface IHocVienRepository
    {
        Task<TaoHocVienRes> TaoHocVien(TaoHocVienReq request);

        Task<SuaHocVienRes> SuaHocVien(SuaHocVienReq request);

        Task<IEnumerable<HocVien>> LayDanhSachHocVienTheoLopHoc(int LopHoc_Id);

        Task<HocVien> LayHocVienBangId(int id);

        Task<int> XoaHocVien(int id);

        Task<IEnumerable<HocVien>> DanhSachHocVien();

    }
}
