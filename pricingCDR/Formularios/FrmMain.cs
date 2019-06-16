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
                    //pregunta si existe la base de datos
                    bool exists = context.Database.Exists();
                    if (!exists)
                    {
                        // si no existe la crea y agrega algunos registros
                        context.Database.CreateIfNotExists();
                        FuncionesGlobales.Seed();
                    }
                    //crea un query de los servicios activos de la base de datos
                    var queryServiciosActivos = (from entity in context.Servicios
                                        where entity.Estado.Equals("A")
                                        select  entity).AsQueryable();

                    #region show OnTime Services
                    // crea otro q  uery de los servicios tipo OnTime
                    var queryServiciosOnTime = (from entity in queryServiciosActivos
                                                where entity.TipoServicio == Tablas.TipoServicio.OnTime
                                                orderby entity.Orden
                                                select entity).AsQueryable();
                    //consulta los servicios OnTime
                    var listServiciosOntime = queryServiciosOnTime.ToList();
                    int c = 0;
                    //presenta los servicios ontime en el formulario
                    foreach(Tablas.Servicio servicio in listServiciosOntime)
                    {
                        this.dataGridViewOnTime.Rows.Add();
                        this.dataGridViewOnTime.Rows[c].Cells[0].Value = servicio.Descripcion;
                        this.dataGridViewOnTime.Rows[c].Cells[0].Tag = servicio;
                        c ++;
                        
                    }
                    //this.dataGridViewOnTime.AutoResizeColumns();
                    this.dataGridViewOnTime.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    this.dataGridViewOnTime.ClearSelection();
                    #endregion

                    #region show OffLine Services
                    //crea query de los servicios offline
                    var queryServiciosOffLine = (from entity in queryServiciosActivos
                                                where entity.TipoServicio == Tablas.TipoServicio.OffLine
                                                orderby entity.Orden
                                                select entity).AsQueryable();
                    //consulta los servicios OnTime
                    var listServiciosOffLine = queryServiciosOffLine.ToList();
                    c = 0;
                    //presenta los servicios ontime en el formulario
                    foreach (Tablas.Servicio servicio in listServiciosOffLine)
                    {
                        this.dataGridViewOffLine.Rows.Add();
                        this.dataGridViewOffLine.Rows[c].Cells[0].Value = servicio.Descripcion;
                        this.dataGridViewOffLine.Rows[c].Cells[0].Tag = servicio;
                        c++;

                    }
                    //this.dataGridViewOffLine.Columns[0].Width = this.dataGridViewOnTime.Columns[0].Width; 
                    this.dataGridViewOffLine.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //this.dataGridViewOffLine.ClearSelection();
                    #endregion
                }
            }
            catch(Exception ex)
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
