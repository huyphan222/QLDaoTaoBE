using QLDT.DAL.Interface;
using QLDT.Domain.Request.LopHoc;
using QLDT.Domain.Response.LopHoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using QLDT.Domain.Entities;

namespace QLDT.DAL
{
   public class LopHocRepository : BaseConnection,ILopHocRepository 
    {
        public async Task<IEnumerable<LopHoc>> LayDanhSachLopHoc()
        {         
                using (var result = SqlMapper.QueryAsync<LopHoc>(cnn: connection,
                                                                    sql: "sp_DanhSachLopHoc",
                                                                    commandType: CommandType.StoredProcedure))

                {
                    try
                    {
                        IEnumerable<LopHoc> list = await result;
                        return await result;
                    }
                    catch (Exception)
                    {

                        return new List<LopHoc>();
                    }
                }
            
        }
    
        public async Task<IEnumerable<LopHoc>> LayDanhSachLopHocTheoCTDaoTao(int CTDaoTao_Id)
        {         
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CTDaoTao_Id", CTDaoTao_Id);
                using (var result = SqlMapper.QueryAsync<LopHoc>(cnn: connection,
                                                                 sql: "sp_DanhSachLopHocTheoCTDaoTao",
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

        public async Task<LopHoc> LayLopHocId(int id)
        {           
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                using (var result = SqlMapper.QueryFirstOrDefaultAsync<LopHoc>(cnn: connection,
                                                                                 sql: "sp_LayLopHocBangId",
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

        public async Task<SuaLopHocRes> SuaLopHoc(SuaLopHocReq request)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LopHoc_Id", request.LopHoc_Id);
            parameters.Add("@CTDaoTao_Id", request.CTDaoTao_Id);
            parameters.Add("@MaLop", request.MaLop);
            parameters.Add("@TenLop", request.TenLop);
            parameters.Add("@NgayKhaiGiang", request.NgayKhaiGiang);
            parameters.Add("@NgayKetThuc", request.NgayKetThuc);
            parameters.Add("@SoLuongHV", request.SoLuongHV);
            parameters.Add("@QDMoLop", request.QDMoLop);
            parameters.Add("@ThoiKhoaBieu", request.ThoiKhoaBieu);
            parameters.Add("@GhiChu", request.GhiChu);

            using (var result = SqlMapper
                                .QueryFirstAsync<SuaLopHocRes>(cnn: connection,
                                                                          sql: "sp_SuaLopHoc",
                                                                          param: parameters,
                                                                          commandType: CommandType.StoredProcedure))
                try
                {
                    return await result;
                }
                catch (Exception)
                {

                    return new SuaLopHocRes();
                }
        }

        public async Task<TaoLopHocRes> TaoLopHoc(TaoLopHocReq request)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CTDaoTao_Id", request.CTDaoTao_Id);
            parameters.Add("@MaLop", request.MaLop);
            parameters.Add("@TenLop", request.TenLop);
            parameters.Add("@NgayKhaiGiang", request.NgayKhaiGiang);
            parameters.Add("@NgayKetThuc", request.NgayKetThuc);
            parameters.Add("@SoLuongHV", request.SoLuongHV);
            parameters.Add("@QDMoLop", request.QDMoLop);
            parameters.Add("@ThoiKhoaBieu", request.ThoiKhoaBieu);
            parameters.Add("@GhiChu", request.GhiChu);

            using (var result = SqlMapper
                                .QueryFirstOrDefaultAsync<TaoLopHocRes>(cnn: connection,
                                                                          sql: "sp_TaoLopHoc",
                                                                          param: parameters,
                                                                          commandType: CommandType.StoredProcedure))
                try
                {
                    return await result;
                }
                catch (Exception)
                {

                    return new TaoLopHocRes();
                }
        }

        public async Task<int> XoaLopHoc(int id)
        {
            
                try
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Id", id);
                    var result = SqlMapper.ExecuteScalarAsync<int>(cnn: connection,
                                                               sql: "sp_XoaLopHoc",
                                                              param: parameters,
                                                              commandType: CommandType.StoredProcedure);
                    return await result;

                }
                catch (Exception)
                {

                    throw;
                }
        }       
    }
}
