﻿using System.Windows;
using FloatingLabelComboBox;

namespace FloatingLabelComboBoxDEBUGGING
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }
    }
}