using AppTipika.Common;
using AppTipika.PersonaBRL;
using AppTipika.PersonDAL;
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

namespace AppTipika.Presentation
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        /// <summary>
        /// Variable de objeto UsuarioBRL el cual es la clase logica que realiza las invocaciones a los metodos de interaccion con la base de datos para realizar el logeo
        /// </summary>
        byte cont = 0;
        public login()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreUsuario.Text != "" && txtPassword.Password != "")
            {
                try
                {

                    if (!LoginDal.ExisteUsuario(txtNombreUsuario.Text, txtPassword.Password))
                    {
                        tbkDetalle.Text = "Intente De Nuevo :)";
                        cont++;
                        txtNombreUsuario.Clear();
                        txtPassword.Clear();
                        txtNombreUsuario.Focus();
                        if (cont > 3)
                        {
                            MessageBox.Show("Demasiado intentos");
                            this.Close();
                        }
                        return;
                    }
                    else
                    {
                        User usuario = UserBrl.ObtenerIdUsuario(txtNombreUsuario.Text);
                        if (usuario.PasswordState == 1)
                        {
                            MessageBox.Show("Es necesario Cambiar password");
                        }
                        else if (usuario.PasswordState == 0)
                        {
                            User usuarioSession = UserBrl.ObtenerSession(txtNombreUsuario.Text, txtPassword.Password);

                            MenuInicio menuPrincipal = new MenuInicio(usuarioSession);
                            menuPrincipal.ShowDialog();
                            this.Close();
                        }

                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                tbkDetalle.Text = "Es necesario llenar los campos";
                cont++;
                if (cont > 3)
                {
                    MessageBox.Show("Demasiado intentos");
                    this.Close();
                }
            }
        }

        private void txtNombreUsuario_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void txtPassword_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //txtNombreUsuario.Focus();
            txtNombreUsuario.Text = "admin";
            txtPassword.Password = "admin";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MenuInicio menuPrincipal = new MenuInicio();
            menuPrincipal.ShowDialog();
            Close();
        }

        private void tbkCrearCuenta_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CRUD.ClienteInsert_Update crearCuenta = new CRUD.ClienteInsert_Update();
            crearCuenta.ShowDialog();
        }
    }
}