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
    /// Логика взаимодействия для look.xaml
    /// </summary>
    public partial class look : Page
    {
        public look()
        {
            InitializeComponent();
            DGauto.ItemsSource = АвтосалонEntities2.GetContext_().ТС.ToList();
        }
    }
}
