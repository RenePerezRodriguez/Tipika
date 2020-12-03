using AppTipika.Common;
using AppTipika.PersonaBRL;
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

namespace Tipika.CRUD
{
    /// <summary>
    /// Interaction logic for PersonaInsert.xaml
    /// </summary>
    public partial class PersonaInsert : Window
    {
        public PersonaInsert()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga la ventana con los datos del usuario
        /// </summary>
        /// <param name="person"></param>
        public PersonaInsert(Person person)
        {
            InitializeComponent();
            this.txtIdPersona.Text = person.IdPerson.ToString();
            this.txtCedulaDeIdentidad.Text = person.IdentityCard.ToString();
            this.txtNombres.Text = person.Names.ToString();
            this.txtPrimerApellido.Text = person.FirstSurname.ToString();
            this.txtSegundoApellido.Text = person.SecondSurname.ToString();
            this.txtCorreoElectronico.Text = person.Email.ToString();
            this.txtTelefono.Text = person.Phone.ToString();
            this.txtDireccion.Text = person.Address.ToString();
        }
        /// <summary>
        /// Metodo para insertar una persona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person()
            {
                IdPerson = Guid.NewGuid(),
                IdentityCard = txtCedulaDeIdentidad.Text.Trim(),
                Names = txtNombres.Text.Trim(),
                FirstSurname = txtPrimerApellido.Text.Trim(),
                SecondSurname = txtSegundoApellido.Text.Trim(),
                Email = txtCorreoElectronico.Text.Trim(),
                Address = txtDireccion.Text.Trim(),
                Phone = byte.Parse(txtTelefono.Text.Trim())
            };
            try
            {
                PersonBrl.Insert(person);
                MessageBox.Show("Person inserted correctly");
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error inserting person" + error);
                throw;
            }
        }
    }
}
