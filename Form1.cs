using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7___Laboratorio_de_repaso_3
{
    public partial class Form1 : Form
    {
        List <Propietario> Propietarios = new List <Propietario> ();
        List<Propiedad> Propiedades = new List<Propiedad>();
        List<DGVPropietario> DGVPropietarios = new List<DGVPropietario>();
        List<DGVPropietario> DGVPropietarios3AltoBajo = new List<DGVPropietario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCuotaMantenimiento_Click(object sender, EventArgs e)
        {
            DGVPropietarios = DGVPropietarios.OrderBy(x => x.CuotaMantenimiento).ToList();
            MostrarDGV(DGVPropietarios);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = "propietario.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                //DPI, Nombre, Apellido
                propietario.DPI = (int)Convert.ToInt64(reader.ReadLine());
                propietario.Nombre = reader.ReadLine();
                propietario.Apellido = reader.ReadLine();
                Propietarios.Add(propietario);
            }
            reader.Close();
            
            fileName = "propiedad.txt";
            stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propiedad propiedad = new Propiedad();
                //Número de Casa, DPI del Dueño, Cuota de mantenimiento
                propiedad.NumCasa = Convert.ToInt16(reader.ReadLine());
                propiedad.DPI = (int)Convert.ToInt64(reader.ReadLine());
                propiedad.CuotaMantenimiento = Convert.ToInt32(reader.ReadLine());
                Propiedades.Add(propiedad);
            }
            reader.Close();


            for (int i = 0; i < Propietarios.Count; i++)
            {
                DGVPropietario dGVPropietario = new DGVPropietario();
                for (int j = 0; j < Propiedades.Count; j++)
                {
                    if (Propietarios[i].DPI == Propiedades[j].DPI)
                    {
                        //Nombre y Apellido del propietario, el número de casa y su cuota de Mantinimiento.
                        dGVPropietario.Nombre = Propietarios[i].Nombre;
                        dGVPropietario.Apellido = Propietarios[i].Apellido;
                        dGVPropietario.NumCasa = Propiedades[j].NumCasa;
                        dGVPropietario.CuotaMantenimiento = Propiedades[j].CuotaMantenimiento;
                        DGVPropietarios.Add(dGVPropietario);
                        break;
                    }
                }
            }

            //Cuota mas alta
            DGVPropietario dGVPropietario1 = new DGVPropietario();
            //Encuentra el dato mayor
            dGVPropietario1 = DGVPropietarios.OrderByDescending(x => x.CuotaMantenimiento).First();
            
            //Muestra el nombre completo y cuota del dato mayor
            labelPropietarioCuotaMasAlta.Text = dGVPropietario1.Nombre + " " + dGVPropietario1.Apellido;
            labelCuotaMasAlta.Text = dGVPropietario1.CuotaMantenimiento.ToString();

            MostrarDGV(DGVPropietarios);
        }

        private void MostrarDGV(List <DGVPropietario> baseDatos)
        {
            dataGridView.DataSource = null;
            dataGridView.Show();

            dataGridView.DataSource = baseDatos;
            dataGridView.Show();
        }

        private void button3MantenimientosMasAltos_Click(object sender, EventArgs e)
        {
            DGVPropietarios3AltoBajo.Clear();
            for (int i = 0; i < 3; i++)
            DGVPropietarios3AltoBajo.Add(DGVPropietarios.OrderByDescending(x => x.CuotaMantenimiento)
                .ElementAt(i));
            
            MostrarDGV(DGVPropietarios3AltoBajo);
        }

        private void button3MantenimientosMasBajos_Click(object sender, EventArgs e)
        {
            DGVPropietarios3AltoBajo.Clear();
            for (int i = 0; i < 3; i++)
                DGVPropietarios3AltoBajo.Add(DGVPropietarios.OrderBy(x => x.CuotaMantenimiento)
                    .ElementAt(i));

            MostrarDGV(DGVPropietarios3AltoBajo);
        }
    }
}
