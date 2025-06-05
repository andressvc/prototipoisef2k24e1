using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class Nav_Clientes : Form
    {
        public Nav_Clientes()
        {
            //Este bloque de codigo debe ir en todos los formularios de navegador
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = { "Carnet", "Nombre", "Dirección", "Teléfono", "Email", "Estado", "Estatus" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.FromArgb(218, 247, 245));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("alumnos");
            navegador1.ObtenerIdAplicacion("1001"); // ID específico para esta pantalla
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("2"); // ID de ayuda correspondiente
            navegador1.AsignarNombreForm("Registro de Alumnos");
        }
    }
}
