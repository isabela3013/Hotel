namespace PresentationLayer.Formularios.Personas
{
    partial class FormPersonas
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
            dgPersonas = new DataGridView();
            label1 = new Label();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgPersonas
            // 
            dgPersonas.BackgroundColor = SystemColors.ActiveCaption;
            dgPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPersonas.Location = new Point(30, 73);
            dgPersonas.Margin = new Padding(4);
            dgPersonas.Name = "dgPersonas";
            dgPersonas.RowTemplate.Height = 25;
            dgPersonas.Size = new Size(470, 230);
            dgPersonas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 2;
            label1.Text = "Personas";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ActiveCaption;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Location = new Point(387, 321);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(113, 54);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Crear Persona";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormPersonas
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(533, 387);
            Controls.Add(btnCrear);
            Controls.Add(label1);
            Controls.Add(dgPersonas);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPersonas";
            Load += FormPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)dgPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPersonas;
        private Label label1;
        private Button btnCrear;
    }
}