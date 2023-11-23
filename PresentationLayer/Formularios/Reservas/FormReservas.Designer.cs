namespace PresentationLayer.Formularios
{
    partial class FormReservas
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
            dgReservas = new DataGridView();
            label1 = new Label();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgReservas).BeginInit();
            SuspendLayout();
            // 
            // dgReservas
            // 
            dgReservas.BackgroundColor = SystemColors.ActiveCaption;
            dgReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReservas.Location = new Point(38, 77);
            dgReservas.Name = "dgReservas";
            dgReservas.RowTemplate.Height = 25;
            dgReservas.Size = new Size(469, 254);
            dgReservas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 37);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 1;
            label1.Text = "Reservas";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ActiveCaption;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Location = new Point(394, 351);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(113, 54);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear Reserva";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(549, 426);
            Controls.Add(btnCrear);
            Controls.Add(label1);
            Controls.Add(dgReservas);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReservas";
            Load += FormReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgReservas;
        private Label label1;
        private Button btnCrear;
    }
}