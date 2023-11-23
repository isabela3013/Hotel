namespace PresentationLayer.Formularios.Registros
{
    partial class FormCrearRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearRegistro));
            btnGuardar = new Button();
            panel1 = new Panel();
            btnQuiDetalle = new Button();
            btnAgrDetalle = new Button();
            label5 = new Label();
            txtCantidad = new TextBox();
            cmbServicios = new ComboBox();
            label4 = new Label();
            dgDetalle = new DataGridView();
            txtPersonas = new TextBox();
            label3 = new Label();
            cmbClientes = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cmbReservas = new ComboBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetalle).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(403, 378);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 45);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnQuiDetalle);
            panel1.Controls.Add(btnAgrDetalle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(cmbServicios);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgDetalle);
            panel1.Location = new Point(21, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 208);
            panel1.TabIndex = 14;
            // 
            // btnQuiDetalle
            // 
            btnQuiDetalle.BackColor = SystemColors.ActiveCaption;
            btnQuiDetalle.FlatStyle = FlatStyle.Flat;
            btnQuiDetalle.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuiDetalle.Location = new Point(459, 130);
            btnQuiDetalle.Name = "btnQuiDetalle";
            btnQuiDetalle.Size = new Size(53, 35);
            btnQuiDetalle.TabIndex = 9;
            btnQuiDetalle.Text = "-";
            btnQuiDetalle.UseVisualStyleBackColor = false;
            // 
            // btnAgrDetalle
            // 
            btnAgrDetalle.BackColor = SystemColors.ActiveCaption;
            btnAgrDetalle.FlatStyle = FlatStyle.Flat;
            btnAgrDetalle.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgrDetalle.Location = new Point(459, 79);
            btnAgrDetalle.Name = "btnAgrDetalle";
            btnAgrDetalle.Size = new Size(53, 35);
            btnAgrDetalle.TabIndex = 7;
            btnAgrDetalle.Text = "+";
            btnAgrDetalle.UseVisualStyleBackColor = false;
            btnAgrDetalle.Click += btnAgrDetalle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 24);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 7;
            label5.Text = "Cant.";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.InactiveCaption;
            txtCantidad.Location = new Point(432, 21);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(71, 29);
            txtCantidad.TabIndex = 8;
            // 
            // cmbServicios
            // 
            cmbServicios.BackColor = SystemColors.InactiveCaption;
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(112, 21);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(237, 27);
            cmbServicios.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 24);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 7;
            label4.Text = "Servicio";
            // 
            // dgDetalle
            // 
            dgDetalle.BackgroundColor = SystemColors.ActiveCaption;
            dgDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDetalle.Location = new Point(19, 63);
            dgDetalle.Name = "dgDetalle";
            dgDetalle.RowTemplate.Height = 25;
            dgDetalle.Size = new Size(426, 130);
            dgDetalle.TabIndex = 0;
            // 
            // txtPersonas
            // 
            txtPersonas.BackColor = SystemColors.InactiveCaption;
            txtPersonas.Location = new Point(145, 83);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(375, 29);
            txtPersonas.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 86);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 12;
            label3.Text = "Personas";
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = SystemColors.InactiveCaption;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(145, 45);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(375, 27);
            cmbClientes.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 48);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 9;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 13);
            label1.Name = "label1";
            label1.Size = new Size(127, 19);
            label1.TabIndex = 8;
            label1.Text = "Nuevo Registro";
            // 
            // cmbReservas
            // 
            cmbReservas.BackColor = SystemColors.InactiveCaption;
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Location = new Point(145, 121);
            cmbReservas.Name = "cmbReservas";
            cmbReservas.Size = new Size(375, 27);
            cmbReservas.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 124);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 16;
            label6.Text = "Reservas";
            // 
            // FormCrearRegistro
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 435);
            Controls.Add(cmbReservas);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(panel1);
            Controls.Add(txtPersonas);
            Controls.Add(label3);
            Controls.Add(cmbClientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormCrearRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Registro";
            Load += FormCrearRegistro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Panel panel1;
        private Button btnQuiDetalle;
        private Button btnAgrDetalle;
        private Label label5;
        private TextBox txtCantidad;
        private ComboBox cmbServicios;
        private Label label4;
        private DataGridView dgDetalle;
        private TextBox txtPersonas;
        private Label label3;
        private ComboBox cmbClientes;
        private Label label2;
        private Label label1;
        private ComboBox cmbReservas;
        private Label label6;
    }
}