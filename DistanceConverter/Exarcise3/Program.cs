using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exarcise3 {
    class Program {
        static void Main(string[] args) {
            //List<Sale> sales = ReadSales("Sales.csv");　//ドライバ(テスト用上位モジュール)↔スタブ

            var sales = new SalesCounter("sales.csv");//SalesCounterにReadSalesの結果を渡す
            //店舗別
            IDictionary<string, int> amounPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<string,int> obj in amounPerStore) {
                Console.WriteLine("{0} : {1:#,0}円", obj.Key, obj.Value);
            }
            Console.WriteLine("");
            //商品カテゴリ別
            IDictionary<string, int> amounPerProduct = sales.GetPerProductSales();
            foreach (KeyValuePair<string, int> obj in amounPerProduct) {
                Console.WriteLine("{0} : {1:#,0}円", obj.Key, obj.Value);
            }
        }
        
    }
}
