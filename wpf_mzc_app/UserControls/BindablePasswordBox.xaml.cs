using System;
using System.Windows;
using System.Windows.Controls;

namespace wpf_mzc_app.UserControls
{
    public partial class BindablePasswordBox : UserControl
    {
        private bool _isPasswordChanging;
        
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(BindablePasswordBox), 
                new PropertyMetadata(string.Empty, PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is BindablePasswordBox passwordBox)
                passwordBox.UpdatePassword();
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public BindablePasswordBox()
        {
            InitializeComponent();
        }
        
        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = PasswordBox.Password;
            _isPasswordChanging = false;
        }
        
        private void UpdatePassword()
        {
            if (!_isPasswordChanging)
                PasswordBox.Password = Password;
        }
    }
}