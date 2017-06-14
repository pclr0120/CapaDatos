using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

#region NewUsing
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
#endregion

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para Practica.xaml
    /// </summary>
    public partial class Practica : Window
    {
        public Practica()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CapaPresentacion.Venta_Ticket VT = new CapaPresentacion.Venta_Ticket();
            //Llamas el reporte
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\pclr\Desktop\CapaPresentacion\CapaPresentacion\Ticket.rpt");

            //declaras los metodos
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValue = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            
            //parametro 1
            crParameterDiscreteValue.Value = "111";//Envio el IdVenta
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["IdVenta"];
            crParameterValue = crParameterFieldDefinition.CurrentValues;

            crParameterValue.Clear();
            crParameterValue.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValue);

            //Ejecuta el reporte
            VT.crystalReportViewer1.ReportSource = crystalrpt;
            VT.crystalReportViewer1.Refresh();
            VT.ShowDialog();
        }
    }
}
