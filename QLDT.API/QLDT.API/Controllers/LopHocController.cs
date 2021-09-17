using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLDT.BAL.Interface;
using QLDT.Domain.Request.LopHoc;
using QLDT.Domain.Response.LopHoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLDT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopHocController : BaseAPIController
    {
        private readonly ILopHocService _lopHocService;

        public LopHocController(ILopHocService lopHocService)
        {
            _lopHocService = lopHocService;
        }

        /// <summary>
        /// Lấy lớp học bằng id
        /// </summary>
        /// ///<param name="id"></param>
        /// <returns>Trả về lớp học  cần tìm kiếm</returns>
        [HttpGet("LayLopHocBangId/{id}")]
        public async Task<IActionResult> LayLopHocBangId(int id)
        {
            return Ok(await _lopHocService.LayLopHocId(id));
        }


        ///<summary>
        ///Danh sach lợp học hiện có
        ///</summary>
        ///<returns>Trả về danh sach lớp học</returns>
        [HttpGet("DanhSachLopHoc")]
        public async Task<IActionResult> DanhSachLopHoc()
        {
            return Ok(await _lopHocService.LayDanhSachLopHoc());
        }

        ///<summary>
        ///Danh sach lớp học hiện có theo chương trình đào tạo
        ///</summary>
        [HttpGet("DanhSachLopHocTheoCTDaoTao/{CTDaoTao_Id}")]
        public async Task<IActionResult> DanhSachLopHocTheoCTDaoTao(int CTDaoTao_Id)
        {
            return Ok(await _lopHocService.LayDanhSachLopHocTheoCTDaoTao(CTDaoTao_Id));
        }




        ///<summary>
        ///Tạo lớp học
        ///</summary>
        ///<param name="request"></param>
        ///<returns>Trả về khi tạo được 1 lớp học </returns>
        [HttpPost("TaoLopHoc")]
        public async Task<IActionResult> TaoLopHoc(TaoLopHocReq request)
        {
            return Ok(await _lopHocService.TaoLopHoc(request));
        }

        ///<summary>
        ///Sửa lớp học
        ///</summary>
        ///<param name="request"></param>
        ///<returns>Trả về khi sửa lớp học</returns>
        [HttpPut("SuaLopHoc")]
        public async Task<IActionResult> SuaLopHoc(SuaLopHocReq request)
        {
            return Ok(await _lopHocService.SuaLopHoc(request));
        }



        /// <summary>
        /// Xoa chuong lop hoc bang id
        /// </summary>
        /// ///<param name="id"></param>
        /// <returns>Xóa lớp học</returns>
        [HttpDelete("XoaLopHoc/{id}")]
        public async Task<IActionResult> XoaLopHoc(int id)
        {
            return Ok(await _lopHocService.XoaLopHoc(id));
        }



    }
}
