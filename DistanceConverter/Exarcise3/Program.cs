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

            IDictionary<string, int> amounPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<string,int> obj in amounPerStore) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            } 
        }
        
    }
}
