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
using System.Windows.Shapes;

namespace xSumerizer_e
{
    /// <summary>
    /// Interaktionslogik für mAINWindow.xaml
    /// </summary>
    public partial class mAINWindow : Window
    { SumTab aktTab;

        public mAINWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            aktTab = new SumTab();
            lvLIste_.ItemsSource = aktTab.liste;
            txtInput.Text = "";
            txtInput.Focus();





        }//loaded

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            decimal dec = new decimal();
            try
            {
                dec = Decimal.Parse(txtInput.Text);
            }// try
            catch {
                MessageBox.Show("keine Zahl");

            }//catch

            aktTab.AddValue(dec);
            txtInput.Text = "";

            decimal sum = new decimal();
            sum = aktTab.Calc();
            lbSumme.Content = sum.ToString("c");

            }// btnAdd_Click

    }
}
