using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Entidades;
using Negocio;

namespace Presentacion.Funcionarios
{
    public partial class docenteAsignatura : MaterialForm
    {
        public docenteAsignatura()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }

        private void docenteAsignatura_Load(object sender, EventArgs e)
        {
            CargaFuncionarios();
            CargarAsinaturas();
        }

        void CargaFuncionarios()
        {
            NFuncionario n = new NFuncionario();
            List<EFuncionarios> listaFuncioanrio = n.ListaFuncionarios();
            var NuevaLista = (from i in listaFuncioanrio
                              where i.IsDocenet == true
                              select new
                              {
                                  i.FuncionarioId,
                                  i.Nombres,
                                  i.Apellidos,
                                  i.Telefono,
                                  i.Email,
                                  i.Cargo,
                                  i.Ocupacion.Ocupacion,
                              }).ToList();
            gridControl1.DataSource = NuevaLista;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[6].Group();
            gridView1.BestFitColumns();
        }

        void CargarAsinaturas()
        {
            try
            {
                NAsignatura n = new NAsignatura();
                List<EAsignatura> Lista = n.ListaAsignatura();
                listBox1.DataSource = Lista;
                listBox1.DisplayMember = "Asignatura";
                listBox1.ValueMember = "AsignaturaId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
