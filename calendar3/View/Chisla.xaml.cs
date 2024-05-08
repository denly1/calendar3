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
    /// Логика взаимодействия для Chisla.xaml
    /// </summary>
    public partial class Chisla : Page
    {
        public Chisla()
        {
            InitializeComponent();
            Calendar.SelectedDate = DateTime.Now;
            Panel();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calendar.SelectedDate = ((DateTime)Calendar.SelectedDate).AddMonths(+1);
            Panel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Calendar.SelectedDate = ((DateTime)Calendar.SelectedDate).AddMonths(-1);
            Panel();
        }
        public void Panel()
        {
            Day.Children.Clear();

            for (int i = 1; i <= DateTime.DaysInMonth(((DateTime)Calendar.SelectedDate).Year, ((DateTime)Calendar.SelectedDate).Month); i++)
            {
                Dayxaml day = new Dayxaml();
                day.DataName.Content = i.ToString();
                day.DataName.Click += DayName_Click;
                Day.Children.Add(day);
            }
        }

        private void DayName_Click(object sender, RoutedEventArgs e)
        {
            FrameCheck.Content = new KushatPage();
        }

        private void FrameCheck_Navigated(object sender, NavigationEventArgs e)
        {

        }

    }
}