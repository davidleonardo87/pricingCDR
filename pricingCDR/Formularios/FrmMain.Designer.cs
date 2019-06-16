namespace pricingCDR.Formularios
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOnTime = new System.Windows.Forms.TabPage();
            this.tabPageOffLine = new System.Windows.Forms.TabPage();
            this.dataGridViewOnTime = new System.Windows.Forms.DataGridView();
            this.ButtonColumnServiciosOnTime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxServicios = new System.Windows.Forms.GroupBox();
            this.groupBoxOffLine = new System.Windows.Forms.GroupBox();
            this.dataGridViewOffLine = new System.Windows.Forms.DataGridView();
            this.ButtonColumnServiciosOffLine = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxParametrosOnTime = new System.Windows.Forms.GroupBox();
            this.groupBoxParametrosOffLine = new System.Windows.Forms.GroupBox();
            this.groupBoxConsultaOnTime = new System.Windows.Forms.GroupBox();
            this.groupBoxConsultaOffLine = new System.Windows.Forms.GroupBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageOnTime.SuspendLayout();
            this.tabPageOffLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnTime)).BeginInit();
            this.groupBoxServicios.SuspendLayout();
            this.groupBoxOffLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffLine)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageOnTime);
            this.tabControlMain.Controls.Add(this.tabPageOffLine);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(808, 435);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageOnTime
            // 
            this.tabPageOnTime.Controls.Add(this.groupBoxConsultaOnTime);
            this.tabPageOnTime.Controls.Add(this.groupBoxParametrosOnTime);
            this.tabPageOnTime.Controls.Add(this.groupBoxServicios);
            this.tabPageOnTime.Location = new System.Drawing.Point(4, 22);
            this.tabPageOnTime.Name = "tabPageOnTime";
            this.tabPageOnTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOnTime.Size = new System.Drawing.Size(800, 409);
            this.tabPageOnTime.TabIndex = 0;
            this.tabPageOnTime.Text = "OnTime";
            this.tabPageOnTime.UseVisualStyleBackColor = true;
            // 
            // tabPageOffLine
            // 
            this.tabPageOffLine.Controls.Add(this.groupBoxConsultaOffLine);
            this.tabPageOffLine.Controls.Add(this.groupBoxParametrosOffLine);
            this.tabPageOffLine.Controls.Add(this.groupBoxOffLine);
            this.tabPageOffLine.Location = new System.Drawing.Point(4, 22);
            this.tabPageOffLine.Name = "tabPageOffLine";
            this.tabPageOffLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOffLine.Size = new System.Drawing.Size(800, 409);
            this.tabPageOffLine.TabIndex = 1;
            this.tabPageOffLine.Text = "OffLine";
            this.tabPageOffLine.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOnTime
            // 
            this.dataGridViewOnTime.AllowUserToAddRows = false;
            this.dataGridViewOnTime.AllowUserToDeleteRows = false;
            this.dataGridViewOnTime.AllowUserToResizeColumns = false;
            this.dataGridViewOnTime.AllowUserToResizeRows = false;
            this.dataGridViewOnTime.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewOnTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOnTime.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOnTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnTime.ColumnHeadersVisible = false;
            this.dataGridViewOnTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButtonColumnServiciosOnTime});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOnTime.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOnTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOnTime.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOnTime.MultiSelect = false;
            this.dataGridViewOnTime.Name = "dataGridViewOnTime";
            this.dataGridViewOnTime.ReadOnly = true;
            this.dataGridViewOnTime.RowHeadersVisible = false;
            this.dataGridViewOnTime.RowTemplate.Height = 50;
            this.dataGridViewOnTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOnTime.Size = new System.Drawing.Size(259, 378);
            this.dataGridViewOnTime.TabIndex = 0;
            this.dataGridViewOnTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnTime_CellContentClick);
            // 
            // ButtonColumnServiciosOnTime
            // 
            this.ButtonColumnServiciosOnTime.HeaderText = "ButtonColumn";
            this.ButtonColumnServiciosOnTime.Name = "ButtonColumnServiciosOnTime";
            this.ButtonColumnServiciosOnTime.ReadOnly = true;
            // 
            // groupBoxServicios
            // 
            this.groupBoxServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxServicios.Controls.Add(this.dataGridViewOnTime);
            this.groupBoxServicios.Location = new System.Drawing.Point(6, 6);
            this.groupBoxServicios.Name = "groupBoxServicios";
            this.groupBoxServicios.Size = new System.Drawing.Size(265, 397);
            this.groupBoxServicios.TabIndex = 1;
            this.groupBoxServicios.TabStop = false;
            this.groupBoxServicios.Text = "SERVICIOS";
            // 
            // groupBoxOffLine
            // 
            this.groupBoxOffLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOffLine.Controls.Add(this.dataGridViewOffLine);
            this.groupBoxOffLine.Location = new System.Drawing.Point(6, 6);
            this.groupBoxOffLine.Name = "groupBoxOffLine";
            this.groupBoxOffLine.Size = new System.Drawing.Size(265, 397);
            this.groupBoxOffLine.TabIndex = 2;
            this.groupBoxOffLine.TabStop = false;
            this.groupBoxOffLine.Text = "SERVICIOS";
            // 
            // dataGridViewOffLine
            // 
            this.dataGridViewOffLine.AllowUserToAddRows = false;
            this.dataGridViewOffLine.AllowUserToDeleteRows = false;
            this.dataGridViewOffLine.AllowUserToResizeColumns = false;
            this.dataGridViewOffLine.AllowUserToResizeRows = false;
            this.dataGridViewOffLine.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewOffLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOffLine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOffLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffLine.ColumnHeadersVisible = false;
            this.dataGridViewOffLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButtonColumnServiciosOffLine});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOffLine.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewOffLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOffLine.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOffLine.MultiSelect = false;
            this.dataGridViewOffLine.Name = "dataGridViewOffLine";
            this.dataGridViewOffLine.ReadOnly = true;
            this.dataGridViewOffLine.RowHeadersVisible = false;
            this.dataGridViewOffLine.RowTemplate.Height = 50;
            this.dataGridViewOffLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOffLine.Size = new System.Drawing.Size(259, 378);
            this.dataGridViewOffLine.TabIndex = 0;
            this.dataGridViewOffLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOffLine_CellContentClick);
            // 
            // ButtonColumnServiciosOffLine
            // 
            this.ButtonColumnServiciosOffLine.HeaderText = "ButtonColumn";
            this.ButtonColumnServiciosOffLine.Name = "ButtonColumnServiciosOffLine";
            this.ButtonColumnServiciosOffLine.ReadOnly = true;
            // 
            // groupBoxParametrosOnTime
            // 
            this.groupBoxParametrosOnTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParametrosOnTime.Location = new System.Drawing.Point(277, 6);
            this.groupBoxParametrosOnTime.Name = "groupBoxParametrosOnTime";
            this.groupBoxParametrosOnTime.Size = new System.Drawing.Size(517, 286);
            this.groupBoxParametrosOnTime.TabIndex = 2;
            this.groupBoxParametrosOnTime.TabStop = false;
            this.groupBoxParametrosOnTime.Text = "Parametros";
            this.groupBoxParametrosOnTime.Visible = false;
            // 
            // groupBoxParametrosOffLine
            // 
            this.groupBoxParametrosOffLine.Location = new System.Drawing.Point(277, 6);
            this.groupBoxParametrosOffLine.Name = "groupBoxParametrosOffLine";
            this.groupBoxParametrosOffLine.Size = new System.Drawing.Size(517, 250);
            this.groupBoxParametrosOffLine.TabIndex = 3;
            this.groupBoxParametrosOffLine.TabStop = false;
            this.groupBoxParametrosOffLine.Text = "Parametros";
            this.groupBoxParametrosOffLine.Visible = false;
            // 
            // groupBoxConsultaOnTime
            // 
            this.groupBoxConsultaOnTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConsultaOnTime.Location = new System.Drawing.Point(277, 298);
            this.groupBoxConsultaOnTime.Name = "groupBoxConsultaOnTime";
            this.groupBoxConsultaOnTime.Size = new System.Drawing.Size(517, 105);
            this.groupBoxConsultaOnTime.TabIndex = 3;
            this.groupBoxConsultaOnTime.TabStop = false;
            this.groupBoxConsultaOnTime.Visible = false;
            // 
            // groupBoxConsultaOffLine
            // 
            this.groupBoxConsultaOffLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConsultaOffLine.Location = new System.Drawing.Point(277, 262);
            this.groupBoxConsultaOffLine.Name = "groupBoxConsultaOffLine";
            this.groupBoxConsultaOffLine.Size = new System.Drawing.Size(517, 138);
            this.groupBoxConsultaOffLine.TabIndex = 4;
            this.groupBoxConsultaOffLine.TabStop = false;
            this.groupBoxConsultaOffLine.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(832, 459);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(848, 498);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRICING CDR";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOnTime.ResumeLayout(false);
            this.tabPageOffLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnTime)).EndInit();
            this.groupBoxServicios.ResumeLayout(false);
            this.groupBoxOffLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOnTime;
        private System.Windows.Forms.TabPage tabPageOffLine;
        private System.Windows.Forms.DataGridView dataGridViewOnTime;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumnServiciosOnTime;
        private System.Windows.Forms.GroupBox groupBoxServicios;
        private System.Windows.Forms.GroupBox groupBoxOffLine;
        private System.Windows.Forms.DataGridView dataGridViewOffLine;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumnServiciosOffLine;
        private System.Windows.Forms.GroupBox groupBoxParametrosOnTime;
        private System.Windows.Forms.GroupBox groupBoxParametrosOffLine;
        private System.Windows.Forms.GroupBox groupBoxConsultaOnTime;
        private System.Windows.Forms.GroupBox groupBoxConsultaOffLine;
    }
}

