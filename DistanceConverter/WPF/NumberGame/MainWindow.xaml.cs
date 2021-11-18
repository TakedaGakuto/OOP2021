using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        int num = 0;
        private const int Rows = 5;
        private const int Columns = 5;
        Stopwatch stopwatch = new Stopwatch();

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
                ((Button)sender).Background = Brushes.Gray;
                //((Button)sender).IsEnabled = false;
                label.Content = "もう少し高い値です。";
            }
            //同値
            if(num == int.Parse(((Button)sender).Content.ToString()))
            {
                ((Button)sender).Background = Brushes.Red;
                label.Content = "正解です。";
            }
            //値より上
            if(num < int.Parse(((Button)sender).Content.ToString()))
            {
                ((Button)sender).Background = Brushes.Gray;
                label.Content = "もう少し低い値です。";
            }
        }

        /*private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //行
            for (int i = 0; i < Rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            //列
            for (int i = 0; i < Columns; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; i++)
                {
                    var bt = new Button();
                    bt.Width = Main.Width/Columns;
                    bt.Height = Main.Height/Rows;
                    bt.Content = 1;
                    bt.FontSize = 20;
                    bt.Click += Button_Click;
                    Grid.SetRow(bt, i);
                    Grid.SetColumn(bt, j);
                }
            }
        }*/
    }
}
