using QLDT.Domain.Entities;
using QLDT.Domain.Request.LopHoc;
using QLDT.Domain.Response.LopHoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DAL.Interface
{
   public interface ILopHocRepository
    {
        Task<TaoLopHocRes> TaoLopHoc(TaoLopHocReq request);

        Task<SuaLopHocRes> SuaLopHoc(SuaLopHocReq request);

        Task<IEnumerable<LopHoc>> LayDanhSachLopHoc();

        Task<IEnumerable<LopHoc>> LayDanhSachLopHocTheoCTDaoTao(int CTDaoTao_Id);

        Task<LopHoc> LayLopHocId(int id);

        Task<int> XoaLopHoc(int id);


    }
}
