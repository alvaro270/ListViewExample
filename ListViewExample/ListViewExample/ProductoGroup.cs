using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public class ProductoGroup : ObservableCollection<Producto>
    {
        public string Marca { get; private set; }
        public ProductoGroup(string marca)
            : base()
        {
            Marca = marca;
        }
        public ProductoGroup(string marca, IEnumerable<Producto> source)
            : base(source)
        {
            Marca = marca;
        }
    }
}
