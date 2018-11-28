using CyC.GestorDeContactos.AccesoDatos.DTO;
using CyC.GestorDeContactos.BLL.BFLL;
using CyC.GestorDeContactos.PL.createContacto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CyC.GestorDeContactos.PL.createDireccion
{
    public partial class CreateDireccion : Form
    {
        ControllerBFLL mainController = new ControllerBFLL();
        Direccion selectedDireccion = new Direccion();
        CreateContacto formContacto;

        public CreateDireccion()
        {
            InitializeComponent();
        }

        public void preloadForm(CreateContacto formContacto)
        {
            selectedDireccion.UIDDireccion = Guid.NewGuid();
            this.formContacto = formContacto;
            loadProvincias();
            loadPaises();
        }

        public void loadProvincias()
        {
            try
            {
                List<Provincia> listadoProvincias = mainController.getAllProvincias();
                provincia_combobox.DataSource = listadoProvincias;
                provincia_combobox.ValueMember = "UIDProvincia";
                provincia_combobox.DisplayMember = "Provincia1";
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public void loadPaises()
        {
            try
            {
                List<Pais> listadoPaises = mainController.getAllPaises();
                pais_combobox.DataSource = listadoPaises;
                pais_combobox.ValueMember = "UIDPais";
                pais_combobox.DisplayMember = "Pais1";
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void txtOnlyNumbers(object sender, KeyPressEventArgs e)   //TODO: meter en la clase de útiles
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cancelar_boton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pais_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pais selectedPais = pais_combobox.SelectedItem as Pais;
            selectedDireccion.UIDPais = (Guid)selectedPais.UIDPais;
        }

        private void provincia_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Provincia selectedProvincia = provincia_combobox.SelectedItem as Provincia;
            selectedDireccion.UIDProvincia = (Guid)selectedProvincia.UIDProvincia;
        }

        private void actualizar_boton_Click(object sender, EventArgs e)
        {
            selectedDireccion.CP = codigopostal_textbox.Text;
            selectedDireccion.Localidad = localidad_textbox.Text;
            selectedDireccion.Telefono = (String.IsNullOrEmpty(telefono_textbox.Text)) ? 0 : Int32.Parse(telefono_textbox.Text);
            if (validate())
            {
                mainController.createDireccion(selectedDireccion);
                returnToContactoForm();
            }
            else
            {
                MessageBox.Show("Por favor, rellena todos los campos");
            }

        }

        private void returnToContactoForm()
        {
            MessageBox.Show("Dirección guardada con éxito");
            this.formContacto.refreshDirecciones(selectedDireccion);
            this.Close();
        }

        private Boolean validate()
        {
            if (String.IsNullOrEmpty(selectedDireccion.CP) || String.IsNullOrEmpty(selectedDireccion.Localidad) || selectedDireccion.Telefono == 0 || String.IsNullOrEmpty(selectedDireccion.UIDPais.ToString()) || String.IsNullOrEmpty(selectedDireccion.UIDProvincia.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
