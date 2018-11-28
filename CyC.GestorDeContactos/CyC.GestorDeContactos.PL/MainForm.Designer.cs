namespace CyC.GestorDeContactos.PL
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataPanel = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cYC_PracticasDataSet1 = new CyC.GestorDeContactos.PL.CYC_PracticasDataSet1();
            this.contactoTableAdapter = new CyC.GestorDeContactos.PL.CYC_PracticasDataSet1TableAdapters.ContactoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crear_boton = new System.Windows.Forms.Button();
            this.borrar_boton = new System.Windows.Forms.Button();
            this.actualizar_boton = new System.Windows.Forms.Button();
            this.direccion_textbox = new System.Windows.Forms.TextBox();
            this.direccion_label = new System.Windows.Forms.Label();
            this.movil_textbox = new System.Windows.Forms.TextBox();
            this.movil_label = new System.Windows.Forms.Label();
            this.telefono_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.nombre_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.direccionFilter_textbox = new System.Windows.Forms.TextBox();
            this.movilFilter_textbox = new System.Windows.Forms.TextBox();
            this.telefonoFilter_textbox = new System.Windows.Forms.TextBox();
            this.emailFilter_textbox = new System.Windows.Forms.TextBox();
            this.nombreFilter_textbox = new System.Windows.Forms.TextBox();
            this.limpiar_boton = new System.Windows.Forms.Button();
            this.filtar_boton = new System.Windows.Forms.Button();
            this.todosContactos_boton = new System.Windows.Forms.Button();
            this.introducetxt_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cYC_PracticasDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPanel
            // 
            this.dataPanel.AllowUserToAddRows = false;
            this.dataPanel.AllowUserToDeleteRows = false;
            this.dataPanel.AutoGenerateColumns = false;
            this.dataPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Contacto,
            this.Direccion,
            this.Email,
            this.Telefono,
            this.Movil});
            this.dataPanel.DataSource = this.contactoBindingSource;
            this.dataPanel.Location = new System.Drawing.Point(422, 210);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(443, 197);
            this.dataPanel.TabIndex = 0;
            this.dataPanel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPanel_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Contacto
            // 
            this.Contacto.DataPropertyName = "UIDContacto";
            this.Contacto.Frozen = true;
            this.Contacto.HeaderText = "UIDContacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "UIDDireccion";
            this.Direccion.Frozen = true;
            this.Direccion.HeaderText = "UIDDireccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.Frozen = true;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.Frozen = true;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Movil
            // 
            this.Movil.DataPropertyName = "Movil";
            this.Movil.Frozen = true;
            this.Movil.HeaderText = "Movil";
            this.Movil.Name = "Movil";
            // 
            // contactoBindingSource
            // 
            this.contactoBindingSource.DataMember = "Contacto";
            this.contactoBindingSource.DataSource = this.cYC_PracticasDataSet1;
            // 
            // cYC_PracticasDataSet1
            // 
            this.cYC_PracticasDataSet1.DataSetName = "CYC_PracticasDataSet1";
            this.cYC_PracticasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactoTableAdapter
            // 
            this.contactoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.crear_boton);
            this.panel1.Controls.Add(this.borrar_boton);
            this.panel1.Controls.Add(this.actualizar_boton);
            this.panel1.Controls.Add(this.direccion_textbox);
            this.panel1.Controls.Add(this.direccion_label);
            this.panel1.Controls.Add(this.movil_textbox);
            this.panel1.Controls.Add(this.movil_label);
            this.panel1.Controls.Add(this.telefono_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.email_textbox);
            this.panel1.Controls.Add(this.email_label);
            this.panel1.Controls.Add(this.nombre_textbox);
            this.panel1.Controls.Add(this.nombre_label);
            this.panel1.Location = new System.Drawing.Point(24, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 197);
            this.panel1.TabIndex = 1;
            // 
            // crear_boton
            // 
            this.crear_boton.Location = new System.Drawing.Point(17, 158);
            this.crear_boton.Name = "crear_boton";
            this.crear_boton.Size = new System.Drawing.Size(112, 23);
            this.crear_boton.TabIndex = 2;
            this.crear_boton.Text = "Nuevo contacto";
            this.crear_boton.UseVisualStyleBackColor = true;
            this.crear_boton.Click += new System.EventHandler(this.crear_boton_Click);
            // 
            // borrar_boton
            // 
            this.borrar_boton.Location = new System.Drawing.Point(135, 158);
            this.borrar_boton.Name = "borrar_boton";
            this.borrar_boton.Size = new System.Drawing.Size(112, 23);
            this.borrar_boton.TabIndex = 3;
            this.borrar_boton.Text = "Borrar";
            this.borrar_boton.UseVisualStyleBackColor = true;
            this.borrar_boton.Click += new System.EventHandler(this.borrar_boton_Click);
            // 
            // actualizar_boton
            // 
            this.actualizar_boton.Location = new System.Drawing.Point(253, 158);
            this.actualizar_boton.Name = "actualizar_boton";
            this.actualizar_boton.Size = new System.Drawing.Size(112, 23);
            this.actualizar_boton.TabIndex = 4;
            this.actualizar_boton.Text = "Actualizar";
            this.actualizar_boton.UseVisualStyleBackColor = true;
            this.actualizar_boton.Click += new System.EventHandler(this.actualizar_boton_Click);
            // 
            // direccion_textbox
            // 
            this.direccion_textbox.Location = new System.Drawing.Point(85, 120);
            this.direccion_textbox.Name = "direccion_textbox";
            this.direccion_textbox.ReadOnly = true;
            this.direccion_textbox.Size = new System.Drawing.Size(280, 20);
            this.direccion_textbox.TabIndex = 9;
            // 
            // direccion_label
            // 
            this.direccion_label.AutoSize = true;
            this.direccion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_label.Location = new System.Drawing.Point(4, 121);
            this.direccion_label.Name = "direccion_label";
            this.direccion_label.Size = new System.Drawing.Size(74, 16);
            this.direccion_label.TabIndex = 8;
            this.direccion_label.Text = "Dirección";
            // 
            // movil_textbox
            // 
            this.movil_textbox.Location = new System.Drawing.Point(85, 94);
            this.movil_textbox.Name = "movil_textbox";
            this.movil_textbox.ReadOnly = true;
            this.movil_textbox.Size = new System.Drawing.Size(280, 20);
            this.movil_textbox.TabIndex = 7;
            // 
            // movil_label
            // 
            this.movil_label.AutoSize = true;
            this.movil_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movil_label.Location = new System.Drawing.Point(4, 94);
            this.movil_label.Name = "movil_label";
            this.movil_label.Size = new System.Drawing.Size(45, 16);
            this.movil_label.TabIndex = 6;
            this.movil_label.Text = "Móvil";
            // 
            // telefono_textbox
            // 
            this.telefono_textbox.Location = new System.Drawing.Point(85, 68);
            this.telefono_textbox.Name = "telefono_textbox";
            this.telefono_textbox.ReadOnly = true;
            this.telefono_textbox.Size = new System.Drawing.Size(280, 20);
            this.telefono_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teléfono";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(85, 42);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.ReadOnly = true;
            this.email_textbox.Size = new System.Drawing.Size(280, 20);
            this.email_textbox.TabIndex = 3;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(4, 42);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(47, 16);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "Email";
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Location = new System.Drawing.Point(85, 16);
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.ReadOnly = true;
            this.nombre_textbox.Size = new System.Drawing.Size(280, 20);
            this.nombre_textbox.TabIndex = 1;
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_label.Location = new System.Drawing.Point(4, 16);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(63, 16);
            this.nombre_label.TabIndex = 0;
            this.nombre_label.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.direccionFilter_textbox);
            this.panel2.Controls.Add(this.movilFilter_textbox);
            this.panel2.Controls.Add(this.telefonoFilter_textbox);
            this.panel2.Controls.Add(this.emailFilter_textbox);
            this.panel2.Controls.Add(this.nombreFilter_textbox);
            this.panel2.Controls.Add(this.limpiar_boton);
            this.panel2.Controls.Add(this.filtar_boton);
            this.panel2.Location = new System.Drawing.Point(109, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 125);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Móvil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // direccionFilter_textbox
            // 
            this.direccionFilter_textbox.Location = new System.Drawing.Point(567, 43);
            this.direccionFilter_textbox.Name = "direccionFilter_textbox";
            this.direccionFilter_textbox.Size = new System.Drawing.Size(103, 20);
            this.direccionFilter_textbox.TabIndex = 6;
            // 
            // movilFilter_textbox
            // 
            this.movilFilter_textbox.Location = new System.Drawing.Point(430, 43);
            this.movilFilter_textbox.Name = "movilFilter_textbox";
            this.movilFilter_textbox.Size = new System.Drawing.Size(103, 20);
            this.movilFilter_textbox.TabIndex = 5;
            this.movilFilter_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // telefonoFilter_textbox
            // 
            this.telefonoFilter_textbox.Location = new System.Drawing.Point(293, 43);
            this.telefonoFilter_textbox.Name = "telefonoFilter_textbox";
            this.telefonoFilter_textbox.Size = new System.Drawing.Size(103, 20);
            this.telefonoFilter_textbox.TabIndex = 4;
            this.telefonoFilter_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // emailFilter_textbox
            // 
            this.emailFilter_textbox.Location = new System.Drawing.Point(156, 43);
            this.emailFilter_textbox.Name = "emailFilter_textbox";
            this.emailFilter_textbox.Size = new System.Drawing.Size(103, 20);
            this.emailFilter_textbox.TabIndex = 3;
            // 
            // nombreFilter_textbox
            // 
            this.nombreFilter_textbox.Location = new System.Drawing.Point(19, 43);
            this.nombreFilter_textbox.Name = "nombreFilter_textbox";
            this.nombreFilter_textbox.Size = new System.Drawing.Size(103, 20);
            this.nombreFilter_textbox.TabIndex = 2;
            // 
            // limpiar_boton
            // 
            this.limpiar_boton.Location = new System.Drawing.Point(505, 88);
            this.limpiar_boton.Name = "limpiar_boton";
            this.limpiar_boton.Size = new System.Drawing.Size(75, 23);
            this.limpiar_boton.TabIndex = 1;
            this.limpiar_boton.Text = "Limpiar";
            this.limpiar_boton.UseVisualStyleBackColor = true;
            this.limpiar_boton.Click += new System.EventHandler(this.limpiar_boton_Click);
            // 
            // filtar_boton
            // 
            this.filtar_boton.Location = new System.Drawing.Point(595, 88);
            this.filtar_boton.Name = "filtar_boton";
            this.filtar_boton.Size = new System.Drawing.Size(75, 23);
            this.filtar_boton.TabIndex = 0;
            this.filtar_boton.Text = "Filtrar";
            this.filtar_boton.UseVisualStyleBackColor = true;
            this.filtar_boton.Click += new System.EventHandler(this.filtar_boton_Click);
            // 
            // todosContactos_boton
            // 
            this.todosContactos_boton.Location = new System.Drawing.Point(705, 181);
            this.todosContactos_boton.Name = "todosContactos_boton";
            this.todosContactos_boton.Size = new System.Drawing.Size(160, 23);
            this.todosContactos_boton.TabIndex = 0;
            this.todosContactos_boton.Text = "Mostrar todos los contactos";
            this.todosContactos_boton.Click += new System.EventHandler(this.todosContactos_boton_Click);
            // 
            // introducetxt_label
            // 
            this.introducetxt_label.AutoSize = true;
            this.introducetxt_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introducetxt_label.Location = new System.Drawing.Point(109, 13);
            this.introducetxt_label.Name = "introducetxt_label";
            this.introducetxt_label.Size = new System.Drawing.Size(306, 20);
            this.introducetxt_label.TabIndex = 3;
            this.introducetxt_label.Text = "Introduce los campos por los que quieras filtrar";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 520);
            this.Controls.Add(this.introducetxt_label);
            this.Controls.Add(this.todosContactos_boton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataPanel);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de contactos";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cYC_PracticasDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPanel;
        private CYC_PracticasDataSet1 cYC_PracticasDataSet1;
        private System.Windows.Forms.BindingSource contactoBindingSource;
        private CYC_PracticasDataSet1TableAdapters.ContactoTableAdapter contactoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox direccion_textbox;
        private System.Windows.Forms.Label direccion_label;
        private System.Windows.Forms.TextBox movil_textbox;
        private System.Windows.Forms.Label movil_label;
        private System.Windows.Forms.TextBox telefono_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.Button crear_boton;
        private System.Windows.Forms.Button borrar_boton;
        private System.Windows.Forms.Button actualizar_boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button limpiar_boton;
        private System.Windows.Forms.Button filtar_boton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox direccionFilter_textbox;
        private System.Windows.Forms.TextBox movilFilter_textbox;
        private System.Windows.Forms.TextBox telefonoFilter_textbox;
        private System.Windows.Forms.TextBox emailFilter_textbox;
        private System.Windows.Forms.TextBox nombreFilter_textbox;
        private System.Windows.Forms.Button todosContactos_boton;
        private System.Windows.Forms.Label introducetxt_label;
    }
}

