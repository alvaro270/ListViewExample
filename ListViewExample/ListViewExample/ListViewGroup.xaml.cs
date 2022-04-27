using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<ProductoGroup> ProductosList { get; set; } =new ObservableCollection<ProductoGroup>();
        public ListViewGroup()
        {
            InitializeComponent();

            ProductosList.Add(new ProductoGroup("Chocolate", new[]{ new Producto
                {
                    Nombre = "Vizzio",
                    Precio = 12
                },
                new Producto
                {
                    Nombre = "Mecano",
                    Precio = 9
                }}));

            ProductosList.Add(new ProductoGroup("Gaseosa", new[]{ new Producto
                {
                    Nombre = "Coca-Cola",
                    Precio = 11
                },
                new Producto
                {
                    Nombre = "Fanta",
                    Precio = 10
                }}));

            ProductosList.Add(new ProductoGroup("Snacks", new[]{ new Producto
                {
                    Nombre = "Papas Lays",
                    Precio = 6
                },
                new Producto
                {
                    Nombre = "Doritos",
                    Precio = 7
                }}));

            BindingContext = this;
        }
    }
}