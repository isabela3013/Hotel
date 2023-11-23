namespace PresentationLayer
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnReservar = new Button();
            btnCheckOut = new Button();
            panelFondo = new Panel();
            btnPersonas = new Button();
            btnRegistros = new Button();
            SuspendLayout();
            // 
            // btnReservar
            // 
            btnReservar.BackColor = SystemColors.ActiveCaption;
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.FlatStyle = FlatStyle.Flat;
            btnReservar.Location = new Point(13, 80);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(179, 50);
            btnReservar.TabIndex = 0;
            btnReservar.Text = "Reservas";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.ActiveCaption;
            btnCheckOut.Cursor = Cursors.Hand;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Location = new Point(12, 192);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(179, 50);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Check-Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.AliceBlue;
            panelFondo.Location = new Point(206, 2);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(549, 426);
            panelFondo.TabIndex = 4;
            // 
            // btnPersonas
            // 
            btnPersonas.BackColor = SystemColors.ActiveCaption;
            btnPersonas.Cursor = Cursors.Hand;
            btnPersonas.FlatStyle = FlatStyle.Flat;
            btnPersonas.Location = new Point(13, 248);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(179, 50);
            btnPersonas.TabIndex = 5;
            btnPersonas.Text = "Personas";
            btnPersonas.UseVisualStyleBackColor = false;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.BackColor = SystemColors.ActiveCaption;
            btnRegistros.Cursor = Cursors.Hand;
            btnRegistros.FlatStyle = FlatStyle.Flat;
            btnRegistros.Location = new Point(13, 136);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(179, 50);
            btnRegistros.TabIndex = 6;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = false;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(756, 430);
            Controls.Add(btnRegistros);
            Controls.Add(btnPersonas);
            Controls.Add(btnCheckOut);
            Controls.Add(panelFondo);
            Controls.Add(btnReservar);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnReservar;
        private Button btnCheckOut;
        private Panel panelFondo;
        private Button btnPersonas;
        private Button btnRegistros;
    }
}