using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace calendar3
{
    public partial class KushatPage : Page
    {

        private List<FoodItem> selectedItems = new List<FoodItem>();

        public KushatPage()
        {
            InitializeComponent();
            InitializeFoodItems();
        }

        private void InitializeFoodItems()
        {
 
            List<FoodItem> foodItems = new List<FoodItem>
            {
                new FoodItem { Name = "Доширак", ImageSource = "/image/doshirak.png" },
                new FoodItem { Name = "Пиво", ImageSource = "/image/pivo (1).png" },
                new FoodItem { Name = "Семечки", ImageSource = "/image/semechkii (2).png" },
                new FoodItem { Name = "Сухарики", ImageSource = "/image/suxariki (1).png" },
                new FoodItem { Name = "Жвачка", ImageSource = "/image/zvachka (1).png" }
            };

    
            EdaList.ItemsSource = foodItems;
        }


        private void SaveAndExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Сохраняем выбранные элементы
            selectedItems.Clear();
            foreach (FoodItem item in EdaList.Items)
            {
                if (item.IsSelected)
                {
                    selectedItems.Add(item);
                }
            }

      
            NavigationService.Navigate(new Chisla());
        }
    }

    public class FoodItem
    {
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public bool IsSelected { get; set; }
    }
}
