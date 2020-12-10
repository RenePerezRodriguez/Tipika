using AppTipika.Common;
using AppTipika.PersonaBRL;
using System.Windows;
using System.Windows.Controls;
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
            tbkId.Text = usuarioSession.IdUser.ToString();

            if (usuarioSession.Role == "empleado")
            {
                itemHome.Visibility = Visibility.Collapsed;
            }
            else if (usuarioSession.Role == "cliente")
            {
                itemHome.Visibility = Visibility.Visible;
            }
            else if (usuarioSession.Role == "administrator")
            {
                itemHome.Visibility = Visibility.Visible;
            }
            else
            {
                itemHome.Visibility = Visibility.Collapsed;
            }
        }
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "itemHome":
                    Pruebas pruebas = new Pruebas();
                    pruebas.Show();
                    break;
                case "itemRestaurante":
                    CRUD.CRUD_RESTAURANTE.RestauranteInsert_Update restaurante = new CRUD.CRUD_RESTAURANTE.RestauranteInsert_Update();
                    restaurante.Show();
                    break;
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
    }
}