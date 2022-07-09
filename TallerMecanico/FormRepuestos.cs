using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;

namespace UIL
{
    public partial class FormRepuestos : Form
    {
        public FormRepuestos()
        {
            InitializeComponent();
        }

        private void FormRepuestos_Load(object sender, EventArgs e)
        {
            RepuestoCompuesto mRepuestoComp = new RepuestoCompuesto() { Descripcion = "Motor" };
            RepuestoSimple mRepuestoSimple = new RepuestoSimple() { Descripcion = "Piston", Precio = 2900 };
            RepuestoSimple mRepuestoSimple2 = new RepuestoSimple() { Descripcion = "Inyector", Precio = 900 };
            RepuestoSimple mRepuestoSimple3 = new RepuestoSimple() { Descripcion = "Cigueñal", Precio = 9600 };

            mRepuestoComp.Agregar(mRepuestoSimple);
            mRepuestoComp.Agregar(mRepuestoSimple2);
            mRepuestoComp.Agregar(mRepuestoSimple3);

            ActualizarGrilla(mRepuestoComp);
        }

        public void ActualizarGrilla(IRepuesto pRepuesto)
        {

        }
    }
}
