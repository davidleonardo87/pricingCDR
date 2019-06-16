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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOnTime = new System.Windows.Forms.TabPage();
            this.tabPageOffLine = new System.Windows.Forms.TabPage();
            this.dataGridViewOnTime = new System.Windows.Forms.DataGridView();
            this.ButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControlMain.SuspendLayout();
            this.tabPageOnTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
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
            this.tabPageOnTime.Controls.Add(this.dataGridViewOnTime);
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
            this.dataGridViewOnTime.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewOnTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButtonColumn});
            this.dataGridViewOnTime.Location = new System.Drawing.Point(17, 39);
            this.dataGridViewOnTime.Name = "dataGridViewOnTime";
            this.dataGridViewOnTime.ReadOnly = true;
            this.dataGridViewOnTime.RowHeadersVisible = false;
            this.dataGridViewOnTime.Size = new System.Drawing.Size(210, 332);
            this.dataGridViewOnTime.TabIndex = 0;
            // 
            // ButtonColumn
            // 
            this.ButtonColumn.HeaderText = "ButtonColumn";
            this.ButtonColumn.Name = "ButtonColumn";
            this.ButtonColumn.ReadOnly = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOnTime;
        private System.Windows.Forms.TabPage tabPageOffLine;
        private System.Windows.Forms.DataGridView dataGridViewOnTime;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn;
    }
}

