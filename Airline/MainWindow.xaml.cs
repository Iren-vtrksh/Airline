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

namespace Airline
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

        private void RegistrationBut_Click(object sender, RoutedEventArgs e)
        {
            WREGISTRATION1 wREGISTRATION1 = new WREGISTRATION1();
            wREGISTRATION1.Show();
            Hide();
        }

        private void EnterBut_Click(object sender, RoutedEventArgs e)
        {
            WENTER1 wENTER1 = new WENTER1();
            wENTER1.Show();
            Hide();
        }

        private void OlderBut_Click(object sender, RoutedEventArgs e)
        {
            WDESIGN wDESIGN = new WDESIGN();
            wDESIGN.Show();
            Hide();
        }

        private void BookingBut_Click(object sender, RoutedEventArgs e)
        {
            WBOOKING1 wBOOKING1 = new WBOOKING1();
            wBOOKING1.Show();
            Hide();
        }
    }
}
