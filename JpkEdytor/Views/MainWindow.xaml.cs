﻿namespace JpkEdytor.Views
{
    using JpkEdytor.ViewModels;
    using System.Windows;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel();
            InitializeComponent();
        }
    }
}
