namespace PresentationLayer.Formularios.Reservas
{
    partial class FormCrearReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearReserva));
            label1 = new Label();
            label2 = new Label();
            cmbClientes = new ComboBox();
            btnCrearCliente = new Button();
            label3 = new Label();
            txtPersonas = new TextBox();
            panel1 = new Panel();
            btnQuiDetalle = new Button();
            btnAgrDetalle = new Button();
            label5 = new Label();
            txtCantidad = new TextBox();
            cmbHabitaciones = new ComboBox();
            label4 = new Label();
            dgDetalle = new DataGridView();
            btnGuardar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetalle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(218, 18);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 0;
            label1.Text = "Nueva Reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 53);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = SystemColors.InactiveCaption;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(140, 50);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(254, 27);
            cmbClientes.TabIndex = 2;
            // 
            // btnCrearCliente
            // 
            btnCrearCliente.BackColor = SystemColors.ActiveCaption;
            btnCrearCliente.FlatStyle = FlatStyle.Flat;
            btnCrearCliente.Location = new Point(421, 52);
            btnCrearCliente.Name = "btnCrearCliente";
            btnCrearCliente.Size = new Size(94, 58);
            btnCrearCliente.TabIndex = 3;
            btnCrearCliente.Text = "Crear Cliente";
            btnCrearCliente.UseVisualStyleBackColor = false;
            btnCrearCliente.Click += btnCrearCliente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 91);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 4;
            label3.Text = "Personas";
            // 
            // txtPersonas
            // 
            txtPersonas.BackColor = SystemColors.InactiveCaption;
            txtPersonas.Location = new Point(140, 88);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(254, 29);
            txtPersonas.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnQuiDetalle);
            panel1.Controls.Add(btnAgrDetalle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(cmbHabitaciones);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgDetalle);
            panel1.Location = new Point(12, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 208);
            panel1.TabIndex = 6;
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
            // cmbHabitaciones
            // 
            cmbHabitaciones.BackColor = SystemColors.InactiveCaption;
            cmbHabitaciones.FormattingEnabled = true;
            cmbHabitaciones.Location = new Point(112, 21);
            cmbHabitaciones.Name = "cmbHabitaciones";
            cmbHabitaciones.Size = new Size(237, 27);
            cmbHabitaciones.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 24);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 7;
            label4.Text = "Habitación";
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
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(394, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 45);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormCrearReserva
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(553, 415);
            Controls.Add(btnGuardar);
            Controls.Add(panel1);
            Controls.Add(txtPersonas);
            Controls.Add(label3);
            Controls.Add(btnCrearCliente);
            Controls.Add(cmbClientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormCrearReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear";
            Load += FormCrearReserva_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbClientes;
        private Button btnCrearCliente;
        private Label label3;
        private TextBox txtPersonas;
        private Panel panel1;
        private Button btnQuiDetalle;
        private Button btnAgrDetalle;
        private Label label5;
        private TextBox txtCantidad;
        private ComboBox cmbHabitaciones;
        private Label label4;
        private DataGridView dgDetalle;
        private Button btnGuardar;
    }
}