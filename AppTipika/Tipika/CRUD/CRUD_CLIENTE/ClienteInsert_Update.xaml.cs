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
                client.Email = txtCorreoElectronico.Text.Trim();
                client.Address = txtdireccion.Text.Trim();
                client.Phone = int.Parse(txtTelefono.Text.Trim());

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

        private void btnActualizar_Click_1(object sender, RoutedEventArgs e)
        {
            Client cliente = new Client()
            {
                IdPerson = Guid.Parse(txtId.Text.Trim()),
                IdentityCard = txtCedulaDeIdentidad.Text.Trim(),
                Names = txtNombres.Text.Trim(),
                FirstSurname = txtPrimerApellido.Text.Trim(),
                SecondSurname = txtSegundoApellido.Text.Trim(),
                Email = txtCorreoElectronico.Text.Trim(),
                Address = txtdireccion.Text.Trim(),
                Phone = int.Parse(txtTelefono.Text.Trim()),
            };
            try
            {
                ClientBrl.Update(cliente);
                MessageBox.Show("Cliente Actualizado Correctamente");
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al actualizar la persona" + err);
                throw err;
            }
        }
    }
}
