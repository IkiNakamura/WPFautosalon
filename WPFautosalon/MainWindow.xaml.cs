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

namespace WPFautosalon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainframe.Navigate(new Page_.listusers());
            Manager.mainframe = mainframe;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt_ = (Button)sender;
            int id = Int32.Parse(bt_.Uid);

            switch (id)
            {
                case 1:
                    mainframe.Navigate(new Page_.listusers());
                    break;
                case 2:
                    mainframe.Navigate(new Page_.addeditusers(null));
                    break;
                case 3:
                    mainframe.Navigate(new Page_.remove());
                    break;
                case 4:
                    mainframe.Navigate(new Page_.edit());
                    break;

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.mainframe.GoBack();
        }

        private void mainframe_ContentRendered(object sender, EventArgs e)
        {
            if (mainframe.CanGoBack)
            {
                goback.Visibility = Visibility.Visible;
            }
            else
            {
                goback.Visibility = Visibility.Hidden;
            }
        }
    }
}
