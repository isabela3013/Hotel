namespace PresentationLayer.Formularios.CheckOut
{
    partial class FormCrearCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearCheckOut));
            cmbReservas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dgReservaItems = new DataGridView();
            lblTotalServicios = new Label();
            dgServicios = new DataGridView();
            lblTotalReserva = new Label();
            label3 = new Label();
            cmbMedioPago = new ComboBox();
            label4 = new Label();
            btnCrear = new Button();
            lblTotalReservaH = new Label();
            lblTotalReservaS = new Label();
            ((System.ComponentModel.ISupportInitialize)dgReservaItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgServicios).BeginInit();
            SuspendLayout();
            // 
            // cmbReservas
            // 
            cmbReservas.BackColor = SystemColors.InactiveCaption;
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Location = new Point(161, 57);
            cmbReservas.Name = "cmbReservas";
            cmbReservas.Size = new Size(356, 27);
            cmbReservas.TabIndex = 13;
            cmbReservas.SelectedIndexChanged += cmbReservas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 60);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 12;
            label2.Text = "Reserva";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 22);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 11;
            label1.Text = "CheckOut";
            // 
            // dgReservaItems
            // 
            dgReservaItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReservaItems.Location = new Point(35, 147);
            dgReservaItems.Name = "dgReservaItems";
            dgReservaItems.RowTemplate.Height = 25;
            dgReservaItems.Size = new Size(482, 97);
            dgReservaItems.TabIndex = 14;
            // 
            // lblTotalServicios
            // 
            lblTotalServicios.AutoSize = true;
            lblTotalServicios.Location = new Point(35, 431);
            lblTotalServicios.Name = "lblTotalServicios";
            lblTotalServicios.Size = new Size(43, 19);
            lblTotalServicios.TabIndex = 15;
            lblTotalServicios.Text = "Total";
            // 
            // dgServicios
            // 
            dgServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgServicios.Location = new Point(35, 280);
            dgServicios.Name = "dgServicios";
            dgServicios.RowTemplate.Height = 25;
            dgServicios.Size = new Size(482, 97);
            dgServicios.TabIndex = 16;
            // 
            // lblTotalReserva
            // 
            lblTotalReserva.AutoSize = true;
            lblTotalReserva.Location = new Point(84, 431);
            lblTotalReserva.Name = "lblTotalReserva";
            lblTotalReserva.Size = new Size(43, 19);
            lblTotalReserva.TabIndex = 17;
            lblTotalReserva.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 258);
            label3.Name = "label3";
            label3.Size = new Size(156, 19);
            label3.TabIndex = 18;
            label3.Text = "Servicios Comprados";
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.BackColor = SystemColors.InactiveCaption;
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(161, 99);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(356, 27);
            cmbMedioPago.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 102);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 19;
            label4.Text = "Medio Pago";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ActiveCaption;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Location = new Point(404, 419);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(113, 42);
            btnCrear.TabIndex = 21;
            btnCrear.Text = "Pagar";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblTotalReservaH
            // 
            lblTotalReservaH.AutoSize = true;
            lblTotalReservaH.Location = new Point(474, 247);
            lblTotalReservaH.Name = "lblTotalReservaH";
            lblTotalReservaH.Size = new Size(43, 19);
            lblTotalReservaH.TabIndex = 22;
            lblTotalReservaH.Text = "Total";
            // 
            // lblTotalReservaS
            // 
            lblTotalReservaS.AutoSize = true;
            lblTotalReservaS.Location = new Point(474, 380);
            lblTotalReservaS.Name = "lblTotalReservaS";
            lblTotalReservaS.Size = new Size(43, 19);
            lblTotalReservaS.TabIndex = 23;
            lblTotalReservaS.Text = "Total";
            // 
            // FormCrearCheckOut
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(553, 476);
            Controls.Add(lblTotalReservaS);
            Controls.Add(lblTotalReservaH);
            Controls.Add(btnCrear);
            Controls.Add(cmbMedioPago);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTotalReserva);
            Controls.Add(dgServicios);
            Controls.Add(lblTotalServicios);
            Controls.Add(dgReservaItems);
            Controls.Add(cmbReservas);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormCrearCheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear CheckOut";
            Load += FormCrearCheckOut_Load;
            ((System.ComponentModel.ISupportInitialize)dgReservaItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbReservas;
        private Label label2;
        private Label label1;
        private DataGridView dgReservaItems;
        private Label lblTotalServicios;
        private DataGridView dgServicios;
        private Label lblTotalReserva;
        private Label label3;
        private ComboBox cmbMedioPago;
        private Label label4;
        private Button btnCrear;
        private Label lblTotalReservaH;
        private Label lblTotalReservaS;
    }
}