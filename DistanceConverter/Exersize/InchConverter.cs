using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersize {
    class InchConverter {
        private const double ratio = 0.0254;  //publicのときは、readonlyを使う
        public static double ToInch(double inch) {
            return inch * ratio;
        }
        public static double FromInch(double meter) {
            return meter * ratio;
        }
    }
}
