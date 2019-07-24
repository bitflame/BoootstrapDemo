using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MVCDemo.Models
{
    public static class DapperORM
    {
        //local host connection string
        //private static string connectionString = @"Server=DESKTOP-DOO10OU;Database=DapperDB;Trusted_Connection=True;";
        //Somee connection string
        private static string connectionString = @"workstation id=DapperDB.mssql.somee.com;packet size=4096;user id=samuel_SQLLogin_1;pwd=ryqk2wgkkw;data source=DapperDB.mssql.somee.com;persist security info=False;initial catalog=DapperDB";
        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
            }

        }
        //Dapper.ORM.ReturnList<EmployeeModel> <= IEnumerable<EmployeeModel> 
        public static IEnumerable<T> ReturnList<T> (string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }

        }
        //Dapper.ORM.ExecuteReturnScalar<int>(_,_);
        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar(procedureName, param, commandType: CommandType.StoredProcedure),typeof(T));
            }

        }
    }
}