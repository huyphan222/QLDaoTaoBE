using QLDT.BAL.Interface;
using QLDT.DAL.Interface;
using QLDT.Domain.Entities;
using QLDT.Domain.Request.CTDaoTao;
using QLDT.Domain.Response.CTDaoTao;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLDT.BAL
{
    public class CTDaoTaoService : ICTDaoTaoService
    {
        private ICTDaoTaoRepository _ctDaoTaoRepository;

        public CTDaoTaoService(ICTDaoTaoRepository cTDaoTaoRepository)
        {
            _ctDaoTaoRepository = cTDaoTaoRepository;
        }

        public async Task<TaoCTDaoTaoRes> TaoCTDaoTao(TaoCTDaoTaoReq request)
        {
            return await _ctDaoTaoRepository.TaoCTDaoTao(request);
        }

        public async Task<SuaCTDaoTaoRes> SuaCTDaoTao(SuaCTDaoTaoReq request)
        {
            return await _ctDaoTaoRepository.SuaCTDaoTao(request);
        }

        public async Task<IEnumerable<CTDaoTao>> DanhSachCTDaoTao()
        {
            return await _ctDaoTaoRepository.LayDanhSachCTDaoTao();
        }

        public async Task<CTDaoTao> LayCTDaoTaoBangId(int id)
        {
            return await _ctDaoTaoRepository.LayCTDaoTaoBangId(id);
        }

        public async Task<int> XoaCTDaoTao(int id)
        {
            return await _ctDaoTaoRepository.XoaCTDaoTao(id);
        }

        public async Task<IEnumerable<CTDaoTao>> DanhSachCTDaoTaoVoHieuLuc()
        {
            return await _ctDaoTaoRepository.LayDanhSachCTDaoTaoVoHieuLuc();
        }

        public async Task<int> KhoiPhucCTDaoTao(int id)
        {
            return await _ctDaoTaoRepository.KhoiPhucCTDaoTao(id);
        }
    }
}
