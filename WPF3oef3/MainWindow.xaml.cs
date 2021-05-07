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

namespace WPF3oef3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool zichtbaar = false;
        bool kleur = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDruk_Click(object sender, RoutedEventArgs e)
        {
            if (!zichtbaar)
            {
                btnTwee.Visibility = Visibility.Visible;
                label.Visibility = Visibility.Visible;
                zichtbaar = true;
            }
            else
            {
                btnTwee.Visibility = Visibility.Hidden;
                label.Visibility = Visibility.Hidden;
                zichtbaar = false;
            }
        }

        private void btnTwee_Click(object sender, RoutedEventArgs e)
        {
           

            if (!kleur)
            {
                label.Foreground = Brushes.Blue;
                label.Content = "nu ben ik blauw";
                kleur = true;
            }
            else
            {
                label.Content = "nu ben ik zichtbaar";
                label.Foreground = Brushes.Black;
                kleur = false;
            }
        }
    }
}
