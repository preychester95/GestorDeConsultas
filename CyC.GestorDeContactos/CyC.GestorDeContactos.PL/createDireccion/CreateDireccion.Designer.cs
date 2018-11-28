namespace CyC.GestorDeContactos.PL.createDireccion
{
    partial class CreateDireccion
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
            this.pais_combobox = new System.Windows.Forms.ComboBox();
            this.provincia_combobox = new System.Windows.Forms.ComboBox();
            this.cancelar_boton = new System.Windows.Forms.Button();
            this.actualizar_boton = new System.Windows.Forms.Button();
            this.provincia_label = new System.Windows.Forms.Label();
            this.pais_label = new System.Windows.Forms.Label();
            this.telefono_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.localidad_textbox = new System.Windows.Forms.TextBox();
            this.localidad_label = new System.Windows.Forms.Label();
            this.codigopostal_textbox = new System.Windows.Forms.TextBox();
            this.codigopostal_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pais_combobox);
            this.panel1.Controls.Add(this.provincia_combobox);
            this.panel1.Controls.Add(this.cancelar_boton);
            this.panel1.Controls.Add(this.actualizar_boton);
            this.panel1.Controls.Add(this.provincia_label);
            this.panel1.Controls.Add(this.pais_label);
            this.panel1.Controls.Add(this.telefono_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.localidad_textbox);
            this.panel1.Controls.Add(this.localidad_label);
            this.panel1.Controls.Add(this.codigopostal_textbox);
            this.panel1.Controls.Add(this.codigopostal_label);
            this.panel1.Location = new System.Drawing.Point(35, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 238);
            this.panel1.TabIndex = 3;
            // 
            // pais_combobox
            // 
            this.pais_combobox.FormattingEnabled = true;
            this.pais_combobox.Location = new System.Drawing.Point(134, 125);
            this.pais_combobox.Name = "pais_combobox";
            this.pais_combobox.Size = new System.Drawing.Size(280, 21);
            this.pais_combobox.TabIndex = 10;
            this.pais_combobox.SelectedIndexChanged += new System.EventHandler(this.pais_combobox_SelectedIndexChanged);
            // 
            // provincia_combobox
            // 
            this.provincia_combobox.FormattingEnabled = true;
            this.provincia_combobox.Location = new System.Drawing.Point(134, 160);
            this.provincia_combobox.Name = "provincia_combobox";
            this.provincia_combobox.Size = new System.Drawing.Size(280, 21);
            this.provincia_combobox.TabIndex = 9;
            this.provincia_combobox.SelectedIndexChanged += new System.EventHandler(this.provincia_combobox_SelectedIndexChanged);
            // 
            // cancelar_boton
            // 
            this.cancelar_boton.Location = new System.Drawing.Point(180, 201);
            this.cancelar_boton.Name = "cancelar_boton";
            this.cancelar_boton.Size = new System.Drawing.Size(107, 23);
            this.cancelar_boton.TabIndex = 3;
            this.cancelar_boton.Text = "Cancelar";
            this.cancelar_boton.UseVisualStyleBackColor = true;
            this.cancelar_boton.Click += new System.EventHandler(this.cancelar_boton_Click);
            // 
            // actualizar_boton
            // 
            this.actualizar_boton.Location = new System.Drawing.Point(307, 201);
            this.actualizar_boton.Name = "actualizar_boton";
            this.actualizar_boton.Size = new System.Drawing.Size(107, 23);
            this.actualizar_boton.TabIndex = 4;
            this.actualizar_boton.Text = "Guardar";
            this.actualizar_boton.UseVisualStyleBackColor = true;
            this.actualizar_boton.Click += new System.EventHandler(this.actualizar_boton_Click);
            // 
            // provincia_label
            // 
            this.provincia_label.AutoSize = true;
            this.provincia_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provincia_label.Location = new System.Drawing.Point(3, 161);
            this.provincia_label.Name = "provincia_label";
            this.provincia_label.Size = new System.Drawing.Size(73, 16);
            this.provincia_label.TabIndex = 8;
            this.provincia_label.Text = "Provincia";
            // 
            // pais_label
            // 
            this.pais_label.AutoSize = true;
            this.pais_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pais_label.Location = new System.Drawing.Point(3, 126);
            this.pais_label.Name = "pais_label";
            this.pais_label.Size = new System.Drawing.Size(39, 16);
            this.pais_label.TabIndex = 6;
            this.pais_label.Text = "Pais";
            // 
            // telefono_textbox
            // 
            this.telefono_textbox.Location = new System.Drawing.Point(134, 90);
            this.telefono_textbox.Name = "telefono_textbox";
            this.telefono_textbox.Size = new System.Drawing.Size(280, 20);
            this.telefono_textbox.TabIndex = 5;
            this.telefono_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teléfono";
            // 
            // localidad_textbox
            // 
            this.localidad_textbox.Location = new System.Drawing.Point(134, 57);
            this.localidad_textbox.Name = "localidad_textbox";
            this.localidad_textbox.Size = new System.Drawing.Size(280, 20);
            this.localidad_textbox.TabIndex = 3;
            // 
            // localidad_label
            // 
            this.localidad_label.AutoSize = true;
            this.localidad_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidad_label.Location = new System.Drawing.Point(3, 54);
            this.localidad_label.Name = "localidad_label";
            this.localidad_label.Size = new System.Drawing.Size(77, 16);
            this.localidad_label.TabIndex = 2;
            this.localidad_label.Text = "Localidad";
            // 
            // codigopostal_textbox
            // 
            this.codigopostal_textbox.Location = new System.Drawing.Point(134, 22);
            this.codigopostal_textbox.Name = "codigopostal_textbox";
            this.codigopostal_textbox.Size = new System.Drawing.Size(280, 20);
            this.codigopostal_textbox.TabIndex = 1;
            // 
            // codigopostal_label
            // 
            this.codigopostal_label.AutoSize = true;
            this.codigopostal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigopostal_label.Location = new System.Drawing.Point(3, 18);
            this.codigopostal_label.Name = "codigopostal_label";
            this.codigopostal_label.Size = new System.Drawing.Size(105, 16);
            this.codigopostal_label.TabIndex = 0;
            this.codigopostal_label.Text = "Código postal";
            // 
            // CreateDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 292);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CreateDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateDireccion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox provincia_combobox;
        private System.Windows.Forms.Button cancelar_boton;
        private System.Windows.Forms.Button actualizar_boton;
        private System.Windows.Forms.Label provincia_label;
        private System.Windows.Forms.Label pais_label;
        private System.Windows.Forms.TextBox telefono_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox localidad_textbox;
        private System.Windows.Forms.Label localidad_label;
        private System.Windows.Forms.TextBox codigopostal_textbox;
        private System.Windows.Forms.Label codigopostal_label;
        private System.Windows.Forms.ComboBox pais_combobox;
    }
}