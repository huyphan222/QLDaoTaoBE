using QLDT.Domain.Entities;
using QLDT.Domain.Request.CTDaoTao;
using QLDT.Domain.Response.CTDaoTao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.BAL.Interface
{
    public interface ICTDaoTaoService
    {
        Task<TaoCTDaoTaoRes> TaoCTDaoTao(TaoCTDaoTaoReq request);

        Task<SuaCTDaoTaoRes> SuaCTDaoTao(SuaCTDaoTaoReq request);

        Task<IEnumerable<CTDaoTao>> DanhSachCTDaoTao();

        Task<IEnumerable<CTDaoTao>> DanhSachCTDaoTaoVoHieuLuc();

        Task<CTDaoTao> LayCTDaoTaoBangId(int id);

        Task<int> XoaCTDaoTao(int id);

        Task<int> KhoiPhucCTDaoTao(int id);
    }
}
