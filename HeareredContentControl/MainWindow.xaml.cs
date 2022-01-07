using System;
using System.Collections.Generic;
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

namespace HeareredContentControl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static double Number(string a)
        {
            double s = 0;
            try
            {
                 s= Convert.ToDouble(a);
            }
            catch (FormatException)
            {

                s=0;
            }
            return s;
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(Number(rate1.Text));
            double sumDollar = Convert.ToDouble(Number(rate2.Text));
            double resDollar = rateDollar * sumDollar;
            rate3.Text = resDollar.ToString();

        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(Number(rate4.Text));
            double sumEuro = Convert.ToDouble(Number(rate5.Text));
            double resEuro = rateEuro * sumEuro;
            rate6.Text = resEuro.ToString();
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(Number(rate7.Text));
            double sumGriv = Convert.ToDouble(Number(rate8.Text));
            double resGriv = rateGriv * sumGriv;
            rate9.Text = resGriv.ToString();
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(Number(rate10.Text));
            double sumDram = Convert.ToDouble(Number(rate11.Text));
            double resDram = rateDram * sumDram;
            rate12.Text = resDram.ToString();
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(Number(rate13.Text));
            double resInch = rateInch * 0.0254;
            rate14.Text = resInch.ToString();
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            double ratefoo = Convert.ToDouble(Number(rate15.Text));
            double resfoo = ratefoo * 0.3048;
            rate16.Text = resfoo.ToString();
        }

        private void but7_Click(object sender, RoutedEventArgs e)
        {
            double rateMile = Convert.ToDouble(Number(rate17.Text));
            double resMile = rateMile * 1609.34 ;
            rate18.Text = resMile.ToString();
        }

        private void but8_Click(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(Number(rate19.Text));
            double resVerst = rateVerst * 1066.8;
            rate20.Text = resVerst.ToString();
        }
    }
}
