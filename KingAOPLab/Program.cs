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
            //BasicTest01();
            BasicTest02();
        }

        static void BasicTest02()
        {
            try
            {
                ///※ 必需回傳 dynamic 才能有效觸發KingAOP。 
                dynamic biz = new MyBusinessClass2();

                biz.QryFormData("Foo", 987, true);

                Console.WriteLine("執行成功。");
            }
            catch (Exception ex)
            {
                Console.WriteLine("執行失敗！" + ex.Message);
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }


        static void BasicTest01()
        {
            try
            {
                ///※ 必需回傳 dynamic 才能有效觸發KingAOP。 
                dynamic biz = new MyBusinessClass();

                // 測試 method aspect
                string ret = biz.HelloWorldCall();
                Console.WriteLine("Return " + ret);

                // 測試 property aspect
                biz.Foo = "我是誰";
                Console.WriteLine("foo " + biz.Foo);

                Console.WriteLine("執行成功。");
            }
            catch (Exception ex) {
                Console.WriteLine("執行失敗！" + ex.Message);
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }


    


}
