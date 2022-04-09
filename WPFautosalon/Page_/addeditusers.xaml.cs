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
using WPFautosalon.BD_;

namespace WPFautosalon.Page_
{
    /// <summary>
    /// Логика взаимодействия для addeditusers.xaml
    /// </summary>
    public partial class addeditusers : Page
    {
        public Пользователи _corentUser = new Пользователи();
        public addeditusers(Пользователи selectedUser)
        {
            InitializeComponent();
            if (selectedUser != null)
                _corentUser = selectedUser;
            DataContext = _corentUser;
            CBrole.ItemsSource = АвтосалонEntities2.GetContext_().Роли.ToList();
             
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(name.Text)) errors.AppendLine("Пустое поле имени");
            if (string.IsNullOrWhiteSpace(lastname.Text)) errors.AppendLine("Пустое поле фамилии");
            if (string.IsNullOrWhiteSpace(subname.Text)) errors.AppendLine("Пустое поле отчества");
            if (string.IsNullOrWhiteSpace(login.Text)) errors.AppendLine("нет логина");
            if (string.IsNullOrWhiteSpace(password.Text)) errors.AppendLine("Нет пароля");
            if (_corentUser.Роли.Уид_Роли == 0) { errors.AppendLine("Нет роли"); }

            if (errors.Length >0)
            {
                MessageBox.Show(errors.ToString()); return;
            }
            if (_corentUser.Уид == 0) { АвтосалонEntities2.GetContext_().Пользователи.Add(_corentUser); }
            try {
                АвтосалонEntities2.GetContext_().SaveChanges();
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

     
    }
}
