namespace PresentationLayer.Formularios.Registros
{
    partial class FormRegistros
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
            label1 = new Label();
            dgServicios = new DataGridView();
            label2 = new Label();
            dgRegistros = new DataGridView();
            btnVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRegistros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 0;
            label1.Text = "Servicios";
            // 
            // dgServicios
            // 
            dgServicios.BackgroundColor = SystemColors.ActiveCaption;
            dgServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgServicios.Location = new Point(24, 45);
            dgServicios.Name = "dgServicios";
            dgServicios.RowTemplate.Height = 25;
            dgServicios.Size = new Size(476, 113);
            dgServicios.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(238, 174);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 2;
            label2.Text = "Ventas";
            // 
            // dgRegistros
            // 
            dgRegistros.BackgroundColor = SystemColors.ActiveCaption;
            dgRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRegistros.Location = new Point(24, 206);
            dgRegistros.Name = "dgRegistros";
            dgRegistros.RowTemplate.Height = 25;
            dgRegistros.Size = new Size(476, 113);
            dgRegistros.TabIndex = 3;
            // 
            // btnVenta
            // 
            btnVenta.BackColor = SystemColors.ActiveCaption;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Location = new Point(399, 335);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(101, 40);
            btnVenta.TabIndex = 4;
            btnVenta.Text = "Vender";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // FormRegistros
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(533, 387);
            Controls.Add(btnVenta);
            Controls.Add(dgRegistros);
            Controls.Add(label2);
            Controls.Add(dgServicios);
            Controls.Add(label1);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormRegistros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistros";
            Load += FormRegistros_Load;
            ((System.ComponentModel.ISupportInitialize)dgServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgServicios;
        private Label label2;
        private DataGridView dgRegistros;
        private Button btnVenta;
    }
}