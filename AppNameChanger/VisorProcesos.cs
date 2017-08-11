using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNameChanger
{
    public partial class VisorProcesos : Form
    {
        public Principal Padre;

        public VisorProcesos(Principal pPadre)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Padre = pPadre;
            this.CargarProcesos();
        }

        private void CargarProcesos()
        {
            Process[] vProcesos = Process.GetProcesses();
            List<Proceso> vProcesosMostrar = new List<Proceso>();
            foreach (Process p in vProcesos)
            {
                if (!string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    vProcesosMostrar.Add(new Proceso { Id = p.Id, NombreOriginal = p.MainWindowTitle });
                }
            }
            this.grvProcesos.DataSource = vProcesosMostrar;
        }

        private void grvProcesos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int vFilaSeleccionada = this.grvProcesos.SelectedCells[0].RowIndex;
            int vProceso = int.Parse(this.grvProcesos.Rows[vFilaSeleccionada].Cells[0].Value.ToString());
            string vNombreActual = this.grvProcesos.Rows[vFilaSeleccionada].Cells[1].Value.ToString();

            if (vProceso > 0)
            {
                this.Padre.SeleccionarProceso(vProceso, vNombreActual);
            }
            this.Dispose();
        }
    }
}