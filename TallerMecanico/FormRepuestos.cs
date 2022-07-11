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

namespace UIL
{
    public partial class FormRepuestos : Form
    {
        public FormRepuestos(bool pFlagABM = false)
        {
            InitializeComponent();
            mFlagABM = pFlagABM;
        }

        public FormRepuestos(Desperfecto pDesperfecto, bool pFlagABM = false)
        {
            InitializeComponent();
            mFlagABM = pFlagABM;
            mDesperfecto = pDesperfecto;
        }

        private void FormRepuestos_Load(object sender, EventArgs e)
        {
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

            if (mFlagABM)
            {
                btnAgregarDesperfecto.Visible = false;
            } else
            {
                lblDescripcion.Visible = false;
                lblPrecio.Visible = false;
                tbDescripcion.Visible = false;
                numPrecio.Visible = false;
                btnAgregarABM.Visible = false;
                btnEliminar.Visible = false;
            }

            ActualizarGrid();


        }

        RepuestoBL mRepuestoBL = new RepuestoBL();
        DesperfectoBL mDesperfectoBL = new DesperfectoBL();
        Desperfecto mDesperfecto;
        bool mFlagABM = false;

        public void ActualizarGrid()
        {
            grdRepuestos.DataSource = null;
            grdRepuestos.DataSource = Repuesto.ListaRepuestos;
            grdRepuestos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mDescripcion = tbDescripcion.Text;
            int mPrecio = (int)numPrecio.Value;

            Repuesto mRepuesto = new Repuesto(mDescripcion, mPrecio);

            mRepuestoBL.AgregarRepuesto(mRepuesto);
            Repuesto.ListaRepuestos.Add(mRepuesto);

            ActualizarGrid();
        }

        private void brnEliminar_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.SelectedRows.Count > 0)
            {
                Repuesto mRepuesto = grdRepuestos.SelectedRows[0].DataBoundItem as Repuesto;
                mRepuestoBL.EliminarRepuesto(mRepuesto);
                Repuesto.ListaRepuestos.Remove(mRepuesto);

                ActualizarGrid();
            }
            else
            {
                MessageBox.Show("No se seleccionaron filas");
            }
        }

        private void btnAgregarDesperfecto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.SelectedRows.Count > 0)
            {
                Repuesto mRepuesto = grdRepuestos.SelectedRows[0].DataBoundItem as Repuesto;
                mDesperfecto.ListaRepuestos.Add(mRepuesto);
                mDesperfectoBL.AgregarRepuesto(mRepuesto, mDesperfecto);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se seleccionaron filas");
            }
        }
    }
}
