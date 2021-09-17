using QLDT.Domain.Entities;
using QLDT.Domain.Request.CTDaoTao;
using QLDT.Domain.Response.CTDaoTao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DAL.Interface
{
    public interface ICTDaoTaoRepository
    {
  
        Task<TaoCTDaoTaoRes> TaoCTDaoTao(TaoCTDaoTaoReq request);

        Task<SuaCTDaoTaoRes> SuaCTDaoTao(SuaCTDaoTaoReq request);

        Task<IEnumerable<CTDaoTao>> LayDanhSachCTDaoTao();

        Task<IEnumerable<CTDaoTao>> LayDanhSachCTDaoTaoVoHieuLuc();

        Task<CTDaoTao> LayCTDaoTaoBangId(int id);

        Task<int> XoaCTDaoTao(int id);

        Task<int> KhoiPhucCTDaoTao(int id);

    }
}
