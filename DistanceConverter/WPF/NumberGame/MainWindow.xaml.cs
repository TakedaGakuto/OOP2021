using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int num=0;
        string Message;
        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            num = random.Next(1, 25);
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //値より下
            
            if(num > int.Parse(((Button)sender).Content.ToString()))
            {
                label.Content = "もう少し高い値です。";
            }
            //同値
            if(num == int.Parse(((Button)sender).Content.ToString()))
            {
                label.Content = "正解です。";
            }
            //値より上
            if(num < int.Parse(((Button)sender).Content.ToString()))
            {
                label.Content = "もう少し低い値です。";
            }
            
        }
    }
}
