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

namespace MyBookshelf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int userId;
        public MainWindow()
        {
            InitializeComponent();
            userId = 1;
        }

        private void Inventory_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Inventory inn = new Inventory(userId);
            inn.Show();
        }
    }
}
