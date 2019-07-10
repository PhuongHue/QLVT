using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.BatLoi
{
    public static class SqlMessageResolver
    {
        private static List<string> ErrorCodeDetecter = new List<string>()
        {
            "PRIMARY KEY",
            "FOREIGN KEY",
            "CHECK",
            "Login failed"
        };

        private static List<string> ErrorCodeResolver = new List<string>()
        {
            "Lỗi vi phạm rằng buộc khóa chính ",
            "Lỗi vi phạm rằng buộc khóa ngoại ",
            "Lỗi vi phạm rằng buộc dữ liệu ",
            "Đăng nhập thất bại"
        };
        public static string SqlMessageResolve(SqlException e)
        {
            string errorType = "";
            string column = "";
            foreach(string error in ErrorCodeDetecter){
                if (e.Message.Contains(error))
                    errorType += ErrorCodeResolver[ErrorCodeDetecter.IndexOf(error)];
            }
            if (e.Message.Contains("column"))
            {
                column += "tại cột ";
                int index = e.Message.IndexOf("column") + 7;
                while (e.Message[index] !='.')
                {
                    column += e.Message[index];
                    index++;
                }
            }
            if (errorType == "" && column == "") return "Có lỗi xảy ra.";
            return $"{errorType}{column}.";
        }
    }
}
