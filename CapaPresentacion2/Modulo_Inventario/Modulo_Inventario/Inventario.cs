using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;


namespace Modulo_Inventario
{
    public partial class Inventario : Form
    {
        DataView view;
        private DataTable dt = new DataTable();
        Producto p = new Producto();
        public string valor;

        public Inventario()
        {
            InitializeComponent();
            cargargridprincipal();
            cbidPromocio.GotFocus += CbidPromocio_GotFocus;
            CbMedida.GotFocus += CbMedida_GotFocus;
            CbFamilia.GotFocus += CbFamilia_GotFocus;
            cbProveedor.GotFocus += CbProveedor_GotFocus;
            cbMSeleccionePromo.GotFocus += CbMSeleccionePromo_GotFocus;
            cbMFamilia.GotFocus += CbMFamilia_GotFocus;
            cbMMedida.GotFocus += CbMMedida_GotFocus;
            cbMProvedor.GotFocus += CbMProvedor_GotFocus;
           
        }

        void cargargridprincipal() {

            dt = p.MostrartodoProducto();
            view = dt.DefaultView;
            dataGridView1.DataSource = view;
        }


        #region cargarconbox
        private void CbProveedor_GotFocus(object sender, EventArgs e)
        {
            idprovedorcargar();
        }

        private void CbFamilia_GotFocus(object sender, EventArgs e)
        {
            familiacargar();
        }

        private void CbMedida_GotFocus(object sender, EventArgs e)
        {
            cargarunidad();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            //TabControl_Inventario.Dock = DockStyle.Fill;
           
        }

      
        private void CbidPromocio_GotFocus(object sender, EventArgs e)
        {
            idpromocionescargar();
        }

        void idpromocionescargar() {

            cbidPromocio.DataSource = p.PromocionesQuery();
            cbidPromocio.ValueMember = "IdPromocion";
            cbidPromocio.DisplayMember = "Descripcion";
        }
        void idprovedorcargar() {

            cbProveedor.DataSource = p.Proveedor();
            cbProveedor.DisplayMember = "Marca";
            cbProveedor.ValueMember = "IdProvedor";
        }
        void familiacargar() {
            CbFamilia.DataSource = p.ConsultaFamilia();
            CbFamilia.DisplayMember = "Familia";
            CbFamilia.ValueMember = "IdFamilia";
        }
        void cargarunidad() {


            CbMedida.DataSource = p.ConsultaMedida();
            CbMedida.ValueMember = "IdUnidadMedida";
            CbMedida.DisplayMember = "Medida";
        }
        private void CbMedida_MouseClick(object sender, MouseEventArgs e)
        {
            cargarunidad();
        }

        private void CbFamilia_MouseClick(object sender, MouseEventArgs e)
        {
            familiacargar();
        }
        private void cbProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            idprovedorcargar(); 
        }
        private void cbidPromocio_MouseClick(object sender, MouseEventArgs e)
        {
            idpromocionescargar();
        }
        private void cbpromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbpromocion.SelectedItem.ToString() == "S")
            {
                cbidPromocio.Visible = true;
                lblselecpromo.Visible = true;
            }
            else
            {
                cbidPromocio.Visible = false;
                lblselecpromo.Visible = false;

            }
        }

        #endregion
        void Registrar()
        {
            bool f = false;
            try
            {
                if (validartxt())
                {
                    if (p.validarNombre(TxtNombre.Text)!=true)
                    {
                        if (p.TrueCodigoBarraRegistrado(TxtCodigoBarra.Text) != true)
                        {
                            p.Codigo = TxtCodigoBarra.Text;
                            p.Nombre = TxtNombre.Text;
                            p.Descripcion = TxtDescripcion.Text;
                            p.IdProveedor = Convert.ToInt32(cbProveedor.SelectedValue.ToString());
                            p.Stock = Convert.ToInt32(TxtStock.Text);
                            p.StockMin = Convert.ToInt32(TxtStockMin.Text);
                            p.Costo = Convert.ToDouble(TxtCosto.Text);
                            p.Precio = Convert.ToDouble(TxtprecioVenta.Text);
                            p.IVA = Convert.ToDouble(TxtIva.Text);
                            p.Promocion = cbpromocion.SelectedItem.ToString();
                            if (cbidPromocio.Visible)
                            {
                                p.IdPromocion = Convert.ToInt32(cbidPromocio.SelectedValue.ToString());
                            }
                            else
                            {
                                p.IdPromocion = null;
                            }
                          
                            p.PrecioMin = Convert.ToDouble(TxtprecioVenta.Text);
                            p.IdUnidad = Convert.ToInt32(CbMedida.SelectedValue.ToString());
                            p.IdFamilia = Convert.ToInt32(CbFamilia.SelectedValue.ToString());
                            p.Estatus = CbEstatus.SelectedText.ToString();
                            try
                            {
                               
                                p.FechaCaducidad = Convert.ToString(TxtFechaCaducidad.Text);
                                f = true;
                              
                            }
                            catch (Exception e) {
                                MessageBox.Show("Introdusca una fecha correcta","Mensaje");
                                TxtFechaCaducidad.Focus();
                                f = false;
                            }

                            if (f)
                            {
                                p.RegistrarProducto();
                                cargargridprincipal();
                                MessageBox.Show("Producto Registrado correctamente");
                                limpiar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El codigo de barra ya fue registrado intente con otro", "Mensaje");
                            TxtCodigoBarra.Focus();

                        }
                    }
                    else {
                        MessageBox.Show("EL NOMBRE de este producto ya existe", "Mensaje");
                        TxtNombre.Focus();
                    }
                }
                else {
                    MessageBox.Show("Para continuar Llene los campos requerido, los que se marcan con *", "Mensaje");
                }
            }
            catch (Exception e) {

                MessageBox.Show("Error consulte con su administrador error:" + e.ToString(), "Error");
            }

        }
        bool validartxt() {

            try
            {
                if (cbidPromocio.SelectedText != null)
                {
                    if (TxtCodigoBarra.Text != "")
                    {
                        if (TxtNombre.Text != "")
                        {
                            if (TxtDescripcion.Text != "")
                            {
                                if (TxtStock.Text != "")
                                {
                                    if (TxtStockMin.Text != "")
                                    {
                                        if (TxtCosto.Text != "")
                                        {
                                            if (TxtPrecioMin.Text != "")
                                            {
                                                if (TxtprecioVenta.Text != "")
                                                {
                                                    if (TxtIva.Text != "")
                                                    {
                                                        if (CbMedida.SelectedValue != null)
                                                        {
                                                            if (CbFamilia.SelectedValue != null)
                                                            {

                                                                if (cbpromocion.SelectedText != null)
                                                                {
                                                                    if (cbProveedor.SelectedValue != null)
                                                                    {
                                                                        if (CbEstatus.SelectedText != null)
                                                                        {
                                                                            if (TxtFechaCaducidad.Text != null)
                                                                            {
                                                                                return true;
                                                                            }

                                                                        }

                                                                    }

                                                                }
                                                            }

                                                        }

                                                    }
                                                    else
                                                    {
                                                        TxtIva.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    TxtprecioVenta.Focus();
                                                }
                                            }
                                            else
                                            {
                                                TxtPrecioMin.Focus();
                                            }
                                        }
                                        else
                                        {
                                            TxtCosto.Focus();
                                        }
                                    }
                                    else
                                    {
                                        TxtStockMin.Focus();
                                    }
                                }
                                else
                                {
                                    TxtStock.Focus();
                                }
                            }
                            else
                            {
                                TxtDescripcion.Focus();
                            }
                        }
                        else
                        {
                            TxtNombre.Focus();
                        }
                    }
                    else
                    {
                        TxtCodigoBarra.Focus();

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error consulte con su administrador error:" + e.ToString(), "Error");
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar();
        }

       
     

   





        #region txtboxvalidar
        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validardouble vl = new validardouble();
            e.Handled = vl.SoloNumeros(e, TxtCosto.Text);

        }

        private void TxtprecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validardouble vl = new validardouble();
            e.Handled = vl.SoloNumeros(e, TxtprecioVenta.Text);
        }

        private void TxtPrecioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validardouble vl = new validardouble();
           e.Handled= vl.SoloNumeros(e, TxtPrecioMin.Text);
        }

        private void TxtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            validardouble vl = new validardouble();
            e.Handled = vl.SoloNumeros(e, TxtIva.Text);
        }
        void limpiar() {
            TxtFechaCaducidad.Clear();
            TxtNombre.Clear();
            TxtCosto.Clear();
            TxtPrecioMin.Clear();
            TxtprecioVenta.Clear();
            TxtIva.Clear();
            TxtStock.Clear();
            TxtStockMin.Clear();
            TxtDescripcion.Clear();

            cbidPromocio.Visible = false;
            lblselecpromo.Visible = false;
            cbpromocion.DataSource = null;
            cbProveedor.DataSource = null;
            CbMedida.DataSource = null;
            CbFamilia.DataSource = null;
            TxtCodigoBarra.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
          

           
           
             
            
        }
        #endregion

        #region datagrid
        private void txt_buscar_empleado_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        void filtro()
        {



            if (comboBox3.SelectedItem.ToString() == "TODOS")
            {

                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                view.RowFilter = string.Empty;
                if (txt_buscar_empleado.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txt_buscar_empleado.Text + "%'";
                dataGridView1.DataSource = view;
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "ACTIVOS") {

              
                dt = p.MostrartodoProductoActivos("A");
                view = dt.DefaultView;
                dataGridView1.DataSource = view;
            }
            if (comboBox3.SelectedItem.ToString() == "TODOS")
            {
                dt = p.MostrartodoProducto();
                view = dt.DefaultView;
                dataGridView1.DataSource = view;
            }

            if (comboBox3.SelectedItem.ToString() == "INACTIVOS")
            {


                dt = p.MostrartodoProductoActivos("I");
                view = dt.DefaultView;
                dataGridView1.DataSource = view;
            }
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                
                valor = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
             
                    MessageBox.Show("se selecciono correctamente, PRODUCTO:"+valor);
                
            }
            catch (Exception ea) {
             
              

                
                
            }
        }
        #endregion


        /// <summary>
        /// ////////////////////////parte dos moficar
        /// </summary>
        void ModificarProducto() {
            if (valor!= null && valor.Length!=-1)
            {
                
                List<Producto> pp = new List<Producto>();
                ////AUxiliar 
           
                auxiliaridInventario aux = new auxiliaridInventario();
               
                List<auxiliaridInventario> ltaux = new List<auxiliaridInventario>();
           
                try
                {
                    ltaux = aux.ModificarObtenerProductoSelecgrid(valor);
                    //
                    pp = p.ModificarObtenerProductoSelecgrid(valor);
                    txtMPrecio.Text = pp[0].Precio.ToString();
                    txtMCosto.Text = pp[0].Costo.ToString();
                    txtMNombre.Text = pp[0].Nombre.ToString();
                    txtMPrecioMin.Text = pp[0].PrecioMin.ToString();
                    txtMIVA.Text = pp[0].IVA.ToString();
                    txtMStock.Text = pp[0].Stock.ToString();
                    txtMStockM.Text = pp[0].StockMin.ToString();
                    txtMDescrip.Text = pp[0].Descripcion.ToString();
                    txtMFechacad.Text = pp[0].FechaCaducidad.ToString();
                    txtMCodigo.Text = pp[0].Codigo.ToString();

                    cbMCuentaPromo.SelectedItem = pp[0].Promocion.ToString();
                    // cbMCuentaPromo.SelectedItem = pp[0].Promocion.ToString();

                    ///primera vez
                    cbMMedida.Items.Add(ltaux[0].medida.ToString());
                    cbMMedida.SelectedIndex = 0;
                    medida = pp[0].IdUnidad.ToString();
                    cbMEstatus.SelectedItem = pp[0].Estatus.ToString();
                    if (pp[0].Promocion == "S")
                    {
                        cbMSeleccionePromo.Items.Add(ltaux[0].promocion.ToString());
                        cbMSeleccionePromo.SelectedIndex = 0;
                        idpromo = pp[0].IdPromocion.ToString();
                        label8.Visible = true;
                        cbMSeleccionePromo.Visible = true;
                    }
                    else
                    {


                    }

                    cbMFamilia.Items.Add(ltaux[0].familia.ToString());
                    cbMFamilia.SelectedIndex = 0;
                    familia = pp[0].IdFamilia.ToString();

                    cbMProvedor.Items.Add(ltaux[0].proveedor.ToString());
                    cbMProvedor.SelectedIndex = 0;
                    prove = pp[0].IdProveedor.ToString();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Error consulte con su administrador:" + e.ToString() + "Error al seleccionar en el grid");
                }
            }
            else {

                MessageBox.Show("Seleccione un producto para continuar", "mensaje");
            }


            /////

         



        }

        private void button6_Click(object sender, EventArgs e)
        {
           

            ModificarProducto();
            tabcontrolproductonuevo.SelectedTab = tabcontrolmodificarprod;
        }
        #region cargarcombox
        private void cbMCuentaPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMCuentaPromo.SelectedItem.ToString() == "S")
            {
                cbMSeleccionePromo.Visible = true;
                cbMSeleccionePromo.Visible = true;
            }
            else
            {
                cbMSeleccionePromo.Visible = false;
                cbMSeleccionePromo.Visible = false;

            }
        }
        void cargarmSelecpromo() {

            cbMSeleccionePromo.DataSource = p.PromocionesQuery();
            cbMSeleccionePromo.ValueMember = "IdPromocion";
            cbMSeleccionePromo.DisplayMember = "Descripcion";
        }
        void cargarMprove() {

            cbMProvedor.DataSource = p.Proveedor();
            cbMProvedor.DisplayMember = "Marca";
            cbMProvedor.ValueMember = "IdProvedor";
        }

        void cargarMMedida() {
            cbMMedida.DataSource = p.ConsultaMedida();
            cbMMedida.ValueMember = "IdUnidadMedida";
            cbMMedida.DisplayMember = "Medida";
        }
        void cargarMFamilia() {

            cbMFamilia.DataSource = p.ConsultaFamilia();
            cbMFamilia.DisplayMember = "Familia";
            cbMFamilia.ValueMember = "IdFamilia";
        }
        private void cbMSeleccionePromo_MouseClick(object sender, MouseEventArgs e)
        {
            cargarmSelecpromo();
        }

        private void cbMProvedor_MouseClick(object sender, MouseEventArgs e)
        {
            cargarMprove();
        }

        private void cbMMedida_MouseClick(object sender, MouseEventArgs e)
        {
            cargarMMedida();
        }

        private void cbMFamilia_MouseClick(object sender, MouseEventArgs e)
        {
            cargarMFamilia();
           
        }
        private void CbMProvedor_GotFocus(object sender, EventArgs e)
        {
            cargarMprove();
        }

        private void CbMSeleccionePromo_GotFocus(object sender, EventArgs e)
        {
            cargarmSelecpromo();
        }

        private void CbMMedida_GotFocus(object sender, EventArgs e)
        {
            cargarMMedida();
        }

        private void CbMFamilia_GotFocus(object sender, EventArgs e)
        {
            cargarMFamilia();
        }

        #endregion



        #region validartextbox
        private void txtMCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validardouble vl = new validardouble();
            e.Handled = vl.SoloNumeros(e, txtMCosto.Text);
        }

        private void txtMPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validardouble vl = new validardouble();
            e.Handled = vl.SoloNumeros(e, txtMPrecio.Text);
        }

        private void txtMPrecioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validardouble vl = new validardouble();
            e.Handled = vl.SoloNumeros(e,txtMPrecioMin.Text);
        }

        private void txtMIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validardouble vl = new validardouble();
            e.Handled = vl.SoloNumeros(e, txtMIVA.Text);
        }

        private void TxtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        public void SoloNumeros(KeyPressEventArgs e)
        {

            int ascci = Convert.ToInt32(Convert.ToChar(e.KeyChar));
            //verificamos que se encuentre en ese rango que son entre el 0 y el 9 


            if ((ascci >= 48 && ascci <= 57) || ascci == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void TxtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtMStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtMStockM_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtMCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        #endregion
        string familia, medida, idpromo, prove;



        void limpiarmodifica() {

            txtMNombre.Clear();
            txtMCodigo.Clear();
            txtMCosto.Clear();
            txtMPrecio.Clear();
            txtMIVA.Clear();
            txtMStock.Clear();
            txtMStockM.Clear();
            txtMPrecioMin.Clear();
            txtMDescrip.Clear();
            cbMSeleccionePromo.DataSource = null;
            cbMMedida.DataSource = null;
            cbMFamilia.DataSource = null;
            cbMProvedor.DataSource = null;
            txtMFechacad.Clear();

        }

        private void btn_retorno3_Click(object sender, EventArgs e)
        {
          
            mensajes.mensajeConfirmacion mc = new mensajes.mensajeConfirmacion("Sepedera los datos capturador si continua. Desea continuar al menu principal?","SI F1","NO F2","");
            mc.ShowDialog();
            if (mc.valor) {
                limpiar();
                tabcontrolproductonuevo.SelectedTab = tabeprincipal;
              
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mensajes.mensajeConfirmacion mc = new mensajes.mensajeConfirmacion("Sepedera los datos capturador si continua. Desea continuar al menu principal?", "SI F1", "NO F2", "");
            mc.ShowDialog();
            if (mc.valor)
            {
                tabcontrolproductonuevo.SelectedTab = tabeprincipal;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabcontrolproductonuevo.SelectedTab = TabNuevo_prod;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        string imagen;
        void seleccionarimagen() {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                    pictureBox1.Refresh();
                }
            }
            catch (Exception e) {
                MessageBox.Show("Error al cargar la imagen");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            seleccionarimagen();

        }

        private void TxtCodigoBarra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        void altabaja() {

            if (valor!=null)
            {
                mensajes.AltaBaja al = new mensajes.AltaBaja(valor);
                al.ShowDialog();
                cargargridprincipal();
                
            }
            else
            {
                MessageBox.Show("Seleccione un producto  para continuar");
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            altabaja();
           
        }

        private void Inventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabcontrolproductonuevo.SelectedTab == tabeprincipal) {
                if ((int)e.KeyChar == (int)Keys.F1)
                {
                    tabcontrolproductonuevo.SelectedTab = TabNuevo_prod;

                }
                if ((int)e.KeyChar == (int)Keys.F2)
                {
                    altabaja();

                }
                if ((int)e.KeyChar == (int)Keys.F3)
                {
                    ModificarProducto();
                    tabcontrolproductonuevo.SelectedTab = tabcontrolmodificarprod;
                }
                if ((int)e.KeyChar == (int)Keys.F4)
                {
                    mensajes.AgregarStock addStock = new mensajes.AgregarStock();
                    addStock.ShowDialog();
                }
            }
            else if (tabcontrolproductonuevo.SelectedTab == TabNuevo_prod)
            {
                if ((int)e.KeyChar == (int)Keys.F1)
                {
                    Registrar();

                }
                if ((int)e.KeyChar == (int)Keys.F2)
                {
                    limpiar();
                }
                if ((int)e.KeyChar == (int)Keys.F3)
                {
                 
                }
                
            }
            else   if (tabcontrolproductonuevo.SelectedTab ==tabcontrolmodificarprod )
            {
                if ((int)e.KeyChar == (int)Keys.F1)
                {
                    modificar();

                }
                if ((int)e.KeyChar == (int)Keys.F2)
                {
                    
                }
                if ((int)e.KeyChar == (int)Keys.F3)
                {

                }

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            modificar();
          
        }
        void modificar() {
            if (txtMNombre.Text != "" && txtMPrecio.Text != "" && txtMPrecioMin.Text != "" && txtMCosto.Text != "" && txtMIVA.Text != "" && txtMStock.Text != "" && TxtStockMin.Text != "" && TxtDescripcion.Text != "" && txtMFechacad.Text != "" && txtMCodigo.Text != "" && cbMCuentaPromo.SelectedItem != null && cbMSeleccionePromo.SelectedItem != null && cbMMedida.SelectedItem != null && cbMFamilia.SelectedItem != null && cbMProvedor.SelectedItem != null && cbMEstatus.SelectedItem != null)
            {
                mensajes.mensajeConfirmacion mc = new mensajes.mensajeConfirmacion("Desea Guardar los cambios?", "Si F1", "No F2", "");
                mc.ShowDialog();
                if (mc.valor)
                {

                    try

                    {
                        string codigo = txtMCodigo.Text;

                        p.inventarioModificarProducto(Convert.ToInt32(codigo), txtMNombre.Text.ToString(), txtMDescrip.Text.ToString(), prove, txtMStock.Text.ToString(), txtMStockM.Text.ToString(), txtMCosto.Text.ToString(), txtMPrecio.Text.ToString(), txtMIVA.Text.ToString(), cbMCuentaPromo.SelectedItem.ToString(), idpromo, txtMPrecioMin.Text.ToString(), medida, familia, cbMEstatus.SelectedItem.ToString(), txtMFechacad.Text.ToString());
                        limpiarmodifica();
                        cargargridprincipal();
                        MessageBox.Show("Cambios Realizados correctamente");
                        tabcontrolproductonuevo.SelectedTab = tabeprincipal;


                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("error consulte con su administrador:" + ee.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Capture todos los campo  marcados con * para continuar.");


            }
        }

       
        private void button12_Click(object sender, EventArgs e)
        {
            mensajes.AgregarStock addStock = new mensajes.AgregarStock();
            addStock.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
