using CyC.GestorDeContactos.AccesoDatos.DTO;
using CyC.GestorDeContactos.BLL.BFLL;
using CyC.GestorDeContactos.PL.createDireccion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CyC.GestorDeContactos.PL.createContacto
{
    public partial class CreateContacto : Form
    {

        ControllerBFLL mainController = new ControllerBFLL();
        Contacto selectedContacto;
        mainForm formPrincipal;
        Boolean edit = false;

        public CreateContacto()
        {
            InitializeComponent();
        }

        public void preloadForm(mainForm formPrincipal, Contacto contacto) //EDICIÓN
        {
            edit = true;
            selectedContacto = contacto;
            fillTextBoxes();
            this.formPrincipal = formPrincipal;
            loadDirecciones(selectedContacto.Direccion.ToString());
        }

        public void preloadForm(mainForm formPrincipal) //CREACIÓN
        {
            selectedContacto = new Contacto();
            selectedContacto.UIDContacto = Guid.NewGuid();
            this.formPrincipal = formPrincipal;
            loadDirecciones(null);
        }

        private void loadDirecciones(string value)
        {
            try
            {
                List<Direccion> listadoDirecciones = mainController.getAllDirecciones();
                direccion_combobox.DataSource = listadoDirecciones;
                direccion_combobox.ValueMember = "UIDDireccion";
                direccion_combobox.DisplayMember = "FullName";
                if (value != null)
                {
                    direccion_combobox.SelectedIndex = direccion_combobox.FindStringExact(value);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void direccion_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Direccion selectedDireccion = direccion_combobox.SelectedItem as Direccion;
            selectedContacto.UIDDireccion = (Guid)selectedDireccion.UIDDireccion;
        }

        private void cancelar_boton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createContacto(object sender, EventArgs e)
        {
            this.selectedContacto.Nombre = nombre_textbox.Text;
            this.selectedContacto.Email = email_textbox.Text;
            this.selectedContacto.Telefono = (String.IsNullOrEmpty(telefono_textbox.Text)) ? 0 : long.Parse(telefono_textbox.Text);
            this.selectedContacto.Movil = (String.IsNullOrEmpty(movil_textbox.Text)) ? 0 : long.Parse(movil_textbox.Text);
            if (validate())
            {
                if (IsValidEmail(this.selectedContacto.Email))
                {
                    try
                    {
                        if (edit)
                        {
                            mainController.updateContacto(this.selectedContacto);
                        }
                        else
                        {
                            mainController.createContacto(this.selectedContacto);
                        }
                        returnToMainForm();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, introduce un email válido");
                }

            }
            else
            {
                MessageBox.Show("Por favor, rellena todos los campos");
            }
        }

        public void refreshDirecciones(Direccion direccion)
        {
            direccion = mainController.getDireccionByGuid(direccion.UIDDireccion);
            loadDirecciones(direccion.ToString());
        }

        private void returnToMainForm()
        {
            MessageBox.Show("Contacto guardado con éxito");
            this.formPrincipal.refreshDataGridView(null);
            this.Close();
        }

        private void fillTextBoxes()
        {
            nombre_textbox.Text = selectedContacto.Nombre;
            email_textbox.Text = selectedContacto.Email;
            telefono_textbox.Text = selectedContacto.Telefono.ToString();
            movil_textbox.Text = selectedContacto.Movil.ToString();
        }

        private Boolean validate()
        {
            if (String.IsNullOrEmpty(selectedContacto.UIDDireccion.ToString()) || String.IsNullOrEmpty(selectedContacto.Nombre) || String.IsNullOrEmpty(selectedContacto.Email) || selectedContacto.Telefono == 0 || selectedContacto.Movil == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuevaDireccion_boton_Click(object sender, EventArgs e)
        {
            CreateDireccion createDireccionForm = new CreateDireccion();
            createDireccionForm.preloadForm(this);
            createDireccionForm.ShowDialog();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
