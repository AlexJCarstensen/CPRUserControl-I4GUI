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

namespace CPRUserControlTest
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

        private void Show_cpr_number_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(UserControl1.CPRNumberInput1, "Cpr num");
        }

        private void ChangeCprLabel_OnClick(object sender, RoutedEventArgs e)
        {
            UserControl1.CPRNumberText = UserControl1.CPRNumberText != "CPRNumber:" ? "CPRNumber:" : "Say what=";
        }
    }
}
