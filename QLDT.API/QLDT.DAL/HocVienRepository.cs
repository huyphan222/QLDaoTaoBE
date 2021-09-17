using Dapper;
using QLDT.DAL.Interface;
using QLDT.Domain.Entities;
using QLDT.Domain.Request.HocVien;
using QLDT.Domain.Response.HocVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DAL
{
    public class HocVienRepository : BaseConnection, IHocVienRepository
    {
        public async Task<IEnumerable<HocVien>> DanhSachHocVien()
        {        
                using (var result = SqlMapper.QueryAsync<HocVien>(cnn: connection,
                                                                    sql: "sp_DanhSachHocVien",
                                                                    commandType: CommandType.StoredProcedure))

                {
                    try
                    {
                        IEnumerable<HocVien> list = await result;
                        return await result;
                    }
                    catch (Exception)
                    {

                        return new List<HocVien>();
                    }
                }

            
        }

        public async Task<TaoHocVienRes> TaoHocVien(TaoHocVienReq request)
        {
           
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaHv", request.MaHV);
            parameters.Add("@HoTen", request.HoTen);
            parameters.Add("@NgaySinh", request.NgaySinh);
            parameters.Add("@NoiSinh", request.NoiSinh);
            parameters.Add("@DiaChi", request.DiaChi);
            parameters.Add("@GioiTinh", request.GioiTinh);
            parameters.Add("@SDT", request.SDT);
            parameters.Add("@HinhAnh", request.HinhAnh);
            parameters.Add("@Email", request.Email);
            parameters.Add("@HoTenNBT", request.HoTenNBT);
            parameters.Add("@SDTNBT", request.SDTNBT);
            parameters.Add("@TrinhDo", request.TrinhDo);
            parameters.Add("@ChuyenNganh", request.ChuyenNganh);
            parameters.Add("@NgheNghiep", request.NgheNghiep);
            parameters.Add("@NguyenQuan", request.NguyenQuan);
            parameters.Add("@DanToc", request.DanToc);
            parameters.Add("@SoQDHocNghe", request.SoQDHocNghe);
            parameters.Add("@SoBHXH", request.SoBHXH);
            parameters.Add("@TenCoQuan", request.TenCoQuan);
            parameters.Add("@ChucVu", request.ChucVu);
            parameters.Add("@GhiChu", request.GhiChu);
            parameters.Add("@LopHoc_Id", request.LopHoc_Id);

                using (var result = SqlMapper
                                    .QueryFirstOrDefaultAsync<TaoHocVienRes>(cnn: connection,
                                                                              sql: "sp_TaoHocVien",
                                                                              param: parameters,
                                                                              commandType: CommandType.StoredProcedure))
                    try
                    {
                        return await result;
                    }
                    catch (Exception)
                    {

                        return new TaoHocVienRes();
                    }
        }


        public async Task<SuaHocVienRes> SuaHocVien(SuaHocVienReq request)
        {

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HocVien_Id", request.HocVien_id);
            parameters.Add("@MaHv", request.MaHV);
            parameters.Add("@HoTen", request.HoTen);
            parameters.Add("@NgaySinh", request.NgaySinh);
            parameters.Add("@NoiSinh", request.NoiSinh);
            parameters.Add("@DiaChi", request.DiaChi);
            parameters.Add("@GioiTinh", request.GioiTinh);
            parameters.Add("@SDT", request.SDT);
            parameters.Add("@HinhAnh", request.HinhAnh);
            parameters.Add("@Email", request.Email);
            parameters.Add("@HoTenNBT", request.HoTenNBT);
            parameters.Add("@SDTNBT", request.SDTNBT);
            parameters.Add("@TrinhDo", request.TrinhDo);
            parameters.Add("@ChuyenNganh", request.ChuyenNganh);
            parameters.Add("@NgheNghiep", request.NgheNghiep);
            parameters.Add("@NguyenQuan", request.NguyenQuan);
            parameters.Add("@DanToc", request.DanToc);
            parameters.Add("@SoQDHocNghe", request.SoQDHocNghe);
            parameters.Add("@SoBHXH", request.SoBHXH);
            parameters.Add("@TenCoQuan", request.TenCoQuan);
            parameters.Add("@ChucVu", request.ChucVu);
            parameters.Add("@GhiChu", request.GhiChu);
            parameters.Add("@LopHoc_Id", request.LopHoc_Id);

            using (var result = SqlMapper
                                .QueryFirstAsync<SuaHocVienRes>(cnn: connection,
                                                                          sql: "sp_SuaHocVien",
                                                                          param: parameters,
                                                                          commandType: CommandType.StoredProcedure))
                try
                {
                    return await result;
                }
                catch (Exception)
                {

                    return new SuaHocVienRes();
                }
        }

        public async Task<HocVien> LayHocVienBangId(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            using (var result = SqlMapper.QueryFirstOrDefaultAsync<HocVien>(cnn: connection,
                                                                             sql: "sp_LayHocVienBangId",
                                                                             param: parameters,
                                                                             commandType: CommandType.StoredProcedure))

            {
                try
                {
                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public async Task<int> XoaHocVien(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                var result = SqlMapper.ExecuteScalarAsync<int>(cnn: connection,
                                                           sql: "sp_XoaHocVien",
                                                          param: parameters,
                                                          commandType: CommandType.StoredProcedure);
                return await result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<HocVien>> LayDanhSachHocVienTheoLopHoc(int LopHoc_Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LopHoc_Id", LopHoc_Id);
            using (var result = SqlMapper.QueryAsync<HocVien>(cnn: connection,
                                                             sql: "sp_DanhSachHocVienTheoLopHoc",
                                                             param: parameters,
                                                             commandType: CommandType.StoredProcedure))

            {
                try
                {
                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
