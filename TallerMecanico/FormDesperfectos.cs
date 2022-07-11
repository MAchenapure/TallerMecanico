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
        DesperfectoBL mDesperfectoBL = new DesperfectoBL();
        PresupuestoBL mPresupuestoBL = new PresupuestoBL();

        private void FormDesperfectos_Load(object sender, EventArgs e)
        {
            #region Configuración grilla desperfectos
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

            #region Configuración grilla repuestos
            grdRepuestos.AllowUserToAddRows = false;
            grdRepuestos.AllowUserToDeleteRows = false;
            grdRepuestos.AllowUserToResizeColumns = false;
            grdRepuestos.AllowUserToResizeRows = false;
            grdRepuestos.AutoGenerateColumns = false;
            grdRepuestos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdRepuestos.MultiSelect = false;
            grdRepuestos.RowHeadersVisible = false;
            grdRepuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdRepuestos.ClearSelection();

            grdRepuestos.Columns.Add("Id", "Id");
            grdRepuestos.Columns[0].DataPropertyName = "Id";
            grdRepuestos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grdRepuestos.Columns.Add("Descripcion", "Descripción");
            grdRepuestos.Columns[1].DataPropertyName = "Descripcion";
            grdRepuestos.Columns[1].Width = 300;

            grdRepuestos.Columns.Add("Precio", "Precio");
            grdRepuestos.Columns[2].DataPropertyName = "Precio";
            grdRepuestos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            #endregion

            lblManoObra.Text = Constantes.ManoDeObra.ToString();

            ActualizarGridDesperfectos(mVehiculo);
        }

        private void ActualizarGridDesperfectos(Vehiculo pVehiculo)
        {
            grdDesperfectos.DataSource = null;
            grdDesperfectos.DataSource = pVehiculo.ListaDesperfectos;
            grdDesperfectos.ClearSelection();
        }
        private void ActualizarGridRepuestos(Desperfecto pDesperfecto)
        {
            grdRepuestos.DataSource = null;
            grdRepuestos.DataSource = pDesperfecto.ListaRepuestos;
            grdRepuestos.ClearSelection();
        }
        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            if (grdDesperfectos.SelectedRows.Count > 0)
            {
                Desperfecto mDesperfecto = grdDesperfectos.SelectedRows[0].DataBoundItem as Desperfecto;
                FormRepuestos mFormRepuestos = new FormRepuestos(mDesperfecto);
                mFormRepuestos.ShowDialog();
                ActualizarGridRepuestos(mDesperfecto);
            }
            else
            {
                MessageBox.Show("Seleccione o agregue un desperfecto a la lista.");
            }
        }
        private void btnEliminarDesperfecto_Click(object sender, EventArgs e)
        {
            if (grdDesperfectos.SelectedRows.Count > 0)
            {
                Desperfecto mDesperfecto = grdDesperfectos.SelectedRows[0].DataBoundItem as Desperfecto;
                mDesperfectoBL.EliminarDesperfecto(mDesperfecto);
                mVehiculo.ListaDesperfectos.Remove(mDesperfecto);
                ActualizarGridDesperfectos(mVehiculo);
            }
            else
            {
                MessageBox.Show("No se seleccionaron filas.");
            }
        }
        private void btnGuardarDesperfecto_Click(object sender, EventArgs e)
        {
            string mDescripcion = tbDescripcion.Text;
            int mTiempo = (int)numHoras.Value;
            int mManoDeObra = Constantes.ManoDeObra;
            int mIdVehiculo = mVehiculo.Id;

            if (mDescripcion != "")
            {
                Desperfecto mDesperfecto = new Desperfecto(mIdVehiculo, mDescripcion, mManoDeObra, mTiempo);
                mDesperfectoBL.AgregarDesperfecto(mDesperfecto);
                mVehiculo.ListaDesperfectos.Add(mDesperfecto);
                ActualizarGridDesperfectos(mVehiculo);
            }
            else
            {
                MessageBox.Show("Complete todos los campos para guardar el desperfecto.");
            }
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            if (grdDesperfectos.SelectedRows.Count > 0)
            {
                Desperfecto mDesperfecto = grdDesperfectos.SelectedRows[0].DataBoundItem as Desperfecto;
                Presupuesto mPresupuesto = new Presupuesto(mDesperfecto, mVehiculo);
                lblPrecio.Text = Math.Round(mPresupuesto.PrecioTotal, 2).ToString();
            }
            else
            {
                MessageBox.Show("Seleccione o agregue un desperfecto a la lista.");
            }
        }
        private void grdDesperfectos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDesperfectos.SelectedRows.Count > 0)
            {
                Desperfecto mDesperfecto = grdDesperfectos.SelectedRows[0].DataBoundItem as Desperfecto;
                ActualizarGridRepuestos(mDesperfecto);
            }
        }
    }
}
