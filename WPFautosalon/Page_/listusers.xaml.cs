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
    /// Логика взаимодействия для listusers.xaml
    /// </summary>
    public partial class listusers : Page
    {
        public listusers()
        {
            InitializeComponent();
            //DGusers.ItemsSource = АвтосалонEntities2.GetContext_().Пользователи.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                АвтосалонEntities2.GetContext_().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGusers.ItemsSource = АвтосалонEntities2.GetContext_().Пользователи.ToList();
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainframe.Navigate(new addeditusers((sender as Button).DataContext as Пользователи));

        }

        private void remove_click(object sender, RoutedEventArgs e)
        {
            var usersforremoving = DGusers.SelectedItems.Cast<BD_.Пользователи>().ToList();
            if (MessageBox.Show($"Вы точно собираетесь удалить {usersforremoving.Count()} элементов?",
                                "Внимание",
                                MessageBoxButton.YesNo,
                                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    АвтосалонEntities2.GetContext_().Пользователи.RemoveRange(usersforremoving);
                    АвтосалонEntities2.GetContext_().SaveChanges();
                    MessageBox.Show("Данные успешно удалены.");
                    DGusers.ItemsSource = АвтосалонEntities2.GetContext_().Пользователи.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }
    }
}
