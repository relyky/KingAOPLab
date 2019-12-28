using KingAOP;
using KingAOPLab;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KingAOPLab
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var biz = new MyBusinessClass();

                // 測試 method aspect
                string ret = biz.HelloWorldCall();
                Console.WriteLine("Return " + ret);

                // 測試 property aspect
                biz.foo = "我是誰";
                Console.WriteLine("foo " + biz.foo);
            }
            catch (Exception ex) {
                Console.WriteLine("Got Exception " + ex.Message);
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }


    


}
