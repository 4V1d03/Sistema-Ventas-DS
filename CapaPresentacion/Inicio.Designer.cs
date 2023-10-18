namespace CapaPresentacion
{
    partial class Inicio
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
            menu = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menutitulo = new MenuStrip();
            label1 = new Label();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { iconMenuItem8, iconMenuItem7, iconMenuItem6, iconMenuItem5, iconMenuItem3, iconMenuItem4, iconMenuItem2, iconMenuItem1 });
            menu.Location = new Point(0, 76);
            menu.Name = "menu";
            menu.Size = new Size(1444, 58);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 50;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(139, 54);
            iconMenuItem1.Text = "Acerca de";
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.Orange;
            menutitulo.ImageScalingSize = new Size(20, 20);
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.RightToLeft = RightToLeft.Yes;
            menutitulo.Size = new Size(1444, 76);
            menutitulo.TabIndex = 1;
            menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(229, 41);
            label1.TabIndex = 2;
            label1.Text = "Sistema Ventas";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.IconSize = 50;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(132, 54);
            iconMenuItem2.Text = "Reportes";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.IconSize = 50;
            iconMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(125, 54);
            iconMenuItem3.Text = "Clientes";
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.IconSize = 50;
            iconMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(155, 54);
            iconMenuItem4.Text = "Proveedores";
            // 
            // iconMenuItem5
            // 
            iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconMenuItem5.IconColor = Color.Black;
            iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem5.IconSize = 50;
            iconMenuItem5.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem5.Name = "iconMenuItem5";
            iconMenuItem5.Size = new Size(132, 54);
            iconMenuItem5.Text = "Compras";
            // 
            // iconMenuItem6
            // 
            iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconMenuItem6.IconColor = Color.Black;
            iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem6.IconSize = 50;
            iconMenuItem6.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem6.Name = "iconMenuItem6";
            iconMenuItem6.Size = new Size(116, 54);
            iconMenuItem6.Text = "Ventas";
            // 
            // iconMenuItem7
            // 
            iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconMenuItem7.IconColor = Color.Black;
            iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem7.IconSize = 50;
            iconMenuItem7.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem7.Name = "iconMenuItem7";
            iconMenuItem7.Size = new Size(146, 54);
            iconMenuItem7.Text = "Mantendor";
            // 
            // iconMenuItem8
            // 
            iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconMenuItem8.IconColor = Color.Black;
            iconMenuItem8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem8.IconSize = 50;
            iconMenuItem8.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem8.Name = "iconMenuItem8";
            iconMenuItem8.Size = new Size(129, 54);
            iconMenuItem8.Text = "Usuarios";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 682);
            Controls.Add(label1);
            Controls.Add(menu);
            Controls.Add(menutitulo);
            MainMenuStrip = menu;
            Name = "Inicio";
            Text = "Inicio";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
    }
}