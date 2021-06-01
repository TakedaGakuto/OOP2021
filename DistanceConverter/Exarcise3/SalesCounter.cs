using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exarcise3 {
    //売り上げ集計クラス
    class SalesCounter {

        private IEnumerable<Sale> _sales; //「_」を付ける理由：インテリセンスで出しやすくするため

        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //データを読み取りリストを返す
         private static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');　//「,」で3つに区切って、それぞれ配列に
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };//オブジェクト初期化子...オブジェクト初期化子を使うことで、メンテナンス性が良
                sales.Add(sale);
            }
            return sales;
        }
        
        //店舗別売り上げ集計メソッド
        public IDictionary<string,int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach(var sale in _sales) {
                //既存の場合
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                //新規の場合
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
        //店舗別売り上げ集計メソッド
        public IDictionary<string, int> GetPerProductSales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                //既存の場合
                if (dict.ContainsKey(sale.ProductCategory))
                    dict[sale.ProductCategory] += sale.Amount;
                //新規の場合
                else
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }
    }
}
