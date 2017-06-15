using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMBLEMA;
using CapaLogica;
using ProyectoP;
using Modulo_Empleados.CLIENTES;
using System.Text.RegularExpressions;

namespace Modulo_Clientes
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        //Variales globales
        CapaLogica.Cliente C = new CapaLogica.Cliente();
        CapaLogica.Membresia M = new CapaLogica.Membresia();
        CapaLogica.MembresiaFull RM = new CapaLogica.MembresiaFull();

        int Id;
        int opcion_m=0;
        string Nombre_TMembresia;

        private void TabPuesto_Lista_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            TabControl_Clientes.Dock = DockStyle.Fill;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ClienteEntradaRegistrar(0);
        }

        private void ClienteEntradaRegistrar(int opc)
        {
            opcion_m = opc;
            txt_nombre_c.Text = "";
            txt_apm_c.Text = "";
            txt_app_c.Text = "";
            txt_calle_c.Text = "";
            txt_colonia_c.Text = "";
            txt_email_c.Text = "";
            txt_telefono_c.Text = "";
            txt_num_c.Text = "";
            cb_ent_c.Text = "";
            cb_mun_c.Text = "";
            cb_city_c.Text = "";
            cb_ent_c.DisplayMember = "Nombre";
            txt_nombre_c.Focus();
            txt_codigoinvitado_c.Visible = true;
            label17.Visible = true;
            cb_ent_c.DataSource = C.ClienteBuscarEntidad();
            TabControl_Clientes.SelectedTab = TabClientes_Registro;
        }

        private void cb_ent_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_mun_c.DisplayMember = "Nombre";
            cb_mun_c.DataSource = C.ClienteBuscarMunicipio(cb_ent_c.Text);
            cb_city_c.Text = "";
            cb_city_c.DisplayMember = "Nombre";
            cb_city_c.DataSource = C.ClienteBuscarCiudad(cb_ent_c.Text, cb_mun_c.Text);
        }

        private void cb_mun_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_city_c.DisplayMember = "Nombre";
            cb_city_c.DataSource = C.ClienteBuscarCiudad(cb_ent_c.Text, cb_mun_c.Text);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ClienteEntradaModificar(1);
        }

        public void ClienteEntradaModificar(int opc)
        {
            if (dgv_c.SelectedRows.Count == 1) 
            {
                opcion_m = opc;
                //Obtengo todos los datos de el cliente en una  tabla
                C.IdCliente = Convert.ToInt32(dgv_c.CurrentRow.Cells[0].Value);
                DataRow row = C.ClienteBuscarDatos(C.IdCliente).Rows[0]; //La variable --row-- recive una tabla con todos los datos del cliente a modificar

                //Relleno todos los datos del formulario con los datos de la tabla obtenida
                lbl_titulo_principal_c.Text = "ACTUALIZAR LOS DATOS DEL CLIENTE";
                btn_registrar_c.Text = "GUARDAR CAMBIOS(F1)";
                Id = Convert.ToInt32(row["IdCliente"].ToString());
                cb_ent_c.DisplayMember = "Nombre";
                cb_ent_c.DataSource = C.ClienteBuscarEntidad();
                cb_mun_c.DisplayMember = "Nombre";
                cb_mun_c.DataSource = C.ClienteBuscarMunicipio("Aguascalientes");
                cb_city_c.DisplayMember = "Nombre";
                cb_city_c.DataSource = C.ClienteBuscarCiudad("Aguascalientes", "Aguascalientes");
                txt_nombre_c.Text = row["Nombre"].ToString();
                txt_app_c.Text = row["App"].ToString();
                txt_apm_c.Text = row["Apm"].ToString();
                txt_calle_c.Text = row["Calle"].ToString();
                txt_colonia_c.Text = row["Colonia"].ToString();
                txt_num_c.Text = row["Num_ext"].ToString();
                cb_ent_c.Text = row["NomEnt"].ToString();
                cb_mun_c.Text = row["NomMun"].ToString();
                cb_city_c.Text = row["NomCiudad"].ToString();
                txt_telefono_c.Text = row["Telefono"].ToString();
                txt_email_c.Text = row["email"].ToString();
                txt_codigoinvitado_c.Visible = false;
                label17.Visible = false;
                TabControl_Clientes.SelectedTab = TabClientes_Registro; //Cambio de Tab
            }
            else
                MessageBox.Show("Debe seleccionar al menos un empleado para modificar sus datos.");
        }

        public void ValidarCaracteres(int Control, int Digit, int Letter, int Punto, int Separator, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) && Control == 1)
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar) && Digit == 1)
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar) && Letter == 1)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46 && Punto == 1)
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar) && Separator == 1)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_registrar_c_Click(object sender, EventArgs e)
        {
            ClienteRegMod();
        }

        public void ClienteRegMod()
        {
            Regex Val = new Regex(@"^[a-z]+[a-z0-9]*@+[a-z0-9]+[a-z0-9]*[\.][a-z0-9]+$");
            if (txt_nombre_c.Text != "")
            {
                if (txt_app_c.Text != "")
                {
                    if (txt_calle_c.Text != "")
                    {
                        if (txt_num_c.Text != "")
                        {
                            if (txt_colonia_c.Text != "")
                            {
                                if (cb_ent_c.Text != "")
                                {
                                    if (cb_mun_c.Text != "")
                                    {
                                        if (cb_city_c.Text != "")
                                        {
                                            if (txt_email_c.Text != "")
                                            {
                                                if (Val.IsMatch(txt_email_c.Text))
                                                {
                                                    try
                                                    {
                                                        string codigo_inv;
                                                        if (txt_codigoinvitado_c.Text != "")
                                                        {
                                                            if ((txt_codigoinvitado_c.Text.Length) == 5)
                                                            {
                                                                codigo_inv = (txt_codigoinvitado_c.Text);
                                                                C.ClienteRegistrar(txt_nombre_c.Text.Trim(), txt_app_c.Text.Trim(), txt_apm_c.Text.Trim(), "aqui se envia la foto", txt_email_c.Text.Trim(), "", codigo_inv, txt_telefono_c.Text.Trim(), 0, cb_mun_c.Text, cb_ent_c.Text, cb_city_c.Text, txt_calle_c.Text.Trim(), txt_colonia_c.Text.Trim(), txt_num_c.Text.Trim());
                                                                MessageBox.Show("Cliente Registrado correctamente");
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("El codigo de invitado no cumple con la longitud esperada");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (opcion_m == 0)
                                                            {
                                                                C.ClienteRegistrar(txt_nombre_c.Text.Trim(), txt_app_c.Text.Trim(), txt_apm_c.Text.Trim(), "aqui se envia la foto", txt_email_c.Text.Trim(), "", "", txt_telefono_c.Text.Trim(), 0, cb_mun_c.Text, cb_ent_c.Text, cb_city_c.Text, txt_calle_c.Text.Trim(), txt_colonia_c.Text.Trim(), txt_num_c.Text.Trim());
                                                                MessageBox.Show("Cliente Registrado correctamente");
                                                            }
                                                            else
                                                            {
                                                                C.ClienteModificar(C.IdCliente, txt_nombre_c.Text.Trim(), txt_app_c.Text.Trim(), txt_apm_c.Text.Trim(), "aqui se envia la foto", txt_email_c.Text.Trim(), "", "", txt_telefono_c.Text.Trim(), 0, cb_mun_c.Text, cb_ent_c.Text, cb_city_c.Text, txt_calle_c.Text.Trim(), txt_colonia_c.Text.Trim(), txt_num_c.Text.Trim());
                                                                MessageBox.Show("Cliente Modificado correctamente");
                                                            }
                                                        }


                                                        TabControl_Clientes.SelectedTab = TabClientes_Lista;
                                                        dgv_c.DataSource = C.ClienteBuscar();
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        MessageBox.Show("Ocurrio un error al Registrar.");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("El email ingresado no es valido intentelo de nuevo");
                                                }
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    string codigo_inv;
                                                    if (txt_codigoinvitado_c.Text != "")
                                                    {
                                                        if ((txt_codigoinvitado_c.Text.Length) == 5)
                                                        {
                                                            codigo_inv = (txt_codigoinvitado_c.Text);
                                                            C.ClienteRegistrar(txt_nombre_c.Text.Trim(), txt_app_c.Text.Trim(), txt_apm_c.Text.Trim(), "aqui se envia la foto", txt_email_c.Text.Trim(), "", codigo_inv, txt_telefono_c.Text.Trim(), 0, cb_mun_c.Text, cb_ent_c.Text, cb_city_c.Text, txt_calle_c.Text.Trim(), txt_colonia_c.Text.Trim(), txt_num_c.Text.Trim());
                                                            MessageBox.Show("Cliente Registrado correctamente");
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("El codigo de invitado no cumple con la longitud esperada");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (opcion_m == 0)
                                                        {
                                                            C.ClienteRegistrar(txt_nombre_c.Text.Trim(), txt_app_c.Text.Trim(), txt_apm_c.Text.Trim(), "aqui se envia la foto", txt_email_c.Text.Trim(), "", "", txt_telefono_c.Text.Trim(), 0, cb_mun_c.Text, cb_ent_c.Text, cb_city_c.Text, txt_calle_c.Text.Trim(), txt_colonia_c.Text.Trim(), txt_num_c.Text.Trim());
                                                            MessageBox.Show("Cliente Registrado correctamente");
                                                        }
                                                        else
                                                        {
                                                            C.ClienteModificar(C.IdCliente, txt_nombre_c.Text.Trim(), txt_app_c.Text.Trim(), txt_apm_c.Text.Trim(), "aqui se envia la foto", txt_email_c.Text.Trim(), "", "", txt_telefono_c.Text.Trim(), 0, cb_mun_c.Text, cb_ent_c.Text, cb_city_c.Text, txt_calle_c.Text.Trim(), txt_colonia_c.Text.Trim(), txt_num_c.Text.Trim());
                                                            MessageBox.Show("Cliente Modificado correctamente");
                                                        }
                                                    }


                                                    TabControl_Clientes.SelectedTab = TabClientes_Lista;
                                                    dgv_c.DataSource = C.ClienteBuscar();
                                                }
                                                catch (Exception e)
                                                {
                                                    MessageBox.Show("Ocurrio un error al Registrar.");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe seleccionar la ciudad del cliente para continuar.");
                                            cb_city_c.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar el municipio del cliente para continuar.");
                                        cb_mun_c.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe seleccionar el estado federativo del cliente para continuar.");
                                    cb_ent_c.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar la colonia del domicilio del cliente para continuar.");
                                txt_colonia_c.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar el numero exterior del domicilio del cliente para continuar.");
                            txt_num_c.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar la calle del domicilio del cliente para continuar.");
                        txt_calle_c.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el primer apellido del cliente para continuar.");
                    txt_app_c.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el o los nombres del cliente para continuar.");
                txt_nombre_c.Focus();
            }
        }

        //Validar caracteres 1 para permitir 0 para negar, orden: Tecla de control, Letra, Digito, Punto, Espacio
        private void txt_nombre_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_app_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_apm_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_calle_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 1, 1, 1, e);
        }

        private void txt_colonia_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 1, 1, 1, e);
        }

        private void txt_num_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 1, 0, 1, e);
        }

        private void cb_ent_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0, 0, 0, 0, 0, e);
        }

        private void cb_mun_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0, 0, 0, 0, 0, e);
        }

        private void cb_city_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0, 0, 0, 0, 0, e);
        }

        private void txt_telefono_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 0, 0, 0, e);
        }

        private void txt_email_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 1, 1, 1, e);
        }

        private void TabControl_Clientes_KeyUp(object sender, KeyEventArgs e)
        {

            if (TabControl_Clientes.SelectedTab == TabClientes_Lista)
            {
                if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)))
                {
                    ClienteEntradaRegistrar(0);
                }
                else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)))
                {
                    ClienteEntradaModificar(1);
                }
                else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F3)))
                {
                    CambiarAsistencias();
                }
                else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F4)))
                {
                    CambiarMembresias();
                }
            }
            else if (TabControl_Clientes.SelectedTab == TabClientes_Registro)
            {
                if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)))
                {
                    ClienteRegMod();
                }
            }
            else if (TabControl_Clientes.SelectedTab == TabMembre_Nueva)
            {
                if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)))
                {
                    MembresiaAddMod();
                }
            }
            else if (TabControl_Clientes.SelectedTab == TabMembre_Lista)
            {
                if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)))
                {
                    MembresiaEntradaAddMod(0);
                } else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)))
                {
                    MembresiaEntradaAddMod(1);
                }
                else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F3)))
                {
                    TipoMembresia_Alta();
                }
                else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F5)))
                {
                    CambiarClientes();
                }
            }
            else if (TabControl_Clientes.SelectedTab == TabMembre_Todo)
            {
                if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)))
                {
                    
                }
                else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)))
                {
                    
                }
                else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F5)))
                {
                    CambiarTipoMembresias();
                }
                else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F6)))
                {
                    CambiarClientes();
                }
            }
        }

        private void btn_membresias_Click(object sender, EventArgs e)
        {
            CambiarMembresias();
        }

        public void CambiarTipoMembresias()
        {
            TabControl_Clientes.SelectedTab = TabMembre_Lista;
            dgv_m.DataSource = M.MembresiaBuscar();
        }
        public void CambiarMembresias()
        {
            TabControl_Clientes.SelectedTab = TabMembre_Todo;
            dgv_rm.DataSource = RM.RMembresiaBuscar();
        }

        public void CambiarAsistencias()
        {
            TabControl_Clientes.SelectedTab = TabClientes_Asistencias;
            dgv_a.DataSource = C.AsistenciasBuscar();
        }

        public void CambiarClientes()
        {
            TabControl_Clientes.SelectedTab = TabClientes_Lista;
            dgv_c.DataSource = C.ClienteBuscar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,0,1,0,1,e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,0,1,0,e);
        }

        private void txt_descripcion_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,1,1,1,e);
        }

        private void txt_buscar_membresia_TextChanged(object sender, EventArgs e)
        {
            dgv_m.DataSource = M.MembresiaBuscarNombre(txt_buscar_membresia.Text);
        }

        private void txt_buscar_empleado_TextChanged(object sender, EventArgs e)
        {
            dgv_c.DataSource = C.ClienteBuscarNombre(txt_buscar_empleado.Text);
        }

        private void btn_nueva_m_Click(object sender, EventArgs e)
        {
            MembresiaEntradaAddMod(0);
        }

        private void btn_mod_m_Click(object sender, EventArgs e)
        {
            MembresiaEntradaAddMod(1);
        }

        public void MembresiaEntradaAddMod(int opc)
        {
            opcion_m = opc;

            if (opcion_m == 0)
            {
                txt_nombre_m.Text = "";
                txt_precio_m.Text = "";
                txt_descripcion_m.Text = "";
                txt_duracion.Text = "";
                lbl_titulo_m.Text = "CREAR NUEVO TIPO DE MEMBRESIA";
                btn_regmod_m.Text = "REGISTRAR (F1)";
            }
            else
            {
                M.IdMembresia = Convert.ToInt32(dgv_m.CurrentRow.Cells[0].Value);
                DataRow row = M.MembresiaBuscarDatos(M.IdMembresia).Rows[0];

                lbl_titulo_m.Text = "MODIFICAR DATOS DE TIPO MEMBRESIA";
                btn_regmod_m.Text = "GUARDAR CAMBIOS (F1)";

                txt_nombre_m.Text = row["Nombre"].ToString();
                txt_precio_m.Text = row["Precio"].ToString();
                txt_descripcion_m.Text = row["Descripcion"].ToString();
                txt_duracion.Text = row["Duracion"].ToString();

            }

            TabControl_Clientes.SelectedTab = TabMembre_Nueva;
        }

        public void MembresiaAddMod ()
        {
            if (txt_nombre_m.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el tipo de membresia");
                txt_nombre_m.Focus();
            }
            else if (txt_precio_m.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio para el tipo de membresia");
                txt_precio_m.Focus();
            }
            else if (txt_descripcion_m.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion para el tipo de membresia");
                txt_descripcion_m.Focus();
            }
            else if (txt_duracion.Text == "")
            {
                MessageBox.Show("Debe ingresar una duración para el tipo de membresia");
                txt_duracion.Focus();
            }
            else
            {
                if (opcion_m == 0)
                {
                    M.MembresiaRegistrar(txt_nombre_m.Text.Trim(),txt_precio_m.Text.Trim(),txt_duracion.Text.Trim(),txt_descripcion_m.Text.Trim());
                    MessageBox.Show("Tipo de membresia registrado correctamente");
                }
                else
                {
                    M.MembresiaModificar(M.IdMembresia, txt_nombre_m.Text.Trim(), txt_precio_m.Text.Trim(), txt_duracion.Text.Trim(), txt_descripcion_m.Text.Trim());
                    MessageBox.Show("Datos modificados correctamente");                    
                }
                TabControl_Clientes.SelectedTab = TabMembre_Lista;
                dgv_m.DataSource = M.MembresiaBuscar();
                cb_filtro_m.Text = "TODOS";
            }
        }

        private void btn_regmod_m_Click(object sender, EventArgs e)
        {
            MembresiaAddMod();
        }

        private void btn_cambiar_c_Click(object sender, EventArgs e)
        {
            CambiarMembresias();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambiarTipoMembresias();
        }

        private void btn_cambiar_foto_c_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pb_foto_cliente.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void txt_codigoinvitado_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,0,0,0,e);
        }

        private void btn_retorno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Clientes.SelectedTab = TabClientes_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void btn_retorno3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Clientes.SelectedTab = TabMembre_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void cb_filtro_m_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_filtro_m.SelectedIndex == 0)
            {
                dgv_m.DataSource = M.MembresiaBuscar();
            }
            else if (cb_filtro_m.SelectedIndex == 1)
            {
                dgv_m.DataSource = M.MembresiaBuscarActiva();
            }else if (cb_filtro_m.SelectedIndex == 2)
            {
                dgv_m.DataSource = M.MembresiaBuscarInactiva();
            }
        }

        private void btn_retorno4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Clientes.SelectedTab = TabMembre_Todo;
            }
            else if (result == DialogResult.No) { }
        }

        private void cb_lista_m_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_lista_m.SelectedIndex == 0)
            {
                dgv_rm.DataSource = RM.RMembresiaBuscar();
            }
            else if (cb_lista_m.SelectedIndex == 1)
            {
                dgv_rm.DataSource = RM.RMembresiaBuscarActiva();
            }
            else if (cb_lista_m.SelectedIndex == 2)
            {
                dgv_rm.DataSource = RM.RMembresiaBuscarInactiva();
            }
        }

        private void txt_duracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,0,0,0,e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CambiarClientes();
        }

        private void txt_buscar_rm_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,0,1,0,1,e);
        }

        private void btn_alta_m_Click(object sender, EventArgs e)
        {
            TipoMembresia_Alta();
        }
        public void TipoMembresia_Alta()
        {
            if (dgv_m.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_m.CurrentRow.Cells[4].Value) == "I")
                {
                    Datos_Membresia DM = new Datos_Membresia(); //Creo el formulario
                    DM.lbl_accion.Text = "Confimar ALTA de tipo de membresia."; //Asigno valores a los valores del formulario
                    DM.lbl_nombre.Text = Convert.ToString(dgv_m.CurrentRow.Cells[1].Value);
                    DM.lbl_precio.Text = Convert.ToString(dgv_m.CurrentRow.Cells[2].Value);
                    DM.lbl_duracion.Text = Convert.ToString(dgv_m.CurrentRow.Cells[5].Value);
                    DM.lbl_descripcion.Text = Convert.ToString(dgv_m.CurrentRow.Cells[3].Value);
                    DM.ShowDialog();
                    if (DM.respuesta == 1)
                    {
                        M.MembresiaAlta(Convert.ToInt32(dgv_m.CurrentRow.Cells[0].Value));
                        dgv_m.DataSource = M.MembresiaBuscar();
                        cb_filtro_m.Text = "TODOS";
                        MessageBox.Show("Tipo de Membresia dada de ALTA exitosamente.");
                    }
                    else
                        MessageBox.Show("Accion CANCELADA.");
                }
                else
                    MessageBox.Show("Debe seleccionar un tipo de membresia INACTIVO para darlo de alta.");
            }
            else
                MessageBox.Show("Debe seleccionar un solo tipo de membresia para darlo de alta.");
        }

        private void btn_baja_m_Click(object sender, EventArgs e)
        {
            TipoMembresia_Baja();
        }

        public void TipoMembresia_Baja()
        {
            if (dgv_m.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_m.CurrentRow.Cells[4].Value) == "A")
                {
                    Datos_Membresia DM = new Datos_Membresia(); //Creo el formulario
                    DM.lbl_accion.Text = "Confimar Baja de tipo de membresia."; //Asigno valores a los valores del formulario
                    DM.lbl_nombre.Text = Convert.ToString(dgv_m.CurrentRow.Cells[1].Value);
                    DM.lbl_precio.Text = Convert.ToString(dgv_m.CurrentRow.Cells[2].Value);
                    DM.lbl_duracion.Text = Convert.ToString(dgv_m.CurrentRow.Cells[5].Value);
                    DM.lbl_descripcion.Text = Convert.ToString(dgv_m.CurrentRow.Cells[3].Value);
                    DM.ShowDialog();
                    if (DM.respuesta == 1)
                    {
                        M.MembresiaBaja(Convert.ToInt32(dgv_m.CurrentRow.Cells[0].Value));
                        dgv_m.DataSource = M.MembresiaBuscar();
                        cb_filtro_m.Text = "TODOS";
                        MessageBox.Show("Tipo de Membresia dada de BAJA exitosamente.");
                    }
                    else
                        MessageBox.Show("Accion CANCELADA.");
                }
                else
                    MessageBox.Show("Debe seleccionar un tipo de membresia ACTIVO para darlo de baja.");
            }
            else
                MessageBox.Show("Debe seleccionar un solo tipo de membresia para dar de baja.");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Clientes.SelectedTab = TabClientes_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void oval_Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Clientes.SelectedTab = TabMembre_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void oval_Button2_Click(object sender, EventArgs e)
        {

        }

        private void oval_Button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?", "Regresar a Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Clientes.SelectedTab = TabClientes_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?", "Regresar a Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Clientes.SelectedTab = TabClientes_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CambiarAsistencias();
        }

        private void txt_nombre_m_TextChanged(object sender, EventArgs e)
        {
            TipoMBuscarNombre();
        }

        public void TipoMBuscarNombre()
        {
            if (lbl_msg_p2.Text !="")
            {
                if (M.MembresiaBuscarCoincidenciaNombre(txt_nombre_m.Text) >= 1)
                {
                    lbl_msg_p2.ForeColor = Color.DarkRed;
                    lbl_msg_p2.Text = "Nombre de puesto NO disponible";
                }
                else
                {
                    lbl_msg_p2.ForeColor = Color.DarkGreen;
                    lbl_msg_p2.Text = "Nombre de puesto disponible";
                }
            }
            else
            {
                lbl_msg_p2.ForeColor = Color.DarkRed;
                lbl_msg_p2.Text = "Introduzca un nombre";
            }
        }

        private void txt_buscar_a_TextChanged(object sender, EventArgs e)
        {
            dgv_a.DataSource = C.AsistenciasBuscarNombre(txt_buscar_a.Text);
        }
    }
}
