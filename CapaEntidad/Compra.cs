using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Usuario oUsuario { get; set; } // oUsuario = IdUsuario de la tabla Usuario
        public Proveedor oProveedor { get; set; } // oProveedor = IdProveedor de la tabla Proveedor
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Compra> oDetalleCompra { get; set; } //es de tipo lista ya que se pueden comprar varios productos, y dichos productos estan representados en la tabla de Detalle_Compra
        public string FechaRegistro { get; set; }










    }
}
