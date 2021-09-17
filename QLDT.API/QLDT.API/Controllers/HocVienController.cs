using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLDT.BAL.Interface;
using QLDT.Domain.Request.HocVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLDT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocVienController : BaseAPIController
    {
        private readonly IHocVienService _hocVienService;

        public HocVienController(IHocVienService hocVienService)
        {
            _hocVienService = hocVienService;
        }

        ///<summary>
        ///Tạo lớp học
        ///</summary>
        ///<param name="request"></param>
        ///<returns>Trả về khi tạo được 1  học vien </returns>
        [HttpPost("TaoHocVien")]
        public async Task<IActionResult> TaoHocVien(TaoHocVienReq request)
        {
            return Ok(await _hocVienService.TaoHocVien(request));
        }

        ///<summary>
        ///Danh sach học viên hiện có
        ///</summary>
        ///<returns>Trả về danh sach học viên</returns>
        [HttpGet("DanhSachHocVien")]
        public async Task<IActionResult> DanhSachHocVien()
        {
            return Ok(await _hocVienService.DanhSachHocVien());
        }

        ///<summary>
        ///Danh sách học viên theo lớp học
        ///</summary>
        ///<param name="LopHoc_Id"></param>
        ///<returns>Trả về danh sách học viên  </returns>
        [HttpGet("DanhSachHocVienTheoLopHoc/{LopHoc_Id}")]
        public async Task<IActionResult> DanhSachLopHocTheoCTDaoTao(int LopHoc_Id)
        {
            return Ok(await _hocVienService.LayDanhSachHocVienTheoLopHoc(LopHoc_Id));
        }


        /// <summary>
        /// Lay học viên bằng id
        /// </summary>
        /// ///<param name="id"></param>
        /// <returns>Trả về học viên cần tìm kiếm</returns>
        [HttpGet("LayHocVienBangId/{id}")]
        public async Task<IActionResult> LayHocVienBangId(int id)
        {
            return Ok(await _hocVienService.LayHocVienBangId(id));
        }

        ///<summary>
        ///Sửa học viên
        ///</summary>
        ///<param name="request"></param>
        ///<returns>Trả về học viên khi sửa học viên</returns>
        [HttpPut("SuaHocVien")]
        public async Task<IActionResult> SuaHocVien(SuaHocVienReq request)
        {
            return Ok(await _hocVienService.SuaHocVien(request));
        }

        /// <summary>
        /// Xoa hoc vien bằng Id
        /// </summary>
        /// ///<param name="id"></param>
        /// <returns>Xóa chương trình đào tạo</returns>
        [HttpDelete("XoaHocVien/{id}")]
        public async Task<IActionResult> XoaHocVien(int id)
        {
            return Ok(await _hocVienService.XoaHocVien(id));
        }

    }
}
