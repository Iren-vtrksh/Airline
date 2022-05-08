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

namespace Airline
{
    /// <summary>
    /// Логика взаимодействия для WENTER1.xaml
    /// </summary>
    public partial class WENTER1 : Window
    {
        public WENTER1()
        {
            InitializeComponent();
        }

        private void EnterBut2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
