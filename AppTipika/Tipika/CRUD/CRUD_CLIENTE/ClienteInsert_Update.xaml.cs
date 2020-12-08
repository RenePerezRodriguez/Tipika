using AppTipika.Common;
using AppTipika.PersonaBRL;
using System;
using System.Windows;

namespace AppTipika.Presentation.CRUD
{
    /// <summary>
    /// Interaction logic for ClienteInsert_Update.xaml
    /// </summary>
    public partial class ClienteInsert_Update : Window
    {
        public ClienteInsert_Update()
        {
            InitializeComponent();
        }

        private void BtnInsertarCliente_Click(object sender, RoutedEventArgs e)
        {
            OperationsLogs.WriteLogsDebug("ClienteInsert", "BtnInsertarCliente_Click", string.Format("{0} Info: {1}",
          DateTime.Now.ToString(),
          "Empezando a ejecutar el metodo de la capa de presentacion para crear un empleado"));

            try
            {

                Client client = new Client();
                client.IdPerson = Guid.NewGuid();

                client.IdentityCard = txtCedulaDeIdentidad.Text.Trim();
                client.Names = txtNombres.Text.Trim();
                client.FirstSurname = txtPrimerApellido.Text.Trim();
                client.SecondSurname = txtSegundoApellido.Text.Trim();
                client.Email = "email";
                client.Address = "direccion";
                client.Phone = short.Parse(txtTelefono.Text.Trim());

                client.User = new User();
                client.User.IdUser = Guid.NewGuid();
                client.User.UserName = txtNombreUsuario.Text.Trim();
                client.User.Password = txtPasswordUsuario.Text.Trim();

                ClientBrl.Insert(client);
               
                MessageBox.Show("Empleado Agregado Exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                OperationsLogs.WriteLogsRelease("InsertarEmpleado", "BtnInsertarCliente_Click", string.Format("{0} Error: {1}",
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

            OperationsLogs.WriteLogsDebug("InsertarEmpleado", "BtnInsertarCliente_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para crear un empleado"));

        }
    }
}
