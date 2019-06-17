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
        private Tablas.Servicio LastServicioSelected { get; set; }

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
                    var queryServiciosActivos = (from entity in context.Servicios.Include("Parametros").Include("Parametros.OpcionesParametro")
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
                this.Close();
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
            try
            {
                Tablas.Servicio servicio = cell.Tag as Tablas.Servicio;
                this.LastServicioSelected = servicio;
                this.groupBoxParametrosOnTime.Text = "Parametros del servicio \"" + servicio.Descripcion + "\"";
                this.groupBoxParametrosOnTime.Visible = true;
                this.groupBoxConsultaOnTime.Visible = true;
                this.dataGridViewParametersOnTime.Rows.Clear();
                foreach (Tablas.Parametro p in servicio.Parametros)
                {
                    var parametro = p;
                    this.dataGridViewParametersOnTime.Rows.Add();
                    int c = this.dataGridViewParametersOnTime.Rows.Count - 1;
                    this.dataGridViewParametersOnTime.Rows[c].Cells[1].Value = parametro.Descripcion;
                    if (parametro.TieneOpciones)
                    {
                        using (Datos.ModelCDR context = new Datos.ModelCDR())
                        {
                            var query = (from entity in context.OpcionesParametro
                                         where entity.IdParametro == parametro.IdParametro
                                         select entity).AsQueryable();
                            if (query.Any())
                            {
                                List<Tablas.OpcionParametro> opcionParametros = query.ToList();
                                parametro.OpcionesParametro = opcionParametros;
                                var comboCell = new DataGridViewComboBoxCell();
                                comboCell.DataSource = opcionParametros;
                                comboCell.DisplayMember = "Descripcion";
                                comboCell.ValueMember = "IdOpcionParametro";
                                this.dataGridViewParametersOnTime[2, c] = comboCell;
                                int maxlength = (from x in opcionParametros select x.Descripcion.Length).Max();
                                int selectedvalue = (from x in opcionParametros
                                                     where x.Descripcion.Length == maxlength
                                                     select x.IdOpcionParametro).First();
                                this.dataGridViewParametersOnTime[2, c].Value = selectedvalue;
                            }
                        }
                    }
                    this.dataGridViewParametersOnTime.Rows[c].Tag = parametro;
                }
                this.dataGridViewParametersOnTime.AutoResizeColumns();
                this.dataGridViewParametersOnTime.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            this.groupBoxParametrosOffLine.Text = "Parametros del servicio \"" + servicio.Descripcion + "\"";
        }

        private void btnOnTimeShowData_Click(object sender, EventArgs e)
        {
            this.dataGridViewConsultaOnTime.Rows.Clear();
            this.dataGridViewConsultaOnTime.Columns.Clear();
            try
            {
                decimal calculo = 0.00m;
                List<Tablas.Parametro> parametroList = new List<Tablas.Parametro>();
                foreach(DataGridViewRow row in this.dataGridViewParametersOnTime.Rows)
                {
                    var check = (row.Cells[0].Value);
                    if (check != null && (bool)check == true)
                    {
                        Tablas.Parametro parametro = row.Tag as Tablas.Parametro;
                        switch (parametro.TipoParametro)
                        {
                            case Tablas.TipoParametro.ValorPorUnidad :
                                {
                                    var valoringresado = row.Cells[2].Value;
                                    if (parametro.TieneOpciones == false)
                                    {
                                        calculo += decimal.Parse(valoringresado.ToString());
                                    }
                                    else
                                    {
                                        int selectedvalue = (int)valoringresado;
                                        var opcion = parametro.OpcionesParametro.First(x => x.IdOpcionParametro == selectedvalue);
                                        decimal valor = opcion.Valor;
                                        calculo += valor;
                                        parametro.Valor = opcion.Descripcion;
                                    }
                                    break;
                                }
                            case Tablas.TipoParametro.Multiplo :
                                {
                                    var valoringresado = row.Cells[2].Value;
                                    if (parametro.TieneOpciones == false)
                                    {
                                        calculo *= decimal.Parse(valoringresado.ToString());
                                    }
                                    else
                                    {
                                        int selectedvalue = (int)valoringresado;
                                        var opcion = parametro.OpcionesParametro.First(x => x.IdOpcionParametro == selectedvalue);
                                        decimal valor = opcion.Valor;
                                        calculo *= valor;
                                        parametro.Valor = opcion.Descripcion;
                                    }
                                    break;
                                }
                            case Tablas.TipoParametro.Descuento :
                                {
                                    var valoringresado = row.Cells[2].Value;
                                    if (parametro.TieneOpciones == false)
                                    {
                                        var descuento = (calculo * decimal.Parse(valoringresado.ToString()));
                                        calculo -= descuento;
                                        parametro.Valor = descuento.ToString();
                                    }
                                    else
                                    {
                                        int selectedvalue = (int)valoringresado;
                                        var opcion = parametro.OpcionesParametro.First(x => x.IdOpcionParametro == selectedvalue);
                                        decimal valor = opcion.Valor;
                                        var descuento = (calculo * valor);
                                        calculo -= descuento;
                                        parametro.Valor = descuento.ToString();
                                    }
                                    break;
                                }
                            case Tablas.TipoParametro.Impuesto:
                                {
                                    var valoringresado = row.Cells[2].Value;
                                    if (parametro.TieneOpciones == false)
                                    {
                                        var impuesto = (calculo * decimal.Parse(valoringresado.ToString()));
                                        calculo += impuesto;
                                        parametro.Valor = impuesto.ToString();
                                    }
                                    else
                                    {
                                        int selectedvalue = (int)valoringresado;
                                        var opcion = parametro.OpcionesParametro.First(x => x.IdOpcionParametro == selectedvalue);
                                        decimal valor = opcion.Valor;
                                        var impuesto = (calculo * valor);
                                        calculo += impuesto;
                                        parametro.Valor = impuesto.ToString();
                                    }
                                    break;
                                }
                        }
                        parametroList.Add(parametro);
                    }
                }
                decimal costo = calculo;
                DataGridViewTextBoxColumn servicioColumn = new DataGridViewTextBoxColumn();
                servicioColumn.HeaderText = "Servicio";
                this.dataGridViewConsultaOnTime.Columns.Add(servicioColumn);
                string[] data = new string[parametroList.Count+2];
                data[0] = LastServicioSelected.Descripcion;
                int i = 0;
                foreach (Tablas.Parametro parametro in parametroList)
                {
                    i++;
                    DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
                    dataGridViewTextBoxColumn.HeaderText = parametro.Descripcion;
                    this.dataGridViewConsultaOnTime.Columns.Add(dataGridViewTextBoxColumn);
                    data[i] = parametro.Valor;
                }
                DataGridViewTextBoxColumn costocolumn = new DataGridViewTextBoxColumn();
                costocolumn.HeaderText = "Costo";
                data[data.Length - 1] = costo.ToString();
                this.dataGridViewConsultaOnTime.Columns.Add(costocolumn);
                this.dataGridViewConsultaOnTime.Rows.Add(data);
                this.dataGridViewConsultaOnTime.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {

        }

    }
}
