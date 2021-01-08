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

namespace Currencio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async void PriceReload(string pair) {
            PairPrice.Content = decimal.Round((decimal)(await Utils.GetPrices(pair)).rates.TRY, 2) + " ₺";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PairModel pm = new PairModel() { rates = new Rates() };
            foreach(var p in pm.rates.GetType().GetProperties().OrderBy(x=>x.Name)) {
                PairsCbx.Items.Add(new ComboBoxItem() { 
                    Content = p.Name,
                    VerticalAlignment = VerticalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    FontSize = 14
                });
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            DragMove();
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e) {
            CalcUC c = new CalcUC(this);
            if (CalculatorControl.Child is null) {
                CalculatorControl.Child = c;
                Height = ActualHeight + c.Height;
            } else {
                Height = ActualHeight - c.Height;
                CalculatorControl.Child = null;
            }
        }

        private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            Application.Current.Shutdown();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            ComboBox cbx = (ComboBox)sender;
            PriceReload(((ComboBoxItem)cbx.SelectedItem).Content?.ToString());
        }
    }
}
