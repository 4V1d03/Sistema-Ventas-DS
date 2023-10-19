namespace CapaPresentacion
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtdocumento = new TextBox();
            txtcontrasena = new TextBox();
            btningresar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 450);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 23);
            label2.Name = "label2";
            label2.Size = new Size(269, 39);
            label2.TabIndex = 1;
            label2.Text = "Sistema Ventas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(378, 97);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 2;
            label3.Text = "No. Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(378, 204);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Orange;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Atlassian;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 295;
            iconPictureBox1.Location = new Point(0, 97);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(295, 296);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(378, 128);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(278, 27);
            txtdocumento.TabIndex = 5;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(378, 235);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(278, 27);
            txtcontrasena.TabIndex = 6;
            // 
            // btningresar
            // 
            btningresar.IconChar = FontAwesome.Sharp.IconChar.None;
            btningresar.IconColor = Color.Black;
            btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningresar.Location = new Point(378, 309);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(118, 48);
            btningresar.TabIndex = 7;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.Location = new Point(538, 309);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(118, 48);
            btnsalir.TabIndex = 8;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Controls.Add(btningresar);
            Controls.Add(txtcontrasena);
            Controls.Add(txtdocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtdocumento;
        private TextBox txtcontrasena;
        private FontAwesome.Sharp.IconButton btningresar;
        private FontAwesome.Sharp.IconButton btnsalir;
    }
}