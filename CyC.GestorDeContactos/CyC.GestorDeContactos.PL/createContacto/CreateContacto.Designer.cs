namespace CyC.GestorDeContactos.PL.createContacto
{
    partial class CreateContacto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nuevaDireccion_boton = new System.Windows.Forms.Button();
            this.direccion_combobox = new System.Windows.Forms.ComboBox();
            this.cancelar_boton = new System.Windows.Forms.Button();
            this.actualizar_boton = new System.Windows.Forms.Button();
            this.direccion_label = new System.Windows.Forms.Label();
            this.movil_textbox = new System.Windows.Forms.TextBox();
            this.movil_label = new System.Windows.Forms.Label();
            this.telefono_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.nombre_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nuevaDireccion_boton);
            this.panel1.Controls.Add(this.direccion_combobox);
            this.panel1.Controls.Add(this.cancelar_boton);
            this.panel1.Controls.Add(this.actualizar_boton);
            this.panel1.Controls.Add(this.direccion_label);
            this.panel1.Controls.Add(this.movil_textbox);
            this.panel1.Controls.Add(this.movil_label);
            this.panel1.Controls.Add(this.telefono_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.email_textbox);
            this.panel1.Controls.Add(this.email_label);
            this.panel1.Controls.Add(this.nombre_textbox);
            this.panel1.Controls.Add(this.nombre_label);
            this.panel1.Location = new System.Drawing.Point(68, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 238);
            this.panel1.TabIndex = 2;
            // 
            // nuevaDireccion_boton
            // 
            this.nuevaDireccion_boton.Location = new System.Drawing.Point(7, 201);
            this.nuevaDireccion_boton.Name = "nuevaDireccion_boton";
            this.nuevaDireccion_boton.Size = new System.Drawing.Size(107, 23);
            this.nuevaDireccion_boton.TabIndex = 10;
            this.nuevaDireccion_boton.Text = "Crear dirección";
            this.nuevaDireccion_boton.UseVisualStyleBackColor = true;
            this.nuevaDireccion_boton.Click += new System.EventHandler(this.nuevaDireccion_boton_Click);
            // 
            // direccion_combobox
            // 
            this.direccion_combobox.FormattingEnabled = true;
            this.direccion_combobox.Location = new System.Drawing.Point(85, 165);
            this.direccion_combobox.Name = "direccion_combobox";
            this.direccion_combobox.Size = new System.Drawing.Size(280, 21);
            this.direccion_combobox.TabIndex = 9;
            this.direccion_combobox.SelectedIndexChanged += new System.EventHandler(this.direccion_combobox_SelectedIndexChanged);
            // 
            // cancelar_boton
            // 
            this.cancelar_boton.Location = new System.Drawing.Point(134, 201);
            this.cancelar_boton.Name = "cancelar_boton";
            this.cancelar_boton.Size = new System.Drawing.Size(107, 23);
            this.cancelar_boton.TabIndex = 3;
            this.cancelar_boton.Text = "Cancelar";
            this.cancelar_boton.UseVisualStyleBackColor = true;
            this.cancelar_boton.Click += new System.EventHandler(this.cancelar_boton_Click);
            // 
            // actualizar_boton
            // 
            this.actualizar_boton.Location = new System.Drawing.Point(258, 201);
            this.actualizar_boton.Name = "actualizar_boton";
            this.actualizar_boton.Size = new System.Drawing.Size(107, 23);
            this.actualizar_boton.TabIndex = 4;
            this.actualizar_boton.Text = "Guardar";
            this.actualizar_boton.UseVisualStyleBackColor = true;
            this.actualizar_boton.Click += new System.EventHandler(this.createContacto);
            // 
            // direccion_label
            // 
            this.direccion_label.AutoSize = true;
            this.direccion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_label.Location = new System.Drawing.Point(4, 165);
            this.direccion_label.Name = "direccion_label";
            this.direccion_label.Size = new System.Drawing.Size(74, 16);
            this.direccion_label.TabIndex = 8;
            this.direccion_label.Text = "Dirección";
            // 
            // movil_textbox
            // 
            this.movil_textbox.Location = new System.Drawing.Point(85, 130);
            this.movil_textbox.Name = "movil_textbox";
            this.movil_textbox.Size = new System.Drawing.Size(280, 20);
            this.movil_textbox.TabIndex = 7;
            this.movil_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // movil_label
            // 
            this.movil_label.AutoSize = true;
            this.movil_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movil_label.Location = new System.Drawing.Point(4, 130);
            this.movil_label.Name = "movil_label";
            this.movil_label.Size = new System.Drawing.Size(45, 16);
            this.movil_label.TabIndex = 6;
            this.movil_label.Text = "Móvil";
            // 
            // telefono_textbox
            // 
            this.telefono_textbox.Location = new System.Drawing.Point(85, 94);
            this.telefono_textbox.Name = "telefono_textbox";
            this.telefono_textbox.Size = new System.Drawing.Size(280, 20);
            this.telefono_textbox.TabIndex = 5;
            this.telefono_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teléfono";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(85, 58);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(280, 20);
            this.email_textbox.TabIndex = 3;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(4, 58);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(47, 16);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "Email";
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Location = new System.Drawing.Point(85, 22);
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(280, 20);
            this.nombre_textbox.TabIndex = 1;
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_label.Location = new System.Drawing.Point(4, 22);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(63, 16);
            this.nombre_label.TabIndex = 0;
            this.nombre_label.Text = "Nombre";
            // 
            // CreateContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 292);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "CreateContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateContacto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nuevaDireccion_boton;
        private System.Windows.Forms.ComboBox direccion_combobox;
        private System.Windows.Forms.Button cancelar_boton;
        private System.Windows.Forms.Button actualizar_boton;
        private System.Windows.Forms.Label direccion_label;
        private System.Windows.Forms.TextBox movil_textbox;
        private System.Windows.Forms.Label movil_label;
        private System.Windows.Forms.TextBox telefono_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.Label nombre_label;
    }
}