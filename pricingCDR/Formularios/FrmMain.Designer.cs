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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOnTime = new System.Windows.Forms.TabPage();
            this.tabPageOffLine = new System.Windows.Forms.TabPage();
            this.dataGridViewOnTime = new System.Windows.Forms.DataGridView();
            this.ButtonColumnServicios = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxServicios = new System.Windows.Forms.GroupBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageOnTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnTime)).BeginInit();
            this.groupBoxServicios.SuspendLayout();
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
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageOnTime
            // 
            this.tabPageOnTime.Controls.Add(this.groupBoxServicios);
            this.tabPageOnTime.Location = new System.Drawing.Point(4, 22);
            this.tabPageOnTime.Name = "tabPageOnTime";
            this.tabPageOnTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOnTime.Size = new System.Drawing.Size(768, 400);
            this.tabPageOnTime.TabIndex = 0;
            this.tabPageOnTime.Text = "OnTime";
            this.tabPageOnTime.UseVisualStyleBackColor = true;
            // 
            // tabPageOffLine
            // 
            this.tabPageOffLine.Location = new System.Drawing.Point(4, 22);
            this.tabPageOffLine.Name = "tabPageOffLine";
            this.tabPageOffLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOffLine.Size = new System.Drawing.Size(768, 400);
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
            this.ButtonColumnServicios});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOnTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOnTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOnTime.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOnTime.MultiSelect = false;
            this.dataGridViewOnTime.Name = "dataGridViewOnTime";
            this.dataGridViewOnTime.ReadOnly = true;
            this.dataGridViewOnTime.RowHeadersVisible = false;
            this.dataGridViewOnTime.RowTemplate.Height = 50;
            this.dataGridViewOnTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOnTime.Size = new System.Drawing.Size(158, 369);
            this.dataGridViewOnTime.TabIndex = 0;
            this.dataGridViewOnTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnTime_CellContentClick);
            // 
            // ButtonColumnServicios
            // 
            this.ButtonColumnServicios.HeaderText = "ButtonColumn";
            this.ButtonColumnServicios.Name = "ButtonColumnServicios";
            this.ButtonColumnServicios.ReadOnly = true;
            // 
            // groupBoxServicios
            // 
            this.groupBoxServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxServicios.Controls.Add(this.dataGridViewOnTime);
            this.groupBoxServicios.Location = new System.Drawing.Point(6, 6);
            this.groupBoxServicios.Name = "groupBoxServicios";
            this.groupBoxServicios.Size = new System.Drawing.Size(164, 388);
            this.groupBoxServicios.TabIndex = 1;
            this.groupBoxServicios.TabStop = false;
            this.groupBoxServicios.Text = "SERVICIOS";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FrmMain";
            this.Text = "PRICING CDR";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOnTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnTime)).EndInit();
            this.groupBoxServicios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOnTime;
        private System.Windows.Forms.TabPage tabPageOffLine;
        private System.Windows.Forms.DataGridView dataGridViewOnTime;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumnServicios;
        private System.Windows.Forms.GroupBox groupBoxServicios;
    }
}

