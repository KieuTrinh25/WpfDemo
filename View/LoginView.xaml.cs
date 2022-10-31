using Project.Data.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Project.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window, INotifyPropertyChanged
    {
        private string _phone;
        private string _password;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Phone { get { return _phone; } set { 
                _phone = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Phone"));
            } 
        }
        public string Password { get { return _password; } set { _password = value; } }

        public LoginView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btnMinimize_Click(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
;       }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
