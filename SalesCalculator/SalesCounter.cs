using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売り上げ集計クラス
    class SalesCounter {

        private List<Sale> _sales; //「_」を付ける理由：インテリセンスで出しやすくするため

        public SalesCounter(List<Sale> sales) {
            _sales = sales;
        }

        //店舗別売り上げ集計メソッド
        public Dictionary<string,int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales) {
                //既存の場合
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                //新規の場合
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}
