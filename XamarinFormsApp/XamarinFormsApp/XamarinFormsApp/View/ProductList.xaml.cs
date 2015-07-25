using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinFormsApp.Model;
using XamarinFormsApp.ViewModel;

namespace XamarinFormsApp.View
{
    public partial class ProductList : ContentPage
    {
        //StackLayout stackLayout = new StackLayout();
        ProductListViewModel viewModel = new ProductListViewModel();
        public ProductList()
        {
            InitializeComponent();
            itemListView.ItemsSource = Products;
            //FillProductListView();
        }

        public List<Product> Products { get { return viewModel.Products; } } 

        public void FillProductListView()
        {
            foreach (var product in viewModel.Products)
            {
                //stackLayout.Children.Add(createEntry(product));
            }
        }

        private StackLayout createEntry(Product product)
        {
            return new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                   new Label() { Text = product.Name },
                   new Label() { Text = product.Price.ToString() }
                }
            };
        }
    }
}
