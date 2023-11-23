namespace PresentationLayer.Formularios
{
    partial class FormCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckOut));
            dgCheckOut = new DataGridView();
            label1 = new Label();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCheckOut).BeginInit();
            SuspendLayout();
            // 
            // dgCheckOut
            // 
            dgCheckOut.BackgroundColor = SystemColors.ActiveCaption;
            dgCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCheckOut.Location = new Point(29, 80);
            dgCheckOut.Name = "dgCheckOut";
            dgCheckOut.RowTemplate.Height = 25;
            dgCheckOut.Size = new Size(487, 247);
            dgCheckOut.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 1;
            label1.Text = "CheckOut";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ActiveCaption;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Location = new Point(403, 344);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(113, 54);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Ir al Checkout";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormCheckOut
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(549, 426);
            Controls.Add(btnCrear);
            Controls.Add(label1);
            Controls.Add(dgCheckOut);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormCheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCheckOut";
            Load += FormCheckOut_Load;
            ((System.ComponentModel.ISupportInitialize)dgCheckOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCheckOut;
        private Label label1;
        private Button btnCrear;
    }
}