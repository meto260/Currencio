using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Currencio {
    /// <summary>
    /// Interaction logic for CalcUC.xaml
    /// </summary>
    public partial class CalcUC : UserControl {
        MainWindow thiswin;
        public CalcUC(MainWindow mw) {
            thiswin = mw;
            InitializeComponent();
        }

        private void input1_GotFocus(object sender, RoutedEventArgs e) {
            TextBox t = (TextBox)sender;
            t.Text = "";
        }

        private async void input1_KeyUp(object sender, KeyEventArgs e) {
            if(e.Key==Key.Enter) {
                decimal inputval = Convert.ToDecimal(input1.Text.Replace(',', '.'));
                string pair = ((ComboBoxItem)thiswin.PairsCbx.SelectedItem).Content?.ToString();
                decimal dovizprice = (await Utils.GetPrices(pair)).rates.TRY;
                thiswin.PairPrice.Content = (decimal.Round(dovizprice, 2)).ToString() + " ₺";
                decimal calculated = inputval / dovizprice;
                input2.Text = decimal.Round(calculated,2).ToString();
            }
        }

        private async void input2_KeyUp(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                decimal inputval = Convert.ToDecimal(input2.Text.Replace(',', '.'));
                string pair = ((ComboBoxItem)thiswin.PairsCbx.SelectedItem).Content?.ToString();
                decimal dovizprice = (await Utils.GetPrices(pair)).rates.TRY;
                thiswin.PairPrice.Content = (decimal.Round(dovizprice, 2)).ToString() + " ₺";
                decimal calculated = dovizprice * inputval;
                input1.Text = decimal.Round(calculated, 2).ToString();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
            string pair = ((ComboBoxItem)thiswin.PairsCbx.SelectedItem).Content?.ToString();
            pairLBL.Content = pair;
        }
    }
}
