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
            menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            submenuProductos = new FontAwesome.Sharp.IconMenuItem();
            menuVentas = new FontAwesome.Sharp.IconMenuItem();
            submenuRegistrarVentas = new FontAwesome.Sharp.IconMenuItem();
            submenuVerDetalleVentas = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            submenuRegistrarCompras = new FontAwesome.Sharp.IconMenuItem();
            submenuVerDetalleCompras = new FontAwesome.Sharp.IconMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            menuAcerca = new FontAwesome.Sharp.IconMenuItem();
            menutitulo = new MenuStrip();
            label1 = new Label();
            contenedor = new Panel();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuUsuarios, menuMantenedor, menuVentas, menuCompras, menuClientes, menuProveedores, menuReportes, menuAcerca });
            menu.Location = new Point(0, 76);
            menu.Name = "menu";
            menu.Size = new Size(1420, 58);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            menuUsuarios.IconColor = Color.Black;
            menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuarios.IconSize = 50;
            menuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(129, 54);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.Click += menuUsuarios_Click;
            // 
            // menuMantenedor
            // 
            menuMantenedor.DropDownItems.AddRange(new ToolStripItem[] { submenuCategorias, submenuProductos });
            menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            menuMantenedor.IconColor = Color.Black;
            menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMantenedor.IconSize = 50;
            menuMantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menuMantenedor.Name = "menuMantenedor";
            menuMantenedor.Size = new Size(146, 54);
            menuMantenedor.Text = "Mantendor";
            // 
            // submenuCategorias
            // 
            submenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuCategorias.IconColor = Color.Black;
            submenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuCategorias.Name = "submenuCategorias";
            submenuCategorias.Size = new Size(224, 26);
            submenuCategorias.Text = "Categorias";
            submenuCategorias.Click += submenuCategorias_Click;
            // 
            // submenuProductos
            // 
            submenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuProductos.IconColor = Color.Black;
            submenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuProductos.Name = "submenuProductos";
            submenuProductos.Size = new Size(224, 26);
            submenuProductos.Text = "Productos";
            submenuProductos.Click += submenuProductos_Click;
            // 
            // menuVentas
            // 
            menuVentas.DropDownItems.AddRange(new ToolStripItem[] { submenuRegistrarVentas, submenuVerDetalleVentas });
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            menuVentas.IconColor = Color.Black;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.IconSize = 50;
            menuVentas.ImageScaling = ToolStripItemImageScaling.None;
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(116, 54);
            menuVentas.Text = "Ventas";
            // 
            // submenuRegistrarVentas
            // 
            submenuRegistrarVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuRegistrarVentas.IconColor = Color.Black;
            submenuRegistrarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuRegistrarVentas.Name = "submenuRegistrarVentas";
            submenuRegistrarVentas.Size = new Size(224, 26);
            submenuRegistrarVentas.Text = "Registrar";
            submenuRegistrarVentas.Click += submenuRegistrarVentas_Click;
            // 
            // submenuVerDetalleVentas
            // 
            submenuVerDetalleVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuVerDetalleVentas.IconColor = Color.Black;
            submenuVerDetalleVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuVerDetalleVentas.Name = "submenuVerDetalleVentas";
            submenuVerDetalleVentas.Size = new Size(224, 26);
            submenuVerDetalleVentas.Text = "Ver Detalle";
            submenuVerDetalleVentas.Click += submenuVerDetalleVentas_Click;
            // 
            // menuCompras
            // 
            menuCompras.DropDownItems.AddRange(new ToolStripItem[] { submenuRegistrarCompras, submenuVerDetalleCompras });
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            menuCompras.IconColor = Color.Black;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 50;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(132, 54);
            menuCompras.Text = "Compras";
            // 
            // submenuRegistrarCompras
            // 
            submenuRegistrarCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuRegistrarCompras.IconColor = Color.Black;
            submenuRegistrarCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuRegistrarCompras.Name = "submenuRegistrarCompras";
            submenuRegistrarCompras.Size = new Size(224, 26);
            submenuRegistrarCompras.Text = "Registrar";
            submenuRegistrarCompras.Click += submenuRegistrarCompras_Click;
            // 
            // submenuVerDetalleCompras
            // 
            submenuVerDetalleCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuVerDetalleCompras.IconColor = Color.Black;
            submenuVerDetalleCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuVerDetalleCompras.Name = "submenuVerDetalleCompras";
            submenuVerDetalleCompras.Size = new Size(224, 26);
            submenuVerDetalleCompras.Text = "Ver Detalle";
            submenuVerDetalleCompras.Click += submenuVerDetalleCompras_Click;
            // 
            // menuClientes
            // 
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleArrowsLeftRight;
            menuClientes.IconColor = Color.Black;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 50;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(125, 54);
            menuClientes.Text = "Clientes";
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            menuProveedores.IconColor = Color.Black;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 50;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(155, 54);
            menuProveedores.Text = "Proveedores";
            menuProveedores.Click += menuProveedores_Click;
            // 
            // menuReportes
            // 
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReportes.IconColor = Color.Black;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 50;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(132, 54);
            menuReportes.Text = "Reportes";
            menuReportes.Click += menuReportes_Click;
            // 
            // menuAcerca
            // 
            menuAcerca.IconChar = FontAwesome.Sharp.IconChar.Info;
            menuAcerca.IconColor = Color.Black;
            menuAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcerca.IconSize = 50;
            menuAcerca.ImageScaling = ToolStripItemImageScaling.None;
            menuAcerca.Name = "menuAcerca";
            menuAcerca.Size = new Size(139, 54);
            menuAcerca.Text = "Acerca de";
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.Orange;
            menutitulo.ImageScalingSize = new Size(20, 20);
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.RightToLeft = RightToLeft.Yes;
            menutitulo.Size = new Size(1420, 76);
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
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 134);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1420, 654);
            contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 788);
            Controls.Add(contenedor);
            Controls.Add(label1);
            Controls.Add(menu);
            Controls.Add(menutitulo);
            MainMenuStrip = menu;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem menuAcerca;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem submenuCategorias;
        private FontAwesome.Sharp.IconMenuItem submenuProductos;
        private FontAwesome.Sharp.IconMenuItem submenuRegistrarVentas;
        private FontAwesome.Sharp.IconMenuItem submenuVerDetalleVentas;
        private FontAwesome.Sharp.IconMenuItem submenuRegistrarCompras;
        private FontAwesome.Sharp.IconMenuItem submenuVerDetalleCompras;
    }
}