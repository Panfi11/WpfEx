using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtTe.Focus();
        }
        string[] array = new string[5];
        int c;

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            array[c] = TxtTe.Text;
            c++;
            TxtTe.Clear();
            TxtTe.Focus();
            if (c >= 5)
            {
                btnSt.IsEnabled = true;
                btnPu.IsEnabled = true;
                btnIn.IsEnabled = false;              
            }
        }

        private void btnSt_Click(object sender, RoutedEventArgs e)
        {
            btnSt.IsEnabled = false;
            for (c = 0; c < array.Length; c++)
            {
                lblRi.Content += $"Posizione {c} : {array[c]} \n";
            }         
        }

        private void btnPu_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("pubbica.txt", false, Encoding.UTF8);
            for (c = 0;c < array.Length; c++)
            {
                sw.WriteLine($"Posizione {c} : {array[c]} \n");
            }
            sw.Flush();
            sw.Close();
        }
    }
}
