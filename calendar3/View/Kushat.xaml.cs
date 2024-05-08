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

namespace calendar3
{
    /// <summary>
    /// Логика взаимодействия для Kushat.xaml
    /// </summary>
    public partial class Kushat : UserControl
    {
        public Kushat()
        {
            InitializeComponent();
        }

        public object CheckBoxKushat { get; internal set; }
    }
}
