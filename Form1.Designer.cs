namespace FormatoFuentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPropiedades = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.buttonRojoPropiedades = new System.Windows.Forms.Button();
            this.buttonLilaPropiedades = new System.Windows.Forms.Button();
            this.buttonVerdePropiedades = new System.Windows.Forms.Button();
            this.buttonReducir = new System.Windows.Forms.Button();
            this.buttonAumentar = new System.Windows.Forms.Button();
            this.labelPropiedades = new System.Windows.Forms.Label();
            this.panelTamaño = new System.Windows.Forms.Panel();
            this.lstTamTexto = new System.Windows.Forms.ComboBox();
            this.groupBoxTamaño = new System.Windows.Forms.GroupBox();
            this.buttonRojoTamaño = new System.Windows.Forms.Button();
            this.buttonLilaTamaño = new System.Windows.Forms.Button();
            this.buttonVerdeTamaño = new System.Windows.Forms.Button();
            this.labelTamaño = new System.Windows.Forms.Label();
            this.panelTexto = new System.Windows.Forms.Panel();
            this.checkBoxSubrayado = new System.Windows.Forms.CheckBox();
            this.checkBoxCursiva = new System.Windows.Forms.CheckBox();
            this.checkBoxNegrita = new System.Windows.Forms.CheckBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonOcultar = new System.Windows.Forms.Button();
            this.lbox_Fuentes = new System.Windows.Forms.ListBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.panelPropiedades.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.panelTamaño.SuspendLayout();
            this.groupBoxTamaño.SuspendLayout();
            this.panelTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPropiedades
            // 
            this.panelPropiedades.Controls.Add(this.groupBoxColor);
            this.panelPropiedades.Controls.Add(this.buttonReducir);
            this.panelPropiedades.Controls.Add(this.buttonAumentar);
            this.panelPropiedades.Controls.Add(this.labelPropiedades);
            this.panelPropiedades.Location = new System.Drawing.Point(12, 12);
            this.panelPropiedades.Name = "panelPropiedades";
            this.panelPropiedades.Size = new System.Drawing.Size(268, 125);
            this.panelPropiedades.TabIndex = 0;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.buttonRojoPropiedades);
            this.groupBoxColor.Controls.Add(this.buttonLilaPropiedades);
            this.groupBoxColor.Controls.Add(this.buttonVerdePropiedades);
            this.groupBoxColor.Location = new System.Drawing.Point(16, 60);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(153, 55);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color del Formulario";
            // 
            // buttonRojoPropiedades
            // 
            this.buttonRojoPropiedades.BackColor = System.Drawing.Color.Red;
            this.buttonRojoPropiedades.Location = new System.Drawing.Point(81, 21);
            this.buttonRojoPropiedades.Name = "buttonRojoPropiedades";
            this.buttonRojoPropiedades.Size = new System.Drawing.Size(23, 23);
            this.buttonRojoPropiedades.TabIndex = 2;
            this.buttonRojoPropiedades.UseVisualStyleBackColor = false;
            this.buttonRojoPropiedades.Click += new System.EventHandler(this.buttonRojoPropiedades_Click);
            // 
            // buttonLilaPropiedades
            // 
            this.buttonLilaPropiedades.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonLilaPropiedades.Location = new System.Drawing.Point(52, 21);
            this.buttonLilaPropiedades.Name = "buttonLilaPropiedades";
            this.buttonLilaPropiedades.Size = new System.Drawing.Size(23, 23);
            this.buttonLilaPropiedades.TabIndex = 1;
            this.buttonLilaPropiedades.UseVisualStyleBackColor = false;
            this.buttonLilaPropiedades.Click += new System.EventHandler(this.buttonLilaPropiedades_Click);
            // 
            // buttonVerdePropiedades
            // 
            this.buttonVerdePropiedades.BackColor = System.Drawing.Color.Lime;
            this.buttonVerdePropiedades.Location = new System.Drawing.Point(23, 21);
            this.buttonVerdePropiedades.Name = "buttonVerdePropiedades";
            this.buttonVerdePropiedades.Size = new System.Drawing.Size(23, 23);
            this.buttonVerdePropiedades.TabIndex = 0;
            this.buttonVerdePropiedades.UseVisualStyleBackColor = false;
            this.buttonVerdePropiedades.Click += new System.EventHandler(this.buttonVerdePropiedades_Click);
            // 
            // buttonReducir
            // 
            this.buttonReducir.Location = new System.Drawing.Point(120, 31);
            this.buttonReducir.Name = "buttonReducir";
            this.buttonReducir.Size = new System.Drawing.Size(75, 23);
            this.buttonReducir.TabIndex = 2;
            this.buttonReducir.Text = "Reducir";
            this.buttonReducir.UseVisualStyleBackColor = true;
            this.buttonReducir.Click += new System.EventHandler(this.buttonReducir_Click);
            // 
            // buttonAumentar
            // 
            this.buttonAumentar.Location = new System.Drawing.Point(16, 31);
            this.buttonAumentar.Name = "buttonAumentar";
            this.buttonAumentar.Size = new System.Drawing.Size(86, 23);
            this.buttonAumentar.TabIndex = 1;
            this.buttonAumentar.Text = "Aumentar";
            this.buttonAumentar.UseVisualStyleBackColor = true;
            this.buttonAumentar.Click += new System.EventHandler(this.buttonAumentar_Click);
            // 
            // labelPropiedades
            // 
            this.labelPropiedades.AutoSize = true;
            this.labelPropiedades.Location = new System.Drawing.Point(13, 12);
            this.labelPropiedades.Name = "labelPropiedades";
            this.labelPropiedades.Size = new System.Drawing.Size(150, 16);
            this.labelPropiedades.TabIndex = 0;
            this.labelPropiedades.Text = "Propiedades del FORM";
            // 
            // panelTamaño
            // 
            this.panelTamaño.Controls.Add(this.lstTamTexto);
            this.panelTamaño.Controls.Add(this.groupBoxTamaño);
            this.panelTamaño.Controls.Add(this.labelTamaño);
            this.panelTamaño.Location = new System.Drawing.Point(12, 159);
            this.panelTamaño.Name = "panelTamaño";
            this.panelTamaño.Size = new System.Drawing.Size(200, 137);
            this.panelTamaño.TabIndex = 1;
            // 
            // lstTamTexto
            // 
            this.lstTamTexto.FormattingEnabled = true;
            this.lstTamTexto.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.lstTamTexto.Location = new System.Drawing.Point(16, 35);
            this.lstTamTexto.Name = "lstTamTexto";
            this.lstTamTexto.Size = new System.Drawing.Size(153, 24);
            this.lstTamTexto.TabIndex = 5;
            this.lstTamTexto.Text = "8";
            this.lstTamTexto.SelectedIndexChanged += new System.EventHandler(this.lstTamTexto_SelectedIndexChanged);
            // 
            // groupBoxTamaño
            // 
            this.groupBoxTamaño.Controls.Add(this.buttonRojoTamaño);
            this.groupBoxTamaño.Controls.Add(this.buttonLilaTamaño);
            this.groupBoxTamaño.Controls.Add(this.buttonVerdeTamaño);
            this.groupBoxTamaño.Location = new System.Drawing.Point(16, 72);
            this.groupBoxTamaño.Name = "groupBoxTamaño";
            this.groupBoxTamaño.Size = new System.Drawing.Size(153, 55);
            this.groupBoxTamaño.TabIndex = 4;
            this.groupBoxTamaño.TabStop = false;
            this.groupBoxTamaño.Text = "Color Texto";
            // 
            // buttonRojoTamaño
            // 
            this.buttonRojoTamaño.BackColor = System.Drawing.Color.Red;
            this.buttonRojoTamaño.Location = new System.Drawing.Point(81, 21);
            this.buttonRojoTamaño.Name = "buttonRojoTamaño";
            this.buttonRojoTamaño.Size = new System.Drawing.Size(23, 23);
            this.buttonRojoTamaño.TabIndex = 2;
            this.buttonRojoTamaño.UseVisualStyleBackColor = false;
            this.buttonRojoTamaño.Click += new System.EventHandler(this.buttonRojoTamaño_Click);
            // 
            // buttonLilaTamaño
            // 
            this.buttonLilaTamaño.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonLilaTamaño.Location = new System.Drawing.Point(52, 21);
            this.buttonLilaTamaño.Name = "buttonLilaTamaño";
            this.buttonLilaTamaño.Size = new System.Drawing.Size(23, 23);
            this.buttonLilaTamaño.TabIndex = 1;
            this.buttonLilaTamaño.UseVisualStyleBackColor = false;
            this.buttonLilaTamaño.Click += new System.EventHandler(this.buttonLilaTamaño_Click);
            // 
            // buttonVerdeTamaño
            // 
            this.buttonVerdeTamaño.BackColor = System.Drawing.Color.Lime;
            this.buttonVerdeTamaño.Location = new System.Drawing.Point(23, 21);
            this.buttonVerdeTamaño.Name = "buttonVerdeTamaño";
            this.buttonVerdeTamaño.Size = new System.Drawing.Size(23, 23);
            this.buttonVerdeTamaño.TabIndex = 0;
            this.buttonVerdeTamaño.UseVisualStyleBackColor = false;
            this.buttonVerdeTamaño.Click += new System.EventHandler(this.buttonVerdeTamaño_Click);
            // 
            // labelTamaño
            // 
            this.labelTamaño.AutoSize = true;
            this.labelTamaño.Location = new System.Drawing.Point(13, 16);
            this.labelTamaño.Name = "labelTamaño";
            this.labelTamaño.Size = new System.Drawing.Size(111, 16);
            this.labelTamaño.TabIndex = 0;
            this.labelTamaño.Text = "Tamaño del texto";
            // 
            // panelTexto
            // 
            this.panelTexto.Controls.Add(this.checkBoxSubrayado);
            this.panelTexto.Controls.Add(this.checkBoxCursiva);
            this.panelTexto.Controls.Add(this.checkBoxNegrita);
            this.panelTexto.Controls.Add(this.buttonCerrar);
            this.panelTexto.Controls.Add(this.buttonMostrar);
            this.panelTexto.Controls.Add(this.buttonOcultar);
            this.panelTexto.Location = new System.Drawing.Point(12, 316);
            this.panelTexto.Name = "panelTexto";
            this.panelTexto.Size = new System.Drawing.Size(464, 100);
            this.panelTexto.TabIndex = 2;
            // 
            // checkBoxSubrayado
            // 
            this.checkBoxSubrayado.AutoSize = true;
            this.checkBoxSubrayado.Location = new System.Drawing.Point(344, 60);
            this.checkBoxSubrayado.Name = "checkBoxSubrayado";
            this.checkBoxSubrayado.Size = new System.Drawing.Size(96, 20);
            this.checkBoxSubrayado.TabIndex = 5;
            this.checkBoxSubrayado.Text = "Subrayado";
            this.checkBoxSubrayado.UseVisualStyleBackColor = true;
            this.checkBoxSubrayado.CheckedChanged += new System.EventHandler(this.checkBoxSubrayado_CheckedChanged);
            // 
            // checkBoxCursiva
            // 
            this.checkBoxCursiva.AutoSize = true;
            this.checkBoxCursiva.Location = new System.Drawing.Point(192, 60);
            this.checkBoxCursiva.Name = "checkBoxCursiva";
            this.checkBoxCursiva.Size = new System.Drawing.Size(74, 20);
            this.checkBoxCursiva.TabIndex = 4;
            this.checkBoxCursiva.Text = "Cursiva";
            this.checkBoxCursiva.UseVisualStyleBackColor = true;
            this.checkBoxCursiva.CheckedChanged += new System.EventHandler(this.checkBoxCursiva_CheckedChanged);
            // 
            // checkBoxNegrita
            // 
            this.checkBoxNegrita.AutoSize = true;
            this.checkBoxNegrita.Location = new System.Drawing.Point(29, 60);
            this.checkBoxNegrita.Name = "checkBoxNegrita";
            this.checkBoxNegrita.Size = new System.Drawing.Size(73, 20);
            this.checkBoxNegrita.TabIndex = 3;
            this.checkBoxNegrita.Text = "Negrita";
            this.checkBoxNegrita.UseVisualStyleBackColor = true;
            this.checkBoxNegrita.CheckedChanged += new System.EventHandler(this.checkBoxNegrita_CheckedChanged);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(340, 21);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(104, 23);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(178, 21);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(104, 23);
            this.buttonMostrar.TabIndex = 1;
            this.buttonMostrar.Text = "Mostrar Texto";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonOcultar
            // 
            this.buttonOcultar.Location = new System.Drawing.Point(16, 21);
            this.buttonOcultar.Name = "buttonOcultar";
            this.buttonOcultar.Size = new System.Drawing.Size(104, 23);
            this.buttonOcultar.TabIndex = 0;
            this.buttonOcultar.Text = "Ocultar Texto";
            this.buttonOcultar.UseVisualStyleBackColor = true;
            this.buttonOcultar.Click += new System.EventHandler(this.buttonOcultar_Click);
            // 
            // lbox_Fuentes
            // 
            this.lbox_Fuentes.FormattingEnabled = true;
            this.lbox_Fuentes.ItemHeight = 16;
            this.lbox_Fuentes.Location = new System.Drawing.Point(500, 12);
            this.lbox_Fuentes.Name = "lbox_Fuentes";
            this.lbox_Fuentes.Size = new System.Drawing.Size(215, 404);
            this.lbox_Fuentes.TabIndex = 3;
            this.lbox_Fuentes.SelectedIndexChanged += new System.EventHandler(this.lbox_Fuentes_SelectedIndexChanged);
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelTexto.Location = new System.Drawing.Point(288, 195);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(55, 17);
            this.labelTexto.TabIndex = 4;
            this.labelTexto.Text = "TEXTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 439);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.lbox_Fuentes);
            this.Controls.Add(this.panelTexto);
            this.Controls.Add(this.panelTamaño);
            this.Controls.Add(this.panelPropiedades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPropiedades.ResumeLayout(false);
            this.panelPropiedades.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.panelTamaño.ResumeLayout(false);
            this.panelTamaño.PerformLayout();
            this.groupBoxTamaño.ResumeLayout(false);
            this.panelTexto.ResumeLayout(false);
            this.panelTexto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPropiedades;
        private System.Windows.Forms.Panel panelTamaño;
        private System.Windows.Forms.Panel panelTexto;
        private System.Windows.Forms.ListBox lbox_Fuentes;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Button buttonRojoPropiedades;
        private System.Windows.Forms.Button buttonLilaPropiedades;
        private System.Windows.Forms.Button buttonVerdePropiedades;
        private System.Windows.Forms.Button buttonReducir;
        private System.Windows.Forms.Button buttonAumentar;
        private System.Windows.Forms.Label labelPropiedades;
        private System.Windows.Forms.GroupBox groupBoxTamaño;
        private System.Windows.Forms.Button buttonRojoTamaño;
        private System.Windows.Forms.Button buttonLilaTamaño;
        private System.Windows.Forms.Button buttonVerdeTamaño;
        private System.Windows.Forms.Label labelTamaño;
        private System.Windows.Forms.CheckBox checkBoxSubrayado;
        private System.Windows.Forms.CheckBox checkBoxCursiva;
        private System.Windows.Forms.CheckBox checkBoxNegrita;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonOcultar;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.ComboBox lstTamTexto;
    }
}

