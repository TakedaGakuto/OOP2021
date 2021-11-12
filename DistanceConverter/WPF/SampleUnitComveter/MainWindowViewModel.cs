using SampleUnitConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitComveter
{
    public class MainWindowViewModel : ViewModel
    {
        private double metricValue;
        private double imperialValue;

        //▲コマンド(ヤード→メートル)
        public ICommand ImperialUnitToMetric { get; private set; }
        //▼コマンド(メートル→ヤード)
        public ICommand MetricToImperialUnit { get; private set; }

        //ComboBox(上)の値
        public MetricUnit CurrentMetricUnit { get; set; }

        //ComboBox(下)の値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue
        {
            get { return this.metricValue; }
            set
            {
                this.metricValue = value;
                this.OnPropertyChanged();   //Viewへ通知
            }
        }

        public double ImperialValue
        {
            get { return this.imperialValue; }
            set
            {
                this.imperialValue = value;
                this.OnPropertyChanged();   //Viewへ通知
            }
        }

        //コンストラクタ
        public MainWindowViewModel()
        {
            //初期値セット
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperialUnit = ImperialUnit.Units.First();
            
            this.MetricToImperialUnit = new DelegateCommand(
                () => this.ImperialValue = 
                      this.CurrentImperialUnit.FromMetricUnit(this.CurrentMetricUnit,this.metricValue));
            this.ImperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue =
                      this.CurrentMetricUnit.FromImperialUnit(this.CurrentImperialUnit, this.imperialValue));
        }
    }
}