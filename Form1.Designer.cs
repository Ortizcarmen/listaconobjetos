namespace listaconobjetos
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
            this.labelDpi = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelfecha = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDpi = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.monthCalendarNacimiento = new System.Windows.Forms.MonthCalendar();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnOrdenarApellido = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.buttonOdenarDes = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLeer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDpi
            // 
            this.labelDpi.AutoSize = true;
            this.labelDpi.Location = new System.Drawing.Point(72, 68);
            this.labelDpi.Name = "labelDpi";
            this.labelDpi.Size = new System.Drawing.Size(28, 16);
            this.labelDpi.TabIndex = 0;
            this.labelDpi.Text = "Dpi";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(72, 128);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(56, 16);
            this.labelnombre.TabIndex = 1;
            this.labelnombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(72, 198);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(57, 16);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Location = new System.Drawing.Point(72, 269);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(135, 16);
            this.labelfecha.TabIndex = 3;
            this.labelfecha.Text = "Fecha de Nacimiento";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(219, 125);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(173, 22);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxDpi
            // 
            this.textBoxDpi.Location = new System.Drawing.Point(219, 81);
            this.textBoxDpi.Name = "textBoxDpi";
            this.textBoxDpi.Size = new System.Drawing.Size(173, 22);
            this.textBoxDpi.TabIndex = 5;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(219, 192);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(173, 22);
            this.textBoxApellido.TabIndex = 6;
            // 
            // monthCalendarNacimiento
            // 
            this.monthCalendarNacimiento.Location = new System.Drawing.Point(219, 252);
            this.monthCalendarNacimiento.Name = "monthCalendarNacimiento";
            this.monthCalendarNacimiento.TabIndex = 7;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(219, 494);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(137, 30);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 378);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(551, 494);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnOrdenarApellido
            // 
            this.btnOrdenarApellido.Location = new System.Drawing.Point(942, 81);
            this.btnOrdenarApellido.Name = "btnOrdenarApellido";
            this.btnOrdenarApellido.Size = new System.Drawing.Size(171, 23);
            this.btnOrdenarApellido.TabIndex = 11;
            this.btnOrdenarApellido.Text = "Ordenar por Apellido";
            this.btnOrdenarApellido.UseVisualStyleBackColor = true;
            this.btnOrdenarApellido.Click += new System.EventHandler(this.btnOrdenarApellido_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(759, 494);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // buttonOdenarDes
            // 
            this.buttonOdenarDes.Location = new System.Drawing.Point(942, 120);
            this.buttonOdenarDes.Name = "buttonOdenarDes";
            this.buttonOdenarDes.Size = new System.Drawing.Size(171, 23);
            this.buttonOdenarDes.TabIndex = 13;
            this.buttonOdenarDes.Text = "Ordenar Descendente";
            this.buttonOdenarDes.UseVisualStyleBackColor = true;
            this.buttonOdenarDes.Click += new System.EventHandler(this.buttonOdenarDes_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(653, 494);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLeer
            // 
            this.buttonLeer.Location = new System.Drawing.Point(868, 493);
            this.buttonLeer.Name = "buttonLeer";
            this.buttonLeer.Size = new System.Drawing.Size(75, 23);
            this.buttonLeer.TabIndex = 15;
            this.buttonLeer.Text = "Leer";
            this.buttonLeer.UseVisualStyleBackColor = true;
            this.buttonLeer.Click += new System.EventHandler(this.buttonLeer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 623);
            this.Controls.Add(this.buttonLeer);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonOdenarDes);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnOrdenarApellido);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.monthCalendarNacimiento);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxDpi);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelDpi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDpi;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDpi;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.MonthCalendar monthCalendarNacimiento;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOrdenarApellido;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button buttonOdenarDes;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLeer;
    }
}

