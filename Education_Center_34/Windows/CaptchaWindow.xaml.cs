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
using System.Windows.Shapes;

namespace Education_Center_34.Windows
{
    /// <summary>
    /// Логика взаимодействия для CaptchaWindow.xaml
    /// </summary>
    public partial class CaptchaWindow : Window
    {
        Image? selectedFragment;
        public CaptchaWindow()
        {
            InitializeComponent();
        }

        private void CaptchaLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CaptchaFragmentsLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
