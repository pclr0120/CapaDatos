﻿using System;
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
using CapaLogica;
using System.Data;
using CapaPresentacion.VENTA;
using System.Windows.Threading;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CapaPresentacion.VENTA
{
    /// <summary>
    /// Lógica de interacción para PuntoVenta.xaml
    /// </summary>
    public partial class PuntoVenta : Window
    {
        public PuntoVenta()
        {
            InitializeComponent();
            reloj();
        
            txtCodigo.Focus();
            
        }
        #region reloj
        public void reloj()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickeven;
            timer.Start();



        }

        private void tickeven(object sender, EventArgs e)
        {
            LblReloj.Content = DateTime.Now.ToString();
        }
        #endregion





        #region ControlTeclas   

        VentaMaestra Vm = new VentaMaestra();
        Producto p = new Producto();
        bool control = true;
        int banderacontrol=0;
        public void SoloNumeros(TextCompositionEventArgs e)
        {
            //se convierte a Ascci del la tecla presionada 
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            //verificamos que se encuentre en ese rango que son entre el 0 y el 9 
            if (ascci >= 48 && ascci <= 57)
                e.Handled = false;
            else e.Handled = true;
        }

        void AgregarCantidadProducto() {
            try
            {
                CantidadProducto cp = new CantidadProducto(dataGrid.Items.Count);
                cp.ShowDialog();
                if (cp.registro != null && cp.cantidad != null)
                {
                    List<Producto> dt = new List<Producto>();
                    Vm.agregarcantidad = cp.cantidad;
                    dt= Vm.AgregarCantidadProducto(cp.registro, cp.cantidad);
                    if (dt != null)
                    {
                        dataGrid.ItemsSource = dt;   //agrega al datagrid los productos
                        dataGrid.Items.Refresh();
                        calVenta();  //acutliza los totaltes
                    }
                    else {
                        if (Vm.stockTemporal > 0 && Vm.agregarcantidad>0)
                        {
                            MessageBox.Show("Cantidad de producto en existencia:"+Vm.agregarcantidad+". Actualice la cantidad ");
                        }
                        else {
                            MessageBox.Show("no hay en existencia.");
                        }
                       
                    }
                  
                
                }
            }
            catch (Exception e) {

                MessageBox.Show("Error consulte con su administrado:"+e.ToString());
            }
            txtCodigo.Focus();
        }
        public void EvaluarTecla(object sender, KeyEventArgs e)
        {

            txtCodigo.Focus();
            if ( banderacontrol==0)
            {
               
                control = false;
                if (Key.Escape == e.Key)
                {
                    salir();
                  
                }
                if (Key.A == e.Key)
                {


                    this.Close();


                }
                if (Key.F8 == e.Key)
                {


                    vincularmembresia();


                }
                if (Key.F3 == e.Key)
                {

                    Asistencia();


                }
                if (Key.F1 == e.Key)
                {
                  
                    RealizarVenta();
                

                }

                if (Key.F2 == e.Key)
                {

                    AgregarProductoVenta();
                  

                }
                if (Key.F4 == e.Key)
                {
                    EliminarProductoVenta();

                 

                }
                if (Key.F5 == e.Key && dataGrid.Items.Count > 0)
                {
                    CancelarVenta();
                  
                }
                if (Key.F7 == e.Key )
                {
                    Devoluciones();

                }
                if (Key.F6 == e.Key)
                {
                    consultarProducot();
                   
                }
                if (Key.C == e.Key && dataGrid.Items.Count > 0)
                {
                  
                    AgregarCantidadProducto();
                }


            }
            banderacontrol += 1;
            if (banderacontrol > 1)
            {
                banderacontrol = 0;
            }

        }


        #endregion

        #region comanodos
        void consultarProducot()
        {
            int c = 1;
            if (c == 1)
            {
                ConsultaProducto cp = new ConsultaProducto();
                cp.ShowDialog();
            }
            txtCodigo.Focus();
        }
        void EliminarProductoVenta()
        {
            int x = 1;
            if (x == 1)
            {
                x = 2;
                if (dataGrid.Items.Count > 0)
                {
                    control = false;
                    Mensaje.MensajeCaptura M = new Mensaje.MensajeCaptura("Eliminar producto", "Capture el # registro del producto a eliminar:", "Eliminar F1", "Cancelar F2", true,"intEliminarRegistro");
                    M.valor5 = dataGrid.Items.Count;
                    M.ShowDialog();
                 
                    if ( Vm.ListaProducto.Exists(c => c.Registro == M.valor) )
                    {
                        Vm.valor = M.valor;   //registro a eliminar
                        Eliminar();
                    }



                    txtCodigo.Focus();

                }
              
            }
        }

        void AgregarProductoVenta()
        {
            int c = 1;
            if (c == 1)
            {
                control = false;
                c = 2;
                Mensaje.MensajeCaptura M = new Mensaje.MensajeCaptura("VENTA MANUAL", "Codigo:", "AGREGAR F1", "CANCELAR F2", true,"int");
                M.ShowDialog();
                if (M.valor > 0)
                    AgregarProducto(M.valor.ToString());
            }
            txtCodigo.Focus();

        }
        public void AgregarProducto(string codigo)
        {
            List<Producto> lt = new List<Producto>();
            lt= Vm.CProducto(codigo);
            if (Vm.Sinproducto != true)
            {
                if (Vm.Encontrado != true)
                {
                    MessageBox.Show("Producto no encontrado");

                }
                else
                {

                    dataGrid.ItemsSource = lt;  //agrega al datagrid los productos
                    dataGrid.Items.Refresh();
                    calVenta();  //acutliza los totaltes
                }
                if (Vm.p.Stock0)
                {
                    MessageBox.Show("No se encuentra en stock");
                }
            }
            else {
                MessageBox.Show("No hay en Existencia");
            }

        }
        #endregion
        #region  agregarVenta








        public void calVenta()
        {
            Vm.CalVenta();
            LblIVA.Content = "$" + Vm.IVA.ToString();
            LblSubtotal.Content = "$" + Vm.Subtotal.ToString();
            LblTotal.Content = "$" + Vm.Total.ToString();

        }




        public void Eliminar()
        {
            dataGrid.ItemsSource = Vm.EliminarProducto();
            dataGrid.Items.Refresh();
            calVenta();

        }

        #endregion

        //cambio
        void cambio()
        {
            control = false;
            Mensaje.MensajeCaptura pagocambio = new Mensaje.MensajeCaptura("PAGO$", "PAGO CON $:", "ACEPTAR F1", "", true, "double");
            pagocambio.Total = Vm.Total;
            pagocambio.ShowDialog(); 
                Vm.Pago = pagocambio.valor2;

          

        }
        #region FinalizarLAVenta

        void Ticket(string parametro) {

            CapaPresentacion.Venta_Ticket VT = new CapaPresentacion.Venta_Ticket();
            //Llamas el reporte
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Frank Crow-Belloso\Source\CapaDatos4\CapaPresentacion\Ticket.rpt");

            //declaras los metodos
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValue = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //parametro 1
            crParameterDiscreteValue.Value = parametro;//Envio el IdVenta
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
        public void RealizarVenta()
        {
            if (dataGrid.Items.Count > 0)
            {
                control = false;
                Mensaje.Mesaje confirmar = new Mensaje.Mesaje("Confimacion"," 'Desea Realizar la venta?","SI F1","NO F2");
                confirmar.ShowDialog();
                if (confirmar.Si) { 
                cambio();

                if (Vm.GuardarVenta(dataGrid.Items.Count) == 1)
                    {

                        ClienteVenta c = new ClienteVenta(Vm.IdVenta);
                        c.ShowDialog();
                    Mensaje.MensajeOk m = new Mensaje.MensajeOk("Mensaje:", "La venta se realizo exitoxamente. su cambio es: $" + Vm.Cambio.ToString());

                        m.ShowDialog();
                        //VENTA.simularTicket stk = new VENTA.simularTicket();
                        //stk.ShowDialog();
                        Ticket(Vm.IdVenta.ToString());

                    
                        dataGrid.ItemsSource = Vm.LimpiarVenta(); //para limpiar la venta
                        dataGrid.Items.Refresh();//para limpiar la venta
                        calVenta();
                    }
                    else
                    {

                        Mensaje.MensajeOk m = new Mensaje.MensajeOk("Mensaje:Error", "Error, Consulte con su administrador.");

                        m.Show();
                    }
                   
                }

                 }
            //para limpiar la venta
            txtCodigo.Focus();

        }

        public void CancelarVenta()
        {
            int c = 1;
            Vm.StockEntimporeal = 0;
            if (c == 1)
            {
                c = 2;
                if (dataGrid.Items.Count > 0)
                {
                    control = false;
                    Mensaje.Mesaje Mm = new CapaPresentacion.Mensaje.Mesaje("Cancelar Venta", "Desea Cancelar la venta?", "Si F1", "No F2");
                    Mm.ShowDialog();
                    if (Mm.Si)
                    {
                        dataGrid.ItemsSource = null;
                        dataGrid.Items.Refresh();//para limpiar la venta
                        Vm.LimpiarVenta();
                        txtCodigo.Clear();
                        txtCodigo.Focus();

                        calVenta();
                    }
                }
            }

            txtCodigo.Focus();
        }


        #endregion


        void Devoluciones() {

            banderacontrol += 1;
            Devoluciones dv = new Devoluciones();
            try
            {
                dv.Show();
            }
            catch (Exception)
            { }
            txtCodigo.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            banderacontrol += 1;
            EliminarProductoVenta();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            banderacontrol += 1;
            Asistencia();
        }
        void AgregarProductoVenta(string codigo)
        {
            int c = 1;
            if (c == 1)
            {
                control = false;
                c = 2;

                if (codigo !=null)
                    AgregarProducto(codigo.ToString());
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            banderacontrol += 1;
            Mensaje.MensajeCaptura M = new Mensaje.MensajeCaptura("VENTA MANUAL", "Codigo:", "AGREGAR F1", "CANCELAR F2", true, "string");
            M.ShowDialog();
            AgregarProductoVenta(M.valor3);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            banderacontrol += 1;
            consultarProducot();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            banderacontrol += 1;
            CancelarVenta();
        }

  
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Devoluciones();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            banderacontrol += 1;
            RealizarVenta();
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Min_Click_(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }


        private void txtCodigo_PreviewKeyDown(object sender, KeyEventArgs e)
        {
           
         
                if (e.Key == Key.Enter)
            {

                AgregarProductoVenta(txtCodigo.Text);
                txtCodigo.Clear();

            }
        }

        private void txtCodigo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }
        void Asistencia() {

            Mensaje.MensajeCaptura c = new Mensaje.MensajeCaptura("Asistencia", "Capture el codigo personal del cliente", "Registrar F1", "SALIR F2", true, "string");
            c.ShowDialog();


            if (c.valor3 != null)
            {
                CapaLogica.ClienteVenta cc = new CapaLogica.ClienteVenta();

                if (cc.buscarCliente(c.valor3.ToString(), "none", "co").Rows.GetEnumerator().MoveNext())
                {

                    Asistencia a = new Asistencia(c.valor3.ToString());
                    a.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }

            }
            else {

                MessageBox.Show("Capture el codigo");
            }
            txtCodigo.Focus();
        }

       

        void vincularmembresia() {
            MessageBox.Show("Para vender la membresia el cliente debe estar registrado.","NOTIFICACION");
            bander = false;
            try
            {
              
                VincularMembreciaxaml vc = new VincularMembreciaxaml();
                vc.ShowDialog();
               
                if (vc.codigo!=null)
                {
                    AgregarProducto(vc.codigo);
                }
            }
            catch (Exception e) {

                MessageBox.Show("Error "+e.ToString());
            }
            txtCodigo.Focus();
        }
        void salir()
        {
            if (dataGrid.Items.Count < 1)
            {
                Mensaje.Mesaje confir = new Mensaje.Mesaje("CERRANDO", "Desea salir?", "SI F1", "NO F2");
                confir.ShowDialog();
                if (confir.Si)
                {
                    this.Close();
                }
            }
            else {
                MessageBox.Show("LA App no se puede cerrar hasta que finalize o cancela la venta en proceso");
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            salir();
        }


        bool bander =true;
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
           

            if (bander)
            {

                vincularmembresia();
            }
            else {
                bander = true;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AgregarCantidadProducto();
        }
    }
}
