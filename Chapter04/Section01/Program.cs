using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            #region "①"
            /*var person = new Person {
                Name = "新井遥菜",
                Birthday = new DateTime(1995, 11, 23),
                PhoneNumber = "123-3456-7890",
            };*/
            #endregion
            #region "②"
            /*var list = new List<int> { 10, 20, 30, 40, };
            var key = 50;
            //1or0
            var num = list.Contains(key);
            Console.WriteLine(num);*/

            //null合体演算時
            /*string code = "12345";
            var massage = GetMassage(code) ?? DefaultMassage();
            Console.WriteLine(massage);"*/
            #endregion
            #region "③"
            //var ret = GetProductA();
            #endregion
            /*
                        int count = 0;
                        //前置と後置では、加算するタイミングが違う
                        Console.WriteLine($"後置:{count++}");
                        Console.WriteLine($"前置:{++count}");*/

            /*int height;
             var str = "123";
            if (int.TryParse(str,out height)) {
                Console.WriteLine(height);
            }
            else {
                Console.WriteLine("変換できません");
            }*/
            
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if (product == null) {
                Console.WriteLine("productが取得できなかった");
            }
            else {
                Console.WriteLine("productが取得できた");
            }


        }

        private static Product GetProductA() {
            Sale sale =new Sale();
            return sale?.Product;
        }
    }
    #region "②"
    /*private static object DefaultMassage() {
        return "DefaultMassage";
    }
    private static object GetMassage(object code) {
        return code;
    }*/
    #endregion
    class Sale {
            public string ShopName { get;  set; } ="abcde";
            public int Amount { get; set; } = 12345;
            public Product Product{get; set;}
        }
}
