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
using BL;
using Framework;

namespace UIL
{
    public partial class FormDesperfectos : Form
    {
        public FormDesperfectos(Vehiculo pVehiculo)
        {
            InitializeComponent();
            mVehiculo = pVehiculo;
        }

        Vehiculo mVehiculo;
        VehiculoBL mVehiculoBL = new VehiculoBL();
        DesperfectoBL mDesperfectoBL = new DesperfectoBL();

        private void FormDesperfectos_Load(object sender, EventArgs e)
        {
            #region Configuración grilla
            grdDesperfectos.AllowUserToAddRows = false;
            grdDesperfectos.AllowUserToDeleteRows = false;
            grdDesperfectos.AllowUserToResizeColumns = false;
            grdDesperfectos.AllowUserToResizeRows = false;
            grdDesperfectos.AutoGenerateColumns = false;
            grdDesperfectos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdDesperfectos.MultiSelect = false;
            grdDesperfectos.RowHeadersVisible = false;
            grdDesperfectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDesperfectos.ClearSelection();
            
            grdDesperfectos.Columns.Add("Id", "Id");
            grdDesperfectos.Columns[0].DataPropertyName = "Id";
            grdDesperfectos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grdDesperfectos.Columns.Add("Descripcion", "Descripción");
            grdDesperfectos.Columns[1].DataPropertyName = "Descripcion";
            grdDesperfectos.Columns[1].Width = 500;

            grdDesperfectos.Columns.Add("Tiempo", "Tiempo");
            grdDesperfectos.Columns[2].DataPropertyName = "Tiempo";
            grdDesperfectos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grdDesperfectos.Columns.Add("ManoDeObra", "M.O.($)");
            grdDesperfectos.Columns[3].DataPropertyName = "ManoDeObra";
            grdDesperfectos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            #endregion

            lblManoObra.Text = Constantes.ManoDeObra.ToString();

            ActualizarGrid(mVehiculo);
        }

        private void ActualizarGrid(Vehiculo pVehiculo)
        {
            grdDesperfectos.DataSource = null;
            grdDesperfectos.DataSource = pVehiculo.ListaDesperfectos;
            grdDesperfectos.ClearSelection();
        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            FormRepuestos mFormRepuestos = new FormRepuestos();
            mFormRepuestos.ShowDialog();
        }

        private void btnGuardarDesperfecto_Click(object sender, EventArgs e)
        {
            string mDescripcion = tbDescripcion.Text;
            int mTiempo = (int)numHoras.Value;
            int mManoDeObra = Constantes.ManoDeObra;
            int mIdVehiculo = mVehiculo.Id;

            if(mDescripcion != "")
            {
                Desperfecto mDesperfecto = new Desperfecto(mIdVehiculo, mDescripcion, mManoDeObra, mTiempo);
                mDesperfectoBL.AgregarDesperfecto(mDesperfecto);
                mVehiculo.ListaDesperfectos.Add(mDesperfecto);
                ActualizarGrid(mVehiculo);
            }
            else
            {
                MessageBox.Show("Complete todos los campos para guardar el desperfecto.");
            }
        }

        private void btnEliminarDesperfecto_Click(object sender, EventArgs e)
        {
            if (grdDesperfectos.SelectedRows.Count > 0)
            {
                Desperfecto mDesperfecto = grdDesperfectos.SelectedRows[0].DataBoundItem as Desperfecto;
                mDesperfectoBL.EliminarDesperfecto(mDesperfecto);
                mVehiculo.ListaDesperfectos.Remove(mDesperfecto);
                ActualizarGrid(mVehiculo);
            }
            else
            {
                MessageBox.Show("No se seleccionaron filas.");
            }
        }
    }
}
