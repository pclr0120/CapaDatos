using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region NewUsing
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
#endregion

namespace Modulo_Empleados.INTERFAZ_PRINCIPAL
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            tabControl_Reportes.Dock = DockStyle.Fill;
            rb_punto_vta.Checked = true;
            CapaLogica.Reportes R = new CapaLogica.Reportes();
            cb_empleado.DisplayMember = "Usuario";
            cb_empleado.DataSource = R.ReporteBuscarUsuarios();
            cb_producto.DisplayMember = "Nombre";
            cb_producto.DataSource = R.ReporteBuscarProductos();
            ch_empleado.Checked = false;
            ch_producto.Checked = false;
            cb_empleado.Enabled = false;
            cb_producto.Enabled = false;
            GenerarVentasRangos();
        }

        private void rb_punto_vta_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_punto;
        }

        private void rb_inventario_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_inv;
        }

        private void rb_membre_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_clientes;
        }

        private void rb_equipo_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_equipo;
        }

        private void rb_empleados_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_empleados;
        }

        private void ch_producto_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_producto.Checked == true)
            {
                cb_producto.Enabled = true;
            }
            else
            {
                cb_producto.Enabled = false;
            }
        }

        private void ch_empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_empleado.Checked == true)
            {
                cb_empleado.Enabled = true;
            }
            else
            {
                cb_empleado.Enabled = false;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (ch_empleado.Checked == false && ch_producto.Checked == false)
            {
                GenerarVentasRangos();
            }
            else if (ch_empleado.Checked == true && ch_producto.Checked == false)
            {
                GenerarVentasRangosEmpleado();
            }
            else if (ch_empleado.Checked == false && ch_producto.Checked == true)
            {
                GenerarVentasRangosProducto();
            }
            else if (ch_empleado.Checked == true && ch_producto.Checked == true)
            {
                GenerarVentasTodo();
            }
        }

        public void GenerarVentasRangos()
        {
            //Llamas el reporte
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Frank Crow-Belloso\Source\CapaDatos4\CapaPresentacion2\Modulo_Empleados\INTERFAZ_PRINCIPAL\VentasRangos.rpt");

            //declaras los metodos
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValue = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //parametro 1
            crParameterDiscreteValue.Value = dtp_inicial.Value;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FechaInicial"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //parametro 2
            crParameterDiscreteValue.Value = dtp_final.Value;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FechaFinal"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Ejecuta el reporte
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        public void GenerarVentasRangosEmpleado()
        {
            //Llamas el reporte
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Frank Crow-Belloso\Source\CapaDatos4\CapaPresentacion2\Modulo_Empleados\INTERFAZ_PRINCIPAL\VentasRangosEmpleado.rpt");

            //declaras los metodos
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValue = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //parametro 1
            crParameterDiscreteValue.Value = dtp_inicial.Value;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FechaInicial"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //parametro 2
            crParameterDiscreteValue.Value = dtp_final.Value;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FechaFinal"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Parametro 3
            crParameterDiscreteValue.Value = Convert.ToInt32(cb_empleado.Text.Substring(0,cb_empleado.Text.IndexOf(" -")));//Envio el IdVenta
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["IdEmpleado"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Ejecuta el reporte
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        public void GenerarVentasRangosProducto()
        {
            //Llamas el reporte
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Frank Crow-Belloso\Source\CapaDatos4\CapaPresentacion2\Modulo_Empleados\INTERFAZ_PRINCIPAL\VentasRangosProducto.rpt");

            //declaras los metodos
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValue = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //parametro 1
            crParameterDiscreteValue.Value = dtp_inicial.Value;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FechaInicial"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //parametro 2
            crParameterDiscreteValue.Value = dtp_final.Value;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FechaFinal"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Parametro 3
            crParameterDiscreteValue.Value = cb_producto.Text;//Envio el IdVenta
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["NombreProducto"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Ejecuta el reporte
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        public void GenerarVentasTodo()
        {
            //Llamas el reporte
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Frank Crow-Belloso\Source\CapaDatos4\CapaPresentacion2\Modulo_Empleados\INTERFAZ_PRINCIPAL\VentasTodo.rpt");

            //declaras los metodos
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValue = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //parametro Fecha Inicial
            crParameterDiscreteValue.Value = dtp_inicial.Value;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FechaInicial"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //parametro Fecha Final
            crParameterDiscreteValue.Value = dtp_final.Value;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FechaFinal"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Parametro Nombre Producto
            crParameterDiscreteValue.Value = cb_producto.Text;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["NombreProducto"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Parametro Id Empleado
            crParameterDiscreteValue.Value = Convert.ToInt32(cb_empleado.Text.Substring(0, cb_empleado.Text.IndexOf(" -")));//Envio el IdVenta
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["IdEmpleado"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Ejecuta el reporte
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }
    }
}
