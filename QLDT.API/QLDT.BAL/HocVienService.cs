using QLDT.BAL.Interface;
using QLDT.DAL.Interface;
using QLDT.Domain.Entities;
using QLDT.Domain.Request.HocVien;
using QLDT.Domain.Response.HocVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.BAL
{
    public class HocVienService : IHocVienService
    {
        private readonly IHocVienRepository _hocVienRepository;

        public HocVienService(IHocVienRepository hocVienRepository)
        {
            _hocVienRepository = hocVienRepository;
        }

        public async Task<IEnumerable<HocVien>> DanhSachHocVien()
        {
            return await _hocVienRepository.DanhSachHocVien();
        }

        public async Task<HocVien> LayHocVienBangId(int id)
        {
            return await _hocVienRepository.LayHocVienBangId(id);
        }

        public async Task<SuaHocVienRes> SuaHocVien(SuaHocVienReq request)
        {
            return await _hocVienRepository.SuaHocVien(request);
        }

        public async Task<TaoHocVienRes> TaoHocVien(TaoHocVienReq request)
        {
            return await _hocVienRepository.TaoHocVien(request);
        }

        public async Task<int> XoaHocVien(int id)
        {
            return await _hocVienRepository.XoaHocVien(id);
        }

        public async Task<IEnumerable<HocVien>> LayDanhSachHocVienTheoLopHoc(int LopHoc_Id)
        {
            return await _hocVienRepository.LayDanhSachHocVienTheoLopHoc(LopHoc_Id);
        }
    }
}
