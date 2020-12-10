using AppTipika.Common;
using AppTipika.ProductBRL;
using System;
using System.Data.SqlTypes;
using System.Windows;

namespace AppTipika.Presentation.CRUD.CRUD_PRODUCTO
{
    /// <summary>
    /// Interaction logic for ProductoInsert_Update.xaml
    /// </summary>
    public partial class ProductoInsert_Update : Window
    {
        public ProductoInsert_Update()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {   
            try
            {
                Product producto = new Product
                {
                    IdProduct = Guid.NewGuid(),
                    Image = "ruta/de/imagen",
                    Name = txtNombreProducto.Text.Trim(),
                    Ingredients = txtInredientes.Text.Trim(),
                    Description = txtDescripcion.Text.Trim(),
                    Offer = 0,
                    Price = SqlMoney.Parse(txtPrecio.Text.Trim())
                };

                ProductBrl.Insert(producto);
                MessageBox.Show("Producto Insertado Correctamente");
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al insertar el Producto" + err);
                throw err;
            }
        }
    }
}
