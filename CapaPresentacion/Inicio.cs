using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formActivo = null;





        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void abrirfrm(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formActivo != null)
            {
                formActivo.Close();
            }
            //configuracion de fomulario
            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Orange;

            contenedor.Controls.Add(formulario); //asigna el fomrulario al contenedor
            formulario.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            abrirfrm((IconMenuItem)sender, new Usuarios());
        }

        private void submenuCategorias_Click(object sender, EventArgs e)
        {
            abrirfrm(menuMantenedor, new Categorias());
        }

        private void submenuProductos_Click(object sender, EventArgs e)
        {
            abrirfrm(menuMantenedor, new Productos());
        }

        private void submenuRegistrarVentas_Click(object sender, EventArgs e)
        {
            abrirfrm(menuVentas, new Ventas());
        }

        private void submenuVerDetalleVentas_Click(object sender, EventArgs e)
        {
            abrirfrm(menuVentas, new Detalle_Venta());
        }

        private void submenuRegistrarCompras_Click(object sender, EventArgs e)
        {
            abrirfrm(menuCompras, new Compras());
        }

        private void submenuVerDetalleCompras_Click(object sender, EventArgs e)
        {
            abrirfrm(menuCompras, new Detalle_Compra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            abrirfrm((IconMenuItem)sender, new Clientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            abrirfrm((IconMenuItem)sender, new Proveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            abrirfrm((IconMenuItem)sender, new Reportes());
        }









    }
}
