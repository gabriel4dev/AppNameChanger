using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNameChanger
{
    public partial class Principal : Form
    {
        private List<Proceso> procesos;

        public Principal()
        {
            InitializeComponent();
            this.Text = "App Name Changer v" + Application.ProductVersion;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.procesos = new List<Proceso>();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string vNuevoNombre = this.txtNuevoTitulo.Text;
            int vProceso = 0;

            if (string.IsNullOrEmpty(vNuevoNombre) || string.IsNullOrEmpty(this.txtProcesoId.Text) || !int.TryParse(this.txtProcesoId.Text, out vProceso))
            {
                MessageBox.Show("Se deben completar los campos:", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.CambiarNombreProceso(vNuevoNombre, vProceso, false);
            }
        }

        private void CambiarNombreProceso(string pNuevoNombre, int pProceso, bool pReestablecer)
        {
            Process vProceso = Process.GetProcessById(pProceso);
            if (vProceso != null)
            {
                try
                {
                    if (this.procesos.Any(p => p.Id == pProceso))
                    {
                        Proceso vP = this.procesos.FirstOrDefault(p => p.Id == pProceso);
                        vP.NombreActual = pNuevoNombre;
                    }
                    else
                    {
                        Proceso vProcesoGuardar = new Proceso { Id = pProceso, NombreOriginal = vProceso.MainWindowTitle, NombreActual = pNuevoNombre };
                        this.procesos.Add(vProcesoGuardar);
                    }
                    SetWindowText(vProceso.MainWindowHandle, pNuevoNombre);
                    this.RefrescarTablaProcesos();
                    if (!pReestablecer) MessageBox.Show("Éxito, el nombre del proceso se cambió correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void SeleccionarProceso(int pProceso, string pNombreActual)
        {
            this.txtProcesoId.Text = pProceso.ToString();
            this.txtNuevoTitulo.Text = pNombreActual;
            this.txtNuevoTitulo.SelectAll();
        }

        private void RefrescarTablaProcesos()
        {
            this.grvProcesos.DataSource = null;
            this.grvProcesos.DataSource = this.procesos;
        }

        [DllImport("user32.dll")]
        private static extern void SetWindowText(IntPtr hWnd, string windowName);

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ReestablecerNombres();
        }

        private void ReestablecerNombres()
        {
            try
            {
                foreach (Proceso p in this.procesos)
                {
                    this.CambiarNombreProceso(p.NombreOriginal, p.Id, true);
                }
                this.procesos = new List<Proceso>();
                this.RefrescarTablaProcesos();
                this.LimpiarCuadrosTexto();
                MessageBox.Show("Éxito, se reestableció los nombres de las aplicaciones.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCuadrosTexto()
        {
            this.txtNuevoTitulo.Text = string.Empty;
            this.txtProcesoId.Text = string.Empty;
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.procesos.Any())
            {
                this.ReestablecerNombres();
            }
        }

        private void btnVerProcesos_Click(object sender, EventArgs e)
        {
            VisorProcesos vVisor = new VisorProcesos(this);
            vVisor.Visible = true;
        }
    }
}