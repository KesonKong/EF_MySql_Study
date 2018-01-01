using SqlServerModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
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
