using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;
using System.IO;

namespace BlazorServerDemo.Data
{
    public class StaffService : IStaffService
    {
        //Database connection
        private readonly SqlConnectionConfiguration _configuration;

        public StaffService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        //add(create) Staff table row
        public async Task<string> StaffInsert(StaffInfo staffInfo)
        {
            staffInfo.UpdDtm = DateTime.Now;
            string json = string.Empty;
            using (var stream = new MemoryStream())
            {
                await JsonSerializer.SerializeAsync(stream, staffInfo, staffInfo.GetType());
                stream.Position = 0;
                using var reader = new StreamReader(stream);
                return await reader.ReadToEndAsync();
            }

            //using (var conn = new SqlConnection(_configuration.Value))
            //{
            //    var parameters = new DynamicParameters();
            //    parameters.Add("Name", staff.Name, DbType.String);
            //    parameters.Add("ExpectedSalary", staff.ExpectedSalary, DbType.Decimal);
            //    parameters.Add("UpdDtm", staff.UpdDtm, DbType.DateTime);

            //    const string query = @"INSERT INTO Staff  (Name, ExpectedSalary, UpdDtm)
            //                        VALUES (@Name, @ExpectedSalary, @UpdDtm)";

            //    await conn.ExecuteAsync(query, new { staff.Name, staff.ExpectedSalary, DateTime.Now }, commandType: CommandType.Text);

            //}
        }
    }


}
