﻿using RównanieKwadratowe.Model;
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

namespace RównanieKwadratowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        private RównanieKwadratoweModel model;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model = new RównanieKwadratoweModel(double.Parse(a.Text),double.Parse(b.Text),double.Parse(c.Text));
            MessageBox.Show("X1= "+model.X1.ToString() +"\nX2="+ model.X2.ToString(), "Wyniki");
        }
    }
}
