﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Threading
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "DoTimeConsumingWork_Button")
            {
                DoTimeConsumingWork_Button.IsEnabled = false;
                Task.Factory.StartNew(
                    () =>
                    {
                        Thread.Sleep(5000);
                    }
                    );
                DoTimeConsumingWork_Button.IsEnabled = true;
            }

            if (button.Name == "PrintNumbersButton")
            {
                for (int i = 1; i <= 10; i++)
                {
                    ListBoxOfNumbers.Items.Add(i);
                }
            }
        }
    }
}
