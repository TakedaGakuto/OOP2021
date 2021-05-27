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
    }
}
