﻿using System.Windows;
using System.Windows.Controls;
using ChatClient.ViewModel;

namespace ChatClient.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(this);
        }

        public void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext != null)
            { ((dynamic)DataContext).Password = ((PasswordBox)sender).SecurePassword; }
        }

        public void PasswordWrite(string password)
        {
            PasswordBoxChat.Password = password;
        }
    }
}