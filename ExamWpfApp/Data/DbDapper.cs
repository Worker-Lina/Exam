using Dapper;
using ExamWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWpfApp.Data
{
    public class DbDapper : GetConnection
    {
        public IEnumerable<Question> SelectQuestions()
        {
            using (var con = Connection)
            {
                return con.Query<Question>("select * from Dannue");
            }
        }

        public int CreateUser(User user)
        {
            using (var con = Connection)
            {
                string sql = "insert into [User] (Surname, Name, Age) values (@Surname, @Name, @Age)";
                return con.Execute(sql, new DynamicParameters(user));
            }
        }

        public int CreateResult(Result result)
        {
            using (var con = Connection)
            {
                string sql = "insert into Results (FIO, Procent, [Date], [Time]) values (@FIO, @Procent, @Date, @Time)";
                return con.Execute(sql, new DynamicParameters(result));
            }
        }

        public IEnumerable<Result> SelectResult(DateTime startDate, DateTime endDate)
        {
            using (var con = Connection)
            {
                return con.Query<Result>($"select * from Results where [Date] between '{startDate}' and '{endDate}'");
            }
        }
    }
}
