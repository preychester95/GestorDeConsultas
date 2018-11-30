using Cyc.GestorDeContactos.Comunes;
using CyC.GestorDeContactos.AccesoDatos.DTO;
using CyC.GestorDeContactos.BLL.BFLL;
using CyC.GestorDeContactos.PL.createContacto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CyC.GestorDeContactos.PL
{
    public partial class mainForm : Form
    {
        ControllerBFLL mainController = new ControllerBFLL();
        Contacto selectedContacto;
        List<Contacto> filteredContactos = new List<Contacto>();

        public mainForm()
        {
            InitializeComponent();
        }


        private string generateDireccion(Guid direccionGuid)
        {
            try
            {
                Direccion result = mainController.getDireccionByGuid(direccionGuid);
                return result.ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return "";
            }

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.contactoTableAdapter.Fill(this.cYC_PracticasDataSet1.Contacto);
            initTextBox(0);
        }

        private void borrar_boton_Click(object sender, EventArgs e)
        {
            mainController.deleteContacto(this.selectedContacto);
            refreshDataGridView(null);
            initTextBox(0);
            MessageBox.Show("Contacto borrado correctamente");
        }

        private void initTextBox(int rowIndex)
        {
            DataGridViewRow row = this.dataPanel.Rows[rowIndex];
            Guid contactoGuid = (Guid)row.Cells["Contacto"].Value;
            this.selectedContacto = mainController.getContactoByGuid(contactoGuid);
            nombre_textbox.Text = row.Cells["Nombre"].Value.ToString();
            email_textbox.Text = row.Cells["Email"].Value.ToString();
            telefono_textbox.Text = row.Cells["Telefono"].Value.ToString();
            movil_textbox.Text = row.Cells["Movil"].Value.ToString();
            try
            {
                Guid direccionGuid = (Guid)row.Cells["Direccion"].Value;
                direccion_textbox.Text = generateDireccion(direccionGuid);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void dataPanel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    initTextBox(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        //TODO: hacer focus en el pop up cuando aparezca

        private void crear_boton_Click(object sender, EventArgs e)
        {
            CreateContacto createContactoForm = new CreateContacto();
            createContactoForm.preloadForm(this);
            createContactoForm.ShowDialog();
        }

        private void actualizar_boton_Click(object sender, EventArgs e)
        {
            CreateContacto createContactoForm = new CreateContacto();
            createContactoForm.preloadForm(this, selectedContacto);
            createContactoForm.ShowDialog();
        }

        public void refreshDataGridView(List<Contacto> listadoContactos)
        {
            if (listadoContactos == null)
            {
                filteredContactos = mainController.getAllContactos();
                dataPanel.DataSource = filteredContactos;
            }
            else
            {
                dataPanel.DataSource = listadoContactos;
            }

        }

        private void limpiar_boton_Click(object sender, EventArgs e)
        {
            nombreFilter_textbox.Text = "";
            emailFilter_textbox.Text = "";
            telefonoFilter_textbox.Text = "";
            movilFilter_textbox.Text = "";
            direccionFilter_textbox.Text = "";
            filteredContactos.Clear();
        }

        private void filtar_boton_Click(object sender, EventArgs e)
        {
            if (allFieldsEmpty())
            {
                MessageBox.Show("Por favor, introduce alguno de los campos a filtrar");
            }
            else
            {
                Filter filtro = new Filter();
                filtro.nombre = nombreFilter_textbox.Text;
                filtro.email = emailFilter_textbox.Text;
                filtro.telefono = (String.IsNullOrEmpty(telefonoFilter_textbox.Text)) ? 0 : Int32.Parse(telefonoFilter_textbox.Text);
                filtro.movil = (String.IsNullOrEmpty(movilFilter_textbox.Text)) ? 0 : Int32.Parse(movilFilter_textbox.Text);
                filtro.direccion = direccionFilter_textbox.Text;
                List<Contacto> filteredContactos = mainController.applyFilter(filtro);
                refreshDataGridView(filteredContactos);
            }
        }

        private Boolean allFieldsEmpty()
        {
            if (String.IsNullOrEmpty(nombreFilter_textbox.Text) && String.IsNullOrEmpty(emailFilter_textbox.Text) && String.IsNullOrEmpty(telefonoFilter_textbox.Text) && String.IsNullOrEmpty(movilFilter_textbox.Text) && String.IsNullOrEmpty(direccionFilter_textbox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //TODO: sacar este método a un utils ya que se usa en varios sitios

        private void txtOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void todosContactos_boton_Click(object sender, EventArgs e)
        {
            refreshDataGridView(null);
        }




    }
}
