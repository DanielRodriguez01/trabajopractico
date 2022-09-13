using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajopractico2.Datos;
using Trabajopractico2.Modelo;

namespace Trabajopractico2
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato= new Usuario ();
        public Form1()
        {
            InitializeComponent();

            Iniciar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consulta();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }

        private void Iniciar () {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            Grilla.DataSource = tabla;

        }

        private void Guardar () {
            Usuariomodelo modelo = new Usuariomodelo()
            {
                Nombre = txtnombre.Text,
                Edad = int.Parse(txtedad.Text)


            };
            dato.Guardar(modelo);
    }
        private void Consulta()
        {
            foreach (var item in dato.Consultar() ) {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);

             }
           

        }

        private void Limpiar ()
        {
            txtnombre.Text = "";
            txtedad.Text = "";
        }
           
}

    

}




