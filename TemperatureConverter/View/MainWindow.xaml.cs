﻿using System;
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

namespace View
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

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            double fahrenheit = double.Parse(fahrenheitTextBox.Text);
            double celsius = (fahrenheit - 32) / 1.8;
            celsiusTextBox.Text = celsius.ToString();
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            double celsius = double.Parse(celsiusTextBox.Text);
            double fahreneit = celsius * 1.8 + 32;
            fahrenheitTextBox.Text = fahreneit.ToString();
        }
    }
}
