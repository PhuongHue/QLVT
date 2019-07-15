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
            "QUA SO LUONG",
            "NULL",
            "Login failed"
        };

        private static List<string> ErrorCodeResolver = new List<string>()
        {
            "Lỗi vi phạm rằng buộc khóa chính ",
            "Lỗi vi phạm rằng buộc khóa ngoại ",
            "Lỗi vi phạm rằng buộc dữ liệu ",
            "Lỗi quá số lượng ",
            "Lỗi vi phạm rằng buộc không được rỗng ",
            "Đăng nhập thất bại"
        };
        public static string SqlMessageResolve(string Message)
        {
            string errorType = "";
            string column = "";
            foreach(string error in ErrorCodeDetecter){
                if (Message.Contains(error))
                    errorType += ErrorCodeResolver[ErrorCodeDetecter.IndexOf(error)];
            }
            if (Message.Contains("column"))
            {
                column += "tại cột ";
                int index = Message.IndexOf("column") + 8;
                if(index >=0)
                while (Message[index] !='\'' || Message[index] != ' ')
                {
                    column += Message[index];
                    index++;
                }
            }
            if (errorType == "" && column == "") return "Có lỗi xảy ra.";
            return $"{errorType}{column}.";
        }
    }
}
