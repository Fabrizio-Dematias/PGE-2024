using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Server;

namespace FoodAppDesign
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, List<int>> productRatings = new Dictionary<string, List<int>>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //actualizar la lista de productos cuando se selecciona una categoría
        private void CategoryButton_Click(object sender, RoutedEventArgs e)
        {
            var category = (sender as Button).Content.ToString();
            ProductListBox.Items.Clear();

            switch (category)
            {
                case "Burger":
                    ProductListBox.Items.Add("Cheeseburger");
                    ProductListBox.Items.Add("Veggie Burger");
                    break;
                case "Pizza":
                    ProductListBox.Items.Add("Peperoni Pizza");
                    ProductListBox.Items.Add("Neapolitan Pizza");
                    ProductListBox.Items.Add("New York-Style Pizza");
                    break;
                case "Dessert":
                    ProductListBox.Items.Add("Chocolate Cake");
                    ProductListBox.Items.Add("Ice Cream");
                    break;
                case "French":
                    ProductListBox.Items.Add("Croissant");
                    ProductListBox.Items.Add("Baguette");
                    break;
                case "Drinks":
                    ProductListBox.Items.Add("Soda");
                    ProductListBox.Items.Add("Fernet");
                    break;
                case "Chinese":
                    ProductListBox.Items.Add("Sushi");
                    ProductListBox.Items.Add("Fried Rice");
                    break;
            }
        }

        private void ProductListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductListBox.SelectedItem == null) return;

            var selectedProduct = ProductListBox.SelectedItem.ToString();
            ProductDetails.Text = $"Selected: {selectedProduct}";

            switch (selectedProduct)
            {
                case "Cheeseburger":
                    ProductImage.Source = new BitmapImage(new Uri("Images/burger_image.png", UriKind.Relative));
                    break;
                case "Peperoni Pizza":
                case "Neapolitan Pizza":
                case "New York-Style Pizza":
                    ProductImage.Source = new BitmapImage(new Uri("Images/pizza_image.png", UriKind.Relative));
                    break;
                case "Chocolate Cake":
                case "Ice Cream":
                    ProductImage.Source = new BitmapImage(new Uri("Images/dessert_image.png", UriKind.Relative));
                    break;
                case "Croissant":
                case "Baguette":
                    ProductImage.Source = new BitmapImage(new Uri("Images/croissant_image.png", UriKind.Relative));
                    break;
                case "Soda":
                case "Fernet":
                    ProductImage.Source = new BitmapImage(new Uri("Images/drink_image.png", UriKind.Relative));
                    break;
                case "Sweet and Sour Chicken":
                case "Fried Rice":
                    ProductImage.Source = new BitmapImage(new Uri("Images/chinese_image.png", UriKind.Relative));
                    break;
            }

            MapImage.Source = new BitmapImage(new Uri("Images/map_image.png", UriKind.Relative));

            RatingPanel.Children.Clear();
            for (int i = 0; i < 5; i++)
            {
                Button star = new Button
                {
                    Content = "★",
                    FontSize = 24,
                    Width = 40,
                    Height = 40,
                    Margin = new Thickness(5)
                };
                star.Click += RateProduct_Click;
                RatingPanel.Children.Add(star);
            }

            UpdateAverageRating(selectedProduct);
        }

        private void RateProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListBox.SelectedItem == null) return;

            Button starButton = sender as Button;
            int rating = RatingPanel.Children.IndexOf(starButton) + 1;
            var selectedProduct = ProductListBox.SelectedItem.ToString();

            if (!productRatings.ContainsKey(selectedProduct))
            {
                productRatings[selectedProduct] = new List<int>();
            }

            productRatings[selectedProduct].Add(rating);
            MessageBox.Show($"You rated {selectedProduct} {rating} stars!");

            UpdateAverageRating(selectedProduct);
        }

        //actualizar el promedio de calificacion
        private void UpdateAverageRating(string product)
        {
            if (productRatings.ContainsKey(product) && productRatings[product].Count > 0)
            {
                double averageRating = (double)productRatings[product].Sum() / productRatings[product].Count;
                AverageRatingText.Text = $"Average Rating: {averageRating:F1}/5";
            }
            else
            {
                AverageRatingText.Text = "Average Rating: No ratings yet";
            }
        }
    }
}