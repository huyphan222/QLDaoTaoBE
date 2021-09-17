using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLDT.BAL.Interface;
using QLDT.Domain.Request.CTDaoTao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLDT.API.Controllers
{
    
    public class CTDaoTaoController : BaseAPIController
    {
        private readonly ICTDaoTaoService _ctDaoTaoService;

        public CTDaoTaoController(ICTDaoTaoService cTDaoTaoService)
        {
            _ctDaoTaoService = cTDaoTaoService;
        }

        
        /// <summary>
        /// Lay CT dao tao bang id
        /// </summary>
        /// ///<param name="id"></param>
        /// <returns>Trả về chương trình đào tạo cần tìm kiếm</returns>
        [HttpGet("LayCTDaoTaoBangId/{id}")]
        public async Task<IActionResult> LayCTDaoTaoBangId(int id)
        {
            return Ok(await _ctDaoTaoService.LayCTDaoTaoBangId(id));
        }


        ///<summary>
        ///Danh sach chuong trinh dao tao
        ///</summary>
        ///<returns>Trả về danh sach chương trình đào tạo</returns>
        [HttpGet("DanhSachCTDaoTao")]
        public async Task<IActionResult> DanhSachCTDaoTao()
        {
            return Ok(await _ctDaoTaoService.DanhSachCTDaoTao());
        }

        ///<summary>
        ///Tao chuong trinh dao tao
        ///</summary>
        ///<param name="request"></param>
        ///<returns>Trả về khi tạo được 1 chương trình đào tạo</returns>
        [HttpPost("TaoCTDaoTao")]
        public async Task<IActionResult> TaoCTDaoTao(TaoCTDaoTaoReq request)
        {
            return Ok(await _ctDaoTaoService.TaoCTDaoTao(request));
        }

        ///<summary>
        ///Sua chuong trinh dao tao
        ///</summary>
        ///<param name="request"></param>
        ///<returns>Trả về khi sửa trường tình đào tạo</returns>
        [HttpPut("SuaCTDaoTao")]
        public async Task<IActionResult> SuaCTDaoTao(SuaCTDaoTaoReq request)
        {
            return Ok(await _ctDaoTaoService.SuaCTDaoTao(request));
        }


        /// <summary>
        /// Xoa chuong trinh dao tao bang id
        /// </summary>
        /// ///<param name="id"></param>
        /// <returns>Xóa chương trình đào tạo</returns>
        [HttpDelete("XoaCTDaoTao/{id}")]
        public async Task<IActionResult> XoaCTDaoTao(int id)
        {
            return Ok(await _ctDaoTaoService.XoaCTDaoTao(id));
        }

        /// <summary>
        /// Khoi phuc chuong trinh dao tao bang id
        /// </summary>
        /// ///<param name="id"></param>
        /// <returns>Khoi phuc chương trình đào tạo</returns>
        [HttpPut("KhoiPhucCTDaoTao/{id}")]
        public async Task<IActionResult> KhoiPhucCTDaoTao(int id)
        {
            return Ok(await _ctDaoTaoService.KhoiPhucCTDaoTao(id));
        }


        ///<summary>
        ///Danh sach chuong trinh dao tao Vo hieu luc
        ///</summary>
        ///<returns>Trả về danh sach chương trình đào tạo</returns>
        [HttpGet("DanhSachCTDaoTaoVoHieuLuc")]
        public async Task<IActionResult> DanhSachCTDaoTaoVoHieuLuc()
        {
            return Ok(await _ctDaoTaoService.DanhSachCTDaoTaoVoHieuLuc());
        }

    }
}
