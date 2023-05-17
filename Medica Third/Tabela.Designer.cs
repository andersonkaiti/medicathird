namespace Medica_Third
{
    partial class Tabela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabelaMedicação = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaMedicação)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelaMedicação
            // 
            this.TabelaMedicação.AllowUserToAddRows = false;
            this.TabelaMedicação.AllowUserToDeleteRows = false;
            this.TabelaMedicação.AllowUserToResizeColumns = false;
            this.TabelaMedicação.AllowUserToResizeRows = false;
            this.TabelaMedicação.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaMedicação.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelaMedicação.ColumnHeadersHeight = 40;
            this.TabelaMedicação.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.TabelaMedicação.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabelaMedicação.Location = new System.Drawing.Point(0, 67);
            this.TabelaMedicação.MultiSelect = false;
            this.TabelaMedicação.Name = "TabelaMedicação";
            this.TabelaMedicação.RowHeadersVisible = false;
            this.TabelaMedicação.RowHeadersWidth = 40;
            this.TabelaMedicação.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabelaMedicação.Size = new System.Drawing.Size(784, 394);
            this.TabelaMedicação.StateCommon.Background.Color1 = System.Drawing.SystemColors.Control;
            this.TabelaMedicação.StateCommon.Background.Color2 = System.Drawing.SystemColors.Control;
            this.TabelaMedicação.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.TabelaMedicação.StateCommon.DataCell.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.TabelaMedicação.StateCommon.DataCell.Border.Width = 1;
            this.TabelaMedicação.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabelaMedicação.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Blue;
            this.TabelaMedicação.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Blue;
            this.TabelaMedicação.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Blue;
            this.TabelaMedicação.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Blue;
            this.TabelaMedicação.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.TabelaMedicação.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TabelaMedicação.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.Control;
            this.TabelaMedicação.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.SystemColors.Control;
            this.TabelaMedicação.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabelaMedicação.StateSelected.DataCell.Back.Color1 = System.Drawing.SystemColors.Control;
            this.TabelaMedicação.StateSelected.DataCell.Back.Color2 = System.Drawing.SystemColors.Control;
            this.TabelaMedicação.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MEDICAMENTO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "EFEITO COLATERAL";
            this.Column2.Name = "Column2";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 9);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.OverrideDefault.Back.Color1 = System.Drawing.Color.Blue;
            this.btnVoltar.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btnVoltar.OverrideDefault.Back.ColorAngle = 45F;
            this.btnVoltar.OverrideDefault.Border.Color1 = System.Drawing.Color.Blue;
            this.btnVoltar.OverrideDefault.Border.Color2 = System.Drawing.Color.Blue;
            this.btnVoltar.OverrideDefault.Border.ColorAngle = 45F;
            this.btnVoltar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoltar.OverrideDefault.Border.Rounding = 30;
            this.btnVoltar.OverrideDefault.Border.Width = 1;
            this.btnVoltar.OverrideDefault.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnVoltar.OverrideDefault.Content.ShortText.Color2 = System.Drawing.SystemColors.Control;
            this.btnVoltar.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnVoltar.Size = new System.Drawing.Size(129, 52);
            this.btnVoltar.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.btnVoltar.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btnVoltar.StateCommon.Back.ColorAngle = 45F;
            this.btnVoltar.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.btnVoltar.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.btnVoltar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoltar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnVoltar.StateCommon.Border.Rounding = 30;
            this.btnVoltar.StateCommon.Border.Width = 1;
            this.btnVoltar.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnVoltar.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.Control;
            this.btnVoltar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.StatePressed.Back.Color1 = System.Drawing.Color.Navy;
            this.btnVoltar.StatePressed.Back.Color2 = System.Drawing.Color.Navy;
            this.btnVoltar.StatePressed.Back.ColorAngle = 135F;
            this.btnVoltar.StatePressed.Border.Color1 = System.Drawing.Color.Navy;
            this.btnVoltar.StatePressed.Border.Color2 = System.Drawing.Color.Navy;
            this.btnVoltar.StatePressed.Border.ColorAngle = 135F;
            this.btnVoltar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoltar.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnVoltar.StatePressed.Border.Rounding = 30;
            this.btnVoltar.StatePressed.Border.Width = 1;
            this.btnVoltar.StatePressed.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnVoltar.StatePressed.Content.ShortText.Color2 = System.Drawing.SystemColors.Control;
            this.btnVoltar.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.StateTracking.Back.Color1 = System.Drawing.Color.MediumBlue;
            this.btnVoltar.StateTracking.Back.Color2 = System.Drawing.Color.MediumBlue;
            this.btnVoltar.StateTracking.Back.ColorAngle = 45F;
            this.btnVoltar.StateTracking.Border.Color1 = System.Drawing.Color.MediumBlue;
            this.btnVoltar.StateTracking.Border.Color2 = System.Drawing.Color.MediumBlue;
            this.btnVoltar.StateTracking.Border.ColorAngle = 45F;
            this.btnVoltar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoltar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnVoltar.StateTracking.Border.Rounding = 30;
            this.btnVoltar.StateTracking.Border.Width = 1;
            this.btnVoltar.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnVoltar.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.Control;
            this.btnVoltar.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Values.Text = "VOLTAR";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TabelaMedicação);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabela";
            this.Text = "Tabela";
            this.Load += new System.EventHandler(this.Tabela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaMedicação)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView TabelaMedicação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVoltar;
    }
}