using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
            //List<Sale> sales = ReadSales("Sales.csv");　//ドライバ(テスト用上位モジュール)↔スタブ

            
        }
        //データを読み取りリストを返す
        static List<Sale> ReadSales(string filePath) {
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
    }
}
