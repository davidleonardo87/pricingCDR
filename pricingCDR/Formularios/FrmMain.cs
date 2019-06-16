using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pricingCDR.Formularios
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                using (Datos.ModelCDR context = new Datos.ModelCDR())
                {
                    bool exists = context.Database.Exists();
                    if (!exists)
                    {
                        context.Database.CreateIfNotExists();
                        FuncionesGlobales.Seed();
                    }
                    var queryServiciosActivos = (from entity in context.Servicios
                                        where entity.Estado.Equals("A")
                                        select  entity).AsQueryable();
                    var queryServiciosOnTime = (from entity in queryServiciosActivos
                                                where entity.TipoServicio == Tablas.TipoServicio.OnTime
                                                orderby entity.Orden
                                                select entity).AsQueryable();
                    var listServiciosOntime = queryServiciosOnTime.ToList();
                    int c = 0;
                    foreach(Tablas.Servicio servicio in listServiciosOntime)
                    {
                        this.dataGridViewOnTime.Rows.Add();
                        this.dataGridViewOnTime.Rows[c].Cells[0].Value = servicio.Descripcion;
                        this.dataGridViewOnTime.Rows[c].Cells[0].Tag = servicio;
                        c ++;
                        
                    }
                    this.dataGridViewOnTime.AutoResizeColumns();
                    this.dataGridViewOnTime.ClearSelection();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOnTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            var cell = grid[e.ColumnIndex, e.RowIndex];
            if (cell.Tag == null)
            {
                return;
            }
            Tablas.Servicio servicio = cell.Tag as Tablas.Servicio;
            
        }

        private void dataGridViewOffLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            var cell = grid[e.ColumnIndex, e.RowIndex];
            if (cell.Tag == null)
            {
                return;
            }
            Tablas.Servicio servicio = cell.Tag as Tablas.Servicio;

        }
    }
}
