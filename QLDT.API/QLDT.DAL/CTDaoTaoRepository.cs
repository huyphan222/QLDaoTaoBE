using Dapper;
using QLDT.DAL.Interface;
using QLDT.Domain.Entities;
using QLDT.Domain.Request.CTDaoTao;
using QLDT.Domain.Response.CTDaoTao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace QLDT.DAL
{
    public class CTDaoTaoRepository : BaseConnection, ICTDaoTaoRepository
    {
       
        public async Task<CTDaoTao> LayCTDaoTaoBangId(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            using (var result = SqlMapper.QueryFirstOrDefaultAsync<CTDaoTao>(cnn: connection,
                                                                             sql: "sp_LayCTDaoTaoBangId",
                                                                             param: parameters,
                                                                             commandType:CommandType.StoredProcedure))

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

        public async Task<IEnumerable<CTDaoTao>> LayDanhSachCTDaoTao()
        {
            using (var result = SqlMapper.QueryAsync<CTDaoTao>(cnn: connection,
                                                                sql:"sp_DanhSachCTDaoTao",
                                                                commandType:CommandType.StoredProcedure ))

            {
                try
                {
                    IEnumerable<CTDaoTao> list = await result;
                    return await result;
                }
                catch (Exception)
                {

                    return new List<CTDaoTao>();
                }
            }
        }


        public async Task<SuaCTDaoTaoRes> SuaCTDaoTao(SuaCTDaoTaoReq request)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CTDaoTao_Id", request.Id);
            parameters.Add("@MaCT", request.MaCT);
            parameters.Add("@TenCT", request.TenCT);
            parameters.Add("@ThoiGianDaoTao", request.ThoiGianDaotao);
            parameters.Add("@HocPhi", request.HocPhi);         
            parameters.Add("@NgayBanHanh", request.NgayBanHanh);
            parameters.Add("@NoiDungCT", request.NoiDungCT);
            parameters.Add("@QDBanHanh", request.QDBanHanh);
            parameters.Add("@GhiChu", request.GhiChu);

            using (var result = SqlMapper
                                 .QueryFirstAsync<SuaCTDaoTaoRes>(cnn: connection,
                                                                  sql: "sp_SuaCTDaoTao",
                                                                  param:parameters,
                                                                  commandType:CommandType.StoredProcedure))
                try
                {
                    return await result;
                }
                catch (Exception)
                {

                    return new SuaCTDaoTaoRes();
                }
        }

        public async Task<TaoCTDaoTaoRes> TaoCTDaoTao(TaoCTDaoTaoReq request)
        {
            
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaCT", request.MaCT);
            parameters.Add("@TenCT", request.TenCT);
            parameters.Add("@ThoiGianDaoTao",request.ThoiGianDaotao);
            parameters.Add("@HocPhi", request.HocPhi);            
            parameters.Add("@NgayBanHanh", request.NgayBanHanh);
            parameters.Add("@NoiDungCT", request.NoiDungCT);
            parameters.Add("@QDBanHanh", request.QDBanHanh);
            parameters.Add("@GhiChu", request.GhiChu);

            using (var result = SqlMapper
                                .QueryFirstOrDefaultAsync<TaoCTDaoTaoRes>(cnn: connection,
                                                                          sql: "sp_TaoCTDaoTao",
                                                                          param: parameters,
                                                                          commandType: CommandType.StoredProcedure))
                try
                {
                    return await result;
                }
                catch (Exception)
                {

                    return new TaoCTDaoTaoRes();
                }
        }

        public async Task<int> XoaCTDaoTao(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                var result = SqlMapper.ExecuteScalarAsync<int>(cnn: connection,
                                                           sql: "sp_XoaCTDaoTao",
                                                          param: parameters,
                                                          commandType: CommandType.StoredProcedure);
                 return await result;
                 
            }
            catch (Exception)
            {

                throw;
            }
          

        }

        public async Task<int> KhoiPhucCTDaoTao(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                var result = SqlMapper.ExecuteScalarAsync<int>(cnn: connection,
                                                           sql: "sp_KhoiPhucCTDaoTao",
                                                          param: parameters,
                                                          commandType: CommandType.StoredProcedure);
                return await result;

            }
            catch (Exception)
            {

                throw;
            }
        }



        public async Task<IEnumerable<CTDaoTao>> LayDanhSachCTDaoTaoVoHieuLuc()
        {
            using (var result = SqlMapper.QueryAsync<CTDaoTao>(cnn: connection,
                                                               sql: "sp_DanhSachCTDaoTaoVoHieuLuc",
                                                               commandType: CommandType.StoredProcedure))

            {
                try
                {
                    IEnumerable<CTDaoTao> list = await result;
                    return await result;
                }
                catch (Exception)
                {

                    return new List<CTDaoTao>();
                }
            }
        }

    }
}
