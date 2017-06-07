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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para ClienteVenta.xaml
    /// </summary>
    public partial class ClienteVenta : Window
    {
        public ClienteVenta(int id)
        {
            InitializeComponent();
            c.IdVenta = id;
           
        }

        CapaLogica.ClienteVenta c = new CapaLogica.ClienteVenta();
        void VincularXcodigo()
        {
            pbar.Value = 15;
            lblporcentaje.Content = pbar.Value.ToString() + "%";
            if (siExisteClientexCo().Rows.GetEnumerator().MoveNext())
            {
                try
                {

                    if (txtBuscar.Text != "")
                    {
                        pbar.Value = 30;
                        lblporcentaje.Content = pbar.Value.ToString() + "%";
                        pbar.Value = 50;
                        lblporcentaje.Content = pbar.Value.ToString() + "%";
                        c.VincularClientexCodigo(c.IdVenta, txtBuscar.Text.ToString());
                        pbar.Value = 100;
                        lblporcentaje.Content = pbar.Value.ToString() + "%";
                        lblporcentaje.Content = pbar.Value.ToString() + "% Completado";
                        MessageBox.Show("Venta vinculada al cliente Exitosamente","Mensaje");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un codigo correcto", "Error");
                        txtBuscar.Focus();
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Contacte a su Administrador error:" + e.ToString());
                }

            }
            else
            {

                MessageBox.Show("No Se encontro ningun Cliente con ese codigo");
                pbar.Value = 0;
                lblporcentaje.Content = pbar.Value.ToString() + "%";
            }
        }
       public  DataTable siExisteClientexCo()
        {
           return c.buscarCliente(txtBuscar.Text,"none","co");

        }

        private void btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            VincularXcodigo();
        }
    }
}