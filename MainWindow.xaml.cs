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

namespace _3layoutGrid
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            Button myButton = new Button();
            myButton.Width = 100;
            myButton.Height = 30;
            myButton.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
            myButton.Content = "Кнопка";
            layoutGrid.Children.Add(myButton);
        }
    }
}
