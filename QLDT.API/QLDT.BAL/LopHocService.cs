using QLDT.BAL.Interface;
using QLDT.DAL.Interface;
using QLDT.Domain.Entities;
using QLDT.Domain.Request.LopHoc;
using QLDT.Domain.Response.LopHoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.BAL
{
   public class LopHocService : ILopHocService
    {
        private ILopHocRepository _lopHocRepository;

        public LopHocService(ILopHocRepository lopHocRepository)
        {
            _lopHocRepository = lopHocRepository;
        }

        public async Task<TaoLopHocRes> TaoLopHoc(TaoLopHocReq request)
        {
            return await _lopHocRepository.TaoLopHoc(request);
        }

        
        public async Task<SuaLopHocRes> SuaLopHoc(SuaLopHocReq request)
        {
            return await _lopHocRepository.SuaLopHoc(request);
        }

        public async Task<IEnumerable<LopHoc>> LayDanhSachLopHoc()
        {
            return await _lopHocRepository.LayDanhSachLopHoc();
        }

        public async Task<IEnumerable<LopHoc>> LayDanhSachLopHocTheoCTDaoTao(int CTDaoTao_Id)
        {
            return await _lopHocRepository.LayDanhSachLopHocTheoCTDaoTao(CTDaoTao_Id);
        }

        public async Task<int> XoaLopHoc(int id)
        {
            return await _lopHocRepository.XoaLopHoc(id);
        }

        public async Task<LopHoc> LayLopHocId(int id)
        {
            return await _lopHocRepository.LayLopHocId(id);
        }
    }
}
