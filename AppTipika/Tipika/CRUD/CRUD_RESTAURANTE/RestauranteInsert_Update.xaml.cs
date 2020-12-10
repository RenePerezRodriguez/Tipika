using AppTipika.Common;
using AppTipika.RestauranteBRL;
using System;
using System.Windows;

namespace AppTipika.Presentation.CRUD.CRUD_RESTAURANTE
{
    /// <summary>
    /// Interaction logic for RestauranteInsert_Update.xaml
    /// </summary>
    public partial class RestauranteInsert_Update : Window
    {
        Guid id;
        public RestauranteInsert_Update()
        {
            InitializeComponent();
        }
        public RestauranteInsert_Update(User usuarioSesion)
        {
            id = usuarioSesion.IdUser;
        }
        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            OperationsLogs.WriteLogsDebug("RestauranteInsert_Update", "BtnInsertarCliente_Click", string.Format("{0} Info: {1}",
          DateTime.Now.ToString(),
          "Empezando a ejecutar el metodo de la capa de presentacion para crear un empleado"));

            try
            {

                Restaurant restaurant = new Restaurant();
                restaurant.IdRestaurante = Guid.NewGuid();

                restaurant.IdCliente = id;
                restaurant.NombreRestaurante = txtNombreRestaurante.Text.Trim();
                restaurant.Direccion = txtDireccion.Text.Trim();

                RestauranteBrl.Insert(restaurant);

                MessageBox.Show("Restaurante Agregado Exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                OperationsLogs.WriteLogsRelease("RestauranteInsert_Update", "BtnInsertarCliente_Click", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                MessageBoxResult result = MessageBox.Show("Existe un problema, por favor contactese con su administrador",
                                          "Confirmation",
                                          MessageBoxButton.OK,
                                          MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    Application.Current.Shutdown();
                }
            }

            OperationsLogs.WriteLogsDebug("RestauranteInsert_Update", "BtnInsertarCliente_Click", string.Format("{0} Info: {1}",
           DateTime.Now.ToString(),
           "Termino a ejecutar el metodo de la capa de presentacion para crear un empleado"));
        }
    }
}
