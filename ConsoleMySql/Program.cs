
using MySqlModel.Model;
using System;

namespace ConsoleMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CreateDbContent())
            {
                var u = new Dx_User { UserName = "张三", UserPassword = "123456" };
                db.dx_User.Add(u);
                db.SaveChanges();
                Console.WriteLine("执行成功");
                Console.ReadKey();

            }
        }
    }
}
