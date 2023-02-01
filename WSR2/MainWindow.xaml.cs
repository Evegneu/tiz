using System.Linq;
using System.Windows;

namespace WSR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var auth = Class1.db.User.Where(p => p.UserLogin == loginBox.Text && p.UserPassword == passwordBox.Text).FirstOrDefault();
        if (auth !=null)
            {
                Window1 Frame2 = new Window1();
                this.Hide();
                Frame2.Show();
            }
            else
            {
                MessageBox.Show("Проверьте логин или пароль");
            }
        }
    }
}
