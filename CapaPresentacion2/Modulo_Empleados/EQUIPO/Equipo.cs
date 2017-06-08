using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Equipo
{
    public partial class Modulo_Equipo : Form
    {
        public Modulo_Equipo()
        {
            InitializeComponent();
        }
        CapaLogica.Clasificacion C = new CapaLogica.Clasificacion();
        CapaLogica.Equipo Eq = new CapaLogica.Equipo();
        string[] DatosEq = new string[5];
        string[] DatosC = new string[2];
        string Nom_clas = "";
        string Nom_equipo = "";
        public int IdUsuario = 1;

        private void Modulo_Equipo_Load(object sender, EventArgs e)
        {
            TabControl_Equipo.Dock = DockStyle.Fill;
        }

        private void btn_clasif_Click(object sender, EventArgs e)
        {
            TabControl_Equipo.SelectedTab = TabEquipo_Clas_Lista;
            dgv_c.DataSource = C.ClasificacionBuscar();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            TabControl_Equipo.SelectedTab = TabEquipo_Reportes;
            dgv_r.DataSource = Eq.EquipoEstadoBuscar();
        }

        private void btn_retorno4_Click(object sender, EventArgs e)
        {
            TabControl_Equipo.SelectedTab = TabEquipo_Lista;
            cb_clasificacion.DisplayMember = "Nombre";
            cb_clasificacion.DataSource = Eq.EquipoBuscarClasificaciones();
        }

        private void TabEquipo_Lista_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Equipo.SelectedTab = TabEquipo_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void btn_reg_c_Click(object sender, EventArgs e)
        {
            ClasificacionEntradaRegistro();
        }
        
        private void txt_buscar_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,0,1,0,1,e);
        }

        private void txt_buscar_c_TextChanged(object sender, EventArgs e)
        {
            dgv_c.DataSource = C.ClasificacionBuscarNombre(txt_buscar_c.Text);
        }

        private void btn_baja_c_Click(object sender, EventArgs e)
        {
            ClasificacionEliminar();
        }

        private void txt_nom_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_desc_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 1, 1, 1, e);
        }

        private void btn_accion_c_Click(object sender, EventArgs e)
        {
            ClasificacionRegMod();
        }

        private void btn_mod_c_Click(object sender, EventArgs e)
        {
            ClasificacionEntradaModificacion();
        }

        private void btn_cancelar1_r_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Equipo.SelectedTab = TabEquipo_Reportes;
            }
            else if (result == DialogResult.No) { }
        }

        private void btn_cancelar1_c_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Equipo.SelectedTab = TabEquipo_Clas_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void cb_estatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_estatus.Text == "TODOS")
            {
                dgv_e.DataSource = Eq.EquipoBuscar();
            }
            else if (cb_estatus.Text == "ACTIVOS")
            {
                dgv_e.DataSource = Eq.EquipoBuscarEstatus("A");
            }
            else
            {
                dgv_e.DataSource = Eq.EquipoBuscarEstatus("I");
            }
        }

        private void btn_baja_e_Click(object sender, EventArgs e)
        {
            EquipoBaja();
        }

        private void btn_reg_e_Click(object sender, EventArgs e)
        {
            EquipoEntradaRegistro();
        }

        private void txt_nom_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,1,0,1,e);
        }

        private void txt_num_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 1, 0, 0, e);
        }

        private void txt_desc_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 1, 1, 1, e);
        }

        private void txt_costo_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 0, 0, 0, e);
        }

        private void cb_estatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0, 0, 0, 0, 0, e);
        }

        private void cb_clasificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0, 0, 0, 0, 0, e);
        }

        private void btn_mod_e_Click(object sender, EventArgs e)
        {
            EquipoEntradaModificacion();
        }

        private void cb_clas_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0,0,0,0,0,e);
        }

        private void btn_accion_e_Click(object sender, EventArgs e)
        {
            EquipoRegMod();
        }

        private void cb_clasificacion_SelectedValueChanged(object sender, EventArgs e)
        {
            dgv_e.DataSource = Eq.EquipoBuscarPorClasificacion(cb_clasificacion.Text);
        }

        private void txt_buscar_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,1,0,1,e);
        }

        private void txt_buscar_e_TextChanged(object sender, EventArgs e)
        {
            dgv_e.DataSource = Eq.EquipoBuscarNombre(txt_buscar_e.Text);
        }
        
        private void TabControl_Equipo_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Equipo.SelectedTab == TabEquipo_Lista) //TabEmpleados_Lista
            {
                EquipoEntradaRegistro();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)) && TabControl_Equipo.SelectedTab == TabEquipo_Lista)
            {
                EquipoBaja();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F3)) && TabControl_Equipo.SelectedTab == TabEquipo_Lista)
            {
                EquipoEntradaModificacion();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F4)) && TabControl_Equipo.SelectedTab == TabEquipo_Lista)
            {
                TabControl_Equipo.SelectedTab = TabEquipo_Clas_Lista;
                dgv_c.DataSource = C.ClasificacionBuscar();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F5)) && TabControl_Equipo.SelectedTab == TabEquipo_Lista)
            {
                TabControl_Equipo.SelectedTab = TabEquipo_Reportes;
                dgv_r.DataSource = Eq.EquipoEstadoBuscar();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Equipo.SelectedTab == TabEquipo_Clas_Lista) //TabEmpleados_Lista
            {
                ClasificacionEntradaRegistro();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)) && TabControl_Equipo.SelectedTab == TabEquipo_Clas_Lista)
            {
                ClasificacionEntradaModificacion();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F3)) && TabControl_Equipo.SelectedTab == TabEquipo_Clas_Lista)
            {
                ClasificacionEliminar();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Equipo.SelectedTab == TabEquipo_Reportes) //TabEmpleados_Lista
            {
                EquipoEstadoEntradaRegistro();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)) && TabControl_Equipo.SelectedTab == TabEquipo_Reportes) //TabEmpleados_Lista
            {
                EquipoEstadoEntradaVerDetalles();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Equipo.SelectedTab == TabNuevo_equipo) //TabEmpleados_Lista
            {
                EquipoRegMod();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Equipo.SelectedTab == TabNuevo_Reporte) //TabEmpleados_Lista
            {
                EquipoEstadoRegistrar();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Equipo.SelectedTab == TabDetalle_Reporte) //TabEmpleados_Lista
            {
                TabControl_Equipo.SelectedTab = TabEquipo_Reportes;
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Equipo.SelectedTab == TabNuevo_clas) //TabEmpleados_Lista
            {
                ClasificacionRegMod();
            }
        }

        private void txt_nom_c_KeyUp(object sender, KeyEventArgs e)
        {
            if (C.ClasificacionBuscarCoincidenciaNombre(txt_nom_c.Text) >= 1 && Nom_clas != txt_nom_c.Text)
            {
                lbl_msg_c.ForeColor = Color.DarkRed;
                lbl_msg_c.Text = "Nombre de clasificación NO disponible";
            }
            else
            {
                lbl_msg_c.ForeColor = Color.DarkGreen;
                lbl_msg_c.Text = "Nombre de clasificación disponible";
            }
        }

        private void txt_num_e_KeyUp(object sender, KeyEventArgs e)
        {
            if (Eq.EquipoBuscarCoincidenciaNumeroSerie(txt_num_e.Text) >= 1 && Nom_equipo != txt_num_e.Text)
            {
                lbl_msg_e.ForeColor = Color.DarkRed;
                lbl_msg_e.Text = "Número de serie YA registrado.";
            }
            else
            {
                lbl_msg_e.ForeColor = Color.DarkGreen;
                lbl_msg_e.Text = "Número de serie correcto.";
            }
        }

        private void dgv_reg_r_Click(object sender, EventArgs e)
        {
            EquipoEstadoEntradaRegistro();
        }

        private void dgv_nr_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = Eq.EquipoEstadoBuscar().Rows.Count + 1;
        }

        private void btn_guardar_nr_Click(object sender, EventArgs e)
        {
            EquipoEstadoRegistrar();
        }

        private void btn_cancelar_dr1_Click(object sender, EventArgs e)
        {
            TabControl_Equipo.SelectedTab = TabEquipo_Reportes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipoEstadoEntradaVerDetalles();
        }

        //FUNCIONES DE VALIDACION DE DATOS
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

        //FUNCIONES PARA BOTONES
        public void EquipoEntradaRegistro()
        {
            TabControl_Equipo.SelectedTab = TabNuevo_equipo;
            lbl_accion1_e.Text = "REGISTRAR NUEVO EQUIPO";
            lbl_accion2_c.Text = "NUEVO EQUIPO";
            txt_nom_e.Clear();
            txt_costo_e.Clear();
            txt_num_e.Clear();
            txt_desc_e.Clear();
            btn_accion_e.Text = "REGISTRAR (F1)";
            cb_clas_e.DisplayMember = "Nombre";
            cb_clas_e.DataSource = Eq.EquipoBuscarClasificaciones();
        }

        public void EquipoEntradaModificacion()
        {
            if (dgv_e.SelectedRows.Count == 1)
            {
                TabControl_Equipo.SelectedTab = TabNuevo_equipo;
                lbl_accion1_e.Text = "MODIFICAR EQUIPO";
                lbl_accion2_e.Text = "CLAVE DEL EQUIPO: " + Convert.ToString(dgv_e.CurrentRow.Cells[0].Value);
                DataRow row = Eq.EquipoBuscarDatos(Convert.ToInt32(dgv_e.CurrentRow.Cells[0].Value)).Rows[0];
                txt_nom_e.Text = row["Nombre"].ToString();
                txt_costo_e.Text = row["Costo"].ToString();
                txt_num_e.Text = row["Codigo"].ToString();
                txt_desc_e.Text = row["Descripcion"].ToString();
                btn_accion_e.Text = "MODIFICAR (F1)";
                cb_clas_e.DisplayMember = "Nombre";
                cb_clas_e.DataSource = Eq.EquipoBuscarClasificaciones();
                cb_clas_e.Text = row["NomClas"].ToString();
                DatosEq[0] = txt_nom_e.Text;
                DatosEq[1] = txt_costo_e.Text;
                DatosEq[2] = txt_num_e.Text;
                DatosEq[3] = cb_clas_e.Text;
                DatosEq[4] = txt_desc_e.Text;
                Nom_equipo = txt_num_e.Text;
            }
            else
                MessageBox.Show("Debe SELECCIONAR al menos un equipo para modificarlo.");
        }

        public void EquipoBaja()
        {
            if (dgv_e.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_e.CurrentRow.Cells[3].Value) == "A")
                {
                    DialogResult result = MessageBox.Show("Está seguro que desea dar de BAJA el equipo seleccionado?", "GYMCENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        Eq.EquipoBaja(Convert.ToInt32(dgv_e.CurrentRow.Cells[0].Value));
                        dgv_e.DataSource = Eq.EquipoBuscar();
                        cb_estatus.Text = "TODOS";
                    }
                    else if (result == DialogResult.No) { }
                }
                else
                    MessageBox.Show("Debe seleccionar un equipo ACTIVO para darlo de baja.");
            }
            else
                MessageBox.Show("Debe seleccionar al menos un equipo para darlo de baja.");
        }

        public void EquipoRegMod()
        {
            if (txt_nom_e.Text != "")
            {
                if (txt_desc_e.Text != "")
                {
                    if (txt_costo_e.Text != "")
                    {
                        if (txt_num_e.Text != "")
                        {
                            if (cb_clas_e.Text != "")
                            {
                                if (txt_num_e.Text.Length==8)
                                {
                                    if (lbl_msg_e.Text != "Número de serie YA registrado.")
                                    {
                                        if (lbl_accion1_e.Text == "REGISTRAR NUEVO EQUIPO")
                                        {
                                            Eq.EquipoRegistrar(cb_clas_e.Text, txt_nom_e.Text, Convert.ToInt32(txt_costo_e.Text), txt_num_e.Text, txt_desc_e.Text);
                                            MessageBox.Show("Equipo REGISTRADO exitosamente.");
                                            TabControl_Equipo.SelectedTab = TabEquipo_Lista;
                                            dgv_e.DataSource = Eq.EquipoBuscar();
                                            cb_estatus.Text = "TODOS";
                                        }
                                        else
                                        {
                                            if (txt_nom_e.Text != DatosEq[0] || txt_costo_e.Text != DatosEq[1] || txt_num_e.Text != DatosEq[2] || cb_clas_e.Text != DatosEq[3] || txt_desc_e.Text != DatosEq[4])
                                            {
                                                Eq.EquipoModificar(Convert.ToInt32(lbl_accion2_e.Text.Substring(18, lbl_accion2_e.Text.Length - 18)), cb_clas_e.Text, txt_nom_e.Text, Convert.ToInt32(txt_costo_e.Text), txt_num_e.Text, txt_desc_e.Text);
                                                MessageBox.Show("Equipo MODIFICADO exitosamente.");
                                                TabControl_Equipo.SelectedTab = TabEquipo_Lista;
                                                dgv_e.DataSource = Eq.EquipoBuscar();
                                                cb_estatus.Text = "TODOS";
                                            }
                                            else
                                                MessageBox.Show("Debe MODIFICAR ALGUN CAMPO para continuar con la operación.");
                                        }
                                    }
                                    else
                                        MessageBox.Show("Debe ingresar un NÚMERO DE SERIE correcto.");
                                }
                                else
                                    MessageBox.Show("Debe ingresar un NÚMERO DE SERIE de 8 caracteres.");
                            }
                            else
                                MessageBox.Show("Debe seleccionar la CLASIFICACIÓN del equipo para guardar los cambios.");
                        }
                        else
                            MessageBox.Show("Debe ingresar el NÚMERO DE SERIE del equipo para guardar los cambios.");
                    }
                    else
                        MessageBox.Show("Debe ingresar el COSTO del equipo para guardar los cambios.");
                }
                else
                    MessageBox.Show("Debe ingresar la DESCRIPCIÓN del equipo para guardar los cambios.");
            }
            else
                MessageBox.Show("Debe ingresar el NOMBRE del equipo para guardar los cambios.");
        }

        public void EquipoEstadoEntradaRegistro()
        {
            TabControl_Equipo.SelectedTab = TabNuevo_Reporte;
            Equipo.DisplayMember = "Codigo";
            Equipo.DataSource = Eq.EquipoBuscarSeriales();
            dgv_nr.Rows.Clear();
        }

        public void EquipoEstadoEntradaVerDetalles()
        {
            dgv_dr.DataSource = Eq.EquipoEstadoBuscarDetalleReporte(Convert.ToInt32(dgv_r.CurrentRow.Cells[0].Value));
            TabControl_Equipo.SelectedTab = TabDetalle_Reporte;
        }

        public void EquipoEstadoRegistrar()
        {
            int Reg = 1;
            if (dgv_nr.Rows.Count != 1)
            {
                for (int a = 0; a < dgv_nr.Rows.Count - 1; a++)
                {
                    if (Convert.ToString(dgv_nr.Rows[a].Cells[1].Value) == "" || Convert.ToString(dgv_nr.Rows[a].Cells[2].Value) == "")
                    {
                        MessageBox.Show("Debe LLENAR TODOS LOS CAMPOS para guardar los cambios.");
                        Reg = 0;
                        break;
                    }
                }
                if (Reg == 1)
                {
                    Eq.EquipoEstadoRegistrarRE(IdUsuario);
                    for (int b = 0; b < dgv_nr.Rows.Count - 1; b++)
                    {
                        Eq.EquipoEstadoRegistrarDRE(Convert.ToInt32(dgv_nr.Rows[b].Cells[0].Value), Convert.ToString(dgv_nr.Rows[b].Cells[1].Value).Substring(Convert.ToString(dgv_nr.Rows[b].Cells[1].Value).Length - 9, 8), Convert.ToString(dgv_nr.Rows[b].Cells[2].Value));
                    }
                    MessageBox.Show("Reporte GUARDADO exitosamente.");
                    TabControl_Equipo.SelectedTab = TabEquipo_Reportes;
                    dgv_r.DataSource = Eq.EquipoEstadoBuscar();
                }
            }
            else
                MessageBox.Show("Debe ingresar por lo menos un reporte de equipo para guardar los cambios.");
        }

        public void ClasificacionEntradaRegistro()
        {
            TabControl_Equipo.SelectedTab = TabNuevo_clas;
            lbl_accion1_c.Text = "CREAR NUEVA CLASIFICACIÓN";
            lbl_accion2_c.Text = "NUEVA CLASIFICACIÓN";
            txt_nom_c.Clear();
            txt_desc_c.Clear();
            btn_accion_c.Text = "CREAR (F1)";
        }

        public void ClasificacionEntradaModificacion()
        {
            if (dgv_c.SelectedRows.Count == 1)
            {
                TabControl_Equipo.SelectedTab = TabNuevo_clas;
                lbl_accion1_c.Text = "MODIFICAR CLASIFICACIÓN";
                lbl_accion2_c.Text = "CLAVE DE LA CLASIFICACIÓN: " + Convert.ToString(dgv_c.CurrentRow.Cells[0].Value);
                DataRow row = C.ClasificacionBuscarDatos(Convert.ToInt32(dgv_c.CurrentRow.Cells[0].Value)).Rows[0];
                txt_nom_c.Text = row["Nombre"].ToString();
                txt_desc_c.Text = row["Descripcion"].ToString();
                btn_accion_c.Text = "MODIFICAR (F1)";
                DatosC[0] = txt_nom_c.Text;
                DatosC[1] = txt_desc_c.Text;
                Nom_clas = txt_nom_c.Text;
            }
            else
                MessageBox.Show("Debe SELECCIONAR al menos una clasificación para modificarla.");
        }

        public void ClasificacionEliminar()
        {
            if (dgv_c.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Está seguro que desea DAR DE BAJA PERMAMENTEMENTE la clasificación seleccionada?", "GYMCENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    DataRow row = C.ClasificacionEliminar(Convert.ToInt32(dgv_c.CurrentRow.Cells[0].Value)).Rows[0];
                    string res = row["Resultado"].ToString();
                    if (res == "1")
                    {
                        MessageBox.Show("La clasificación que intenta dar de baja se encuentra enlazada a un equipo. Modifique los datos de los equipos registrados bajo esta clasificación para darla de baja.");
                    }
                    else
                    {
                        dgv_c.DataSource = C.ClasificacionBuscar();
                    }
                }
                else if (result == DialogResult.No) { }
            }
            else
                MessageBox.Show("Debe seleccionar al menos una clasificación para darla de baja.");
        }

        public void ClasificacionRegMod()
        {
            if (txt_nom_c.Text != "")
            {
                if (txt_desc_c.Text != "")
                {
                    if (lbl_msg_c.Text != "Nombre de clasificación NO disponible")
                    {
                        if (lbl_accion1_c.Text == "CREAR NUEVA CLASIFICACIÓN")
                        {
                            C.ClasificacionRegistrar(txt_nom_c.Text, txt_desc_c.Text);
                            MessageBox.Show("Clasificación REGISTRADA exitosamente.");
                            TabControl_Equipo.SelectedTab = TabEquipo_Clas_Lista;
                            dgv_c.DataSource = C.ClasificacionBuscar();
                        }
                        else
                        {
                            if (txt_nom_c.Text != DatosC[0] || txt_desc_c.Text != DatosC[1])
                            {
                                C.ClasificacionModificar(Convert.ToInt32(lbl_accion2_c.Text.Substring(27, lbl_accion2_c.Text.Length - 27)), txt_nom_c.Text, txt_desc_c.Text);
                                MessageBox.Show("Clasificación MODIFICADA exitosamente.");
                                TabControl_Equipo.SelectedTab = TabEquipo_Clas_Lista;
                                dgv_c.DataSource = C.ClasificacionBuscar();
                            }
                            else
                                MessageBox.Show("Debe MODIFICAR ALGUN CAMPO para continuar con la operación.");
                        }
                    }
                    else
                        MessageBox.Show("Debe ingresar un NOMBRE de clasificación DISPONIBLE para guardar los cambios.");
                }
                else
                    MessageBox.Show("Debe ingresar la DESCRIPCIÓN de la clasificacion para guardar los cambios.");
            }
            else
                MessageBox.Show("Debe ingresar el NOMBRE de la clasificacion para guardar los cambios.");
        }
    }
}
