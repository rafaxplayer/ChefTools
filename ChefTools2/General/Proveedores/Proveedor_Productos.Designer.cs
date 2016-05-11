namespace ChefTools.General.Proveedores
{
    partial class Proveedor_Productos
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_categoria_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_formato_id = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "tbl_Productos";
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(574, 391);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colproduct_categoria_id,
            this.colproduct_formato_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Para modificar Categoria, Proveedores y Formatos vaya a la pestaña \"Ajustes\"";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colname
            // 
            this.colname.Caption = "Producto";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.OptionsColumn.AllowFocus = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // colproduct_categoria_id
            // 
            this.colproduct_categoria_id.Caption = "Categoria";
            this.colproduct_categoria_id.FieldName = "categorianame";
            this.colproduct_categoria_id.Name = "colproduct_categoria_id";
            this.colproduct_categoria_id.OptionsColumn.AllowEdit = false;
            this.colproduct_categoria_id.OptionsColumn.AllowFocus = false;
            this.colproduct_categoria_id.Visible = true;
            this.colproduct_categoria_id.VisibleIndex = 2;
            // 
            // colproduct_formato_id
            // 
            this.colproduct_formato_id.Caption = "Formato";
            this.colproduct_formato_id.FieldName = "formatoname";
            this.colproduct_formato_id.Name = "colproduct_formato_id";
            this.colproduct_formato_id.OptionsColumn.AllowEdit = false;
            this.colproduct_formato_id.OptionsColumn.AllowFocus = false;
            this.colproduct_formato_id.Visible = true;
            this.colproduct_formato_id.VisibleIndex = 1;
            // 
            // Proveedor_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Proveedor_Productos";
            this.Size = new System.Drawing.Size(574, 391);
            this.Load += new System.EventHandler(this.ProveedorDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_formato_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_categoria_id;
    }
}
