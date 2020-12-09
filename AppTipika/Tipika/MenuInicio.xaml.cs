using AppTipika.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tipika;

namespace AppTipika.Presentation
{
    /// <summary>
    /// Interaction logic for MenuInicio.xaml
    /// </summary>
    public partial class MenuInicio : Window
    {
        public MenuInicio()
        {
            InitializeComponent();
        }
        public MenuInicio(User usuarioSession)
        {
            InitializeComponent();

            tbkUsuario.Text = usuarioSession.UserName;
            tbkRol.Text = usuarioSession.Role;



            if (usuarioSession.Role == "employee")
            {
                itemHome.Visibility = Visibility.Collapsed;
                itemEmpleado.Visibility = Visibility.Collapsed;
            }
            else if (usuarioSession.Role == "client")
            {
                itemHome.Visibility = Visibility.Visible;
                itemCompra.Visibility = Visibility.Visible;
                itemVenta.Visibility = Visibility.Visible;
                itemEmpleado.Visibility = Visibility.Visible;
            }
            else if (usuarioSession.Role == "administrator")
            {
                itemHome.Visibility = Visibility.Visible;
                itemCompra.Visibility = Visibility.Visible;
                itemVenta.Visibility = Visibility.Visible;
                itemEmpleado.Visibility = Visibility.Visible;
            }
            else
            {
                itemHome.Visibility = Visibility.Collapsed;
                itemCompra.Visibility = Visibility.Collapsed;
                itemVenta.Visibility = Visibility.Collapsed;
                itemEmpleado.Visibility = Visibility.Collapsed;
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnCollapseMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCollapseMenu.Visibility = Visibility.Collapsed;
            btnOpenMenu.Visibility = Visibility.Visible;
            imgLogo.Visibility = Visibility.Collapsed;
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCollapseMenu.Visibility = Visibility.Visible;
            btnOpenMenu.Visibility = Visibility.Collapsed;
            imgLogo.Visibility = Visibility.Visible;
        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "itemHome":
                    Pruebas pruebas = new Pruebas();
                    pruebas.Show();
                    break;

                    /* case "itemCompra":
                         CRUD.COMPRA_PRODUCTO.ProductoCompra productoCompra = new CRUD.COMPRA_PRODUCTO.ProductoCompra();
                         productoCompra.Owner = this;
                         productoCompra.Show();
                         break;
                     case "itemVenta":
                         CRUD.CRUD_VENTA.VentaInsert ventaInsert = new CRUD.CRUD_VENTA.VentaInsert();
                         ventaInsert.Owner = this;
                         ventaInsert.Show();
                         break;
                     case "itemEmpleado":
                         CRUD.CRUD_EMPLEADO.EmpleadoCrud empleadoCrud = new CRUD.CRUD_EMPLEADO.EmpleadoCrud();
                         empleadoCrud.Owner = this;
                         empleadoCrud.Show();
                         break;
                     case "itemProveedor":
                         CRUD.CRUD_PROVEEDOR.ProveedorCrud proveedorCrud = new CRUD.CRUD_PROVEEDOR.ProveedorCrud();
                         proveedorCrud.Owner = this;
                         proveedorCrud.Show();
                         break;
                     case "itemProducto":
                         CRUD.CRUD_PRODUCTO.ProductoCrud productoCrud = new CRUD.CRUD_PRODUCTO.ProductoCrud();
                         productoCrud.Owner = this;
                         productoCrud.Show();
                         break;*/
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, RoutedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Sesion.idSesion + "");
        }

    }
}