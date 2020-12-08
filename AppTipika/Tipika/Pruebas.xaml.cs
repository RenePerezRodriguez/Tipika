using AppTipika.Presentation.CRUD;
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

namespace Tipika
{
    /// <summary>
    /// Interaction logic for Pruebas.xaml
    /// </summary>
    public partial class Pruebas : Window
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClienteInsert_Update clienteInsert_Update = new ClienteInsert_Update();
            clienteInsert_Update.Show();
        }
    }
}
