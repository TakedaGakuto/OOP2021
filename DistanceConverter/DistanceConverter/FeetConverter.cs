﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public static class FeetConverter {  //静的クラスにすることで、インスタンス化(new)したときにエラーが出るように
        public static double ToMeter(double feet) {
            return feet * 0.3048;
        }
        public static double FromMeter(double meter) {
            return meter / 0.3048;
        }
    }
}
