namespace ChefTools
{
    partial class Ajustes
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCatRecetas = new DevExpress.XtraGrid.GridControl();
            this.gridViewCatRecetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCatProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewCatProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlFormProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewFormProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFormProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1036, 455);
            this.splitContainerControl1.SplitterPosition = 682;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(682, 455);
            this.splitContainerControl2.SplitterPosition = 315;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = global::ChefTools.Properties.Resources.tableofcontent_32x32;
            this.groupControl2.Controls.Add(this.gridControlCatRecetas);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(315, 455);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Categorias De Las Recetas";
            // 
            // gridControlCatRecetas
            // 
            this.gridControlCatRecetas.DataMember = "tbl_Recetas_categoria";
            this.gridControlCatRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCatRecetas.Location = new System.Drawing.Point(2, 39);
            this.gridControlCatRecetas.MainView = this.gridViewCatRecetas;
            this.gridControlCatRecetas.Name = "gridControlCatRecetas";
            this.gridControlCatRecetas.Size = new System.Drawing.Size(311, 414);
            this.gridControlCatRecetas.TabIndex = 0;
            this.gridControlCatRecetas.UseEmbeddedNavigator = true;
            this.gridControlCatRecetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCatRecetas});
            // 
            // gridViewCatRecetas
            // 
            this.gridViewCatRecetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewCatRecetas.GridControl = this.gridControlCatRecetas;
            this.gridViewCatRecetas.Name = "gridViewCatRecetas";
            this.gridViewCatRecetas.OptionsFind.AlwaysVisible = true;
            this.gridViewCatRecetas.Tag = "tbl_Recetas_categoria";
            this.gridViewCatRecetas.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_InitNewRow);
            this.gridViewCatRecetas.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView_RowDeleting);
            this.gridViewCatRecetas.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Categorias";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImage = global::ChefTools.Properties.Resources.tableofcontent_32x32;
            this.groupControl3.Controls.Add(this.gridControlCatProductos);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(362, 455);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Categorias De Los Productos";
            // 
            // gridControlCatProductos
            // 
            this.gridControlCatProductos.DataMember = "tbl_Productos_categoria";
            this.gridControlCatProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCatProductos.Location = new System.Drawing.Point(2, 39);
            this.gridControlCatProductos.MainView = this.gridViewCatProductos;
            this.gridControlCatProductos.Name = "gridControlCatProductos";
            this.gridControlCatProductos.Size = new System.Drawing.Size(358, 414);
            this.gridControlCatProductos.TabIndex = 0;
            this.gridControlCatProductos.UseEmbeddedNavigator = true;
            this.gridControlCatProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCatProductos});
            // 
            // gridViewCatProductos
            // 
            this.gridViewCatProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewCatProductos.GridControl = this.gridControlCatProductos;
            this.gridViewCatProductos.Name = "gridViewCatProductos";
            this.gridViewCatProductos.OptionsFind.AlwaysVisible = true;
            this.gridViewCatProductos.Tag = "tbl_Productos_categoria";
            this.gridViewCatProductos.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_InitNewRow);
            this.gridViewCatProductos.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Categorias";
            this.gridColumn4.FieldName = "name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = global::ChefTools.Properties.Resources.tableofcontent_32x32;
            this.groupControl1.Controls.Add(this.gridControlFormProductos);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(349, 455);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Formato De Los Productos";
            // 
            // gridControlFormProductos
            // 
            this.gridControlFormProductos.DataMember = "tbl_Productos_formato";
            this.gridControlFormProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFormProductos.Location = new System.Drawing.Point(2, 39);
            this.gridControlFormProductos.MainView = this.gridViewFormProductos;
            this.gridControlFormProductos.Name = "gridControlFormProductos";
            this.gridControlFormProductos.Size = new System.Drawing.Size(345, 414);
            this.gridControlFormProductos.TabIndex = 0;
            this.gridControlFormProductos.UseEmbeddedNavigator = true;
            this.gridControlFormProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFormProductos});
            // 
            // gridViewFormProductos
            // 
            this.gridViewFormProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname});
            this.gridViewFormProductos.GridControl = this.gridControlFormProductos;
            this.gridViewFormProductos.Name = "gridViewFormProductos";
            this.gridViewFormProductos.OptionsFind.AlwaysVisible = true;
            this.gridViewFormProductos.Tag = "tbl_Productos_formato";
            this.gridViewFormProductos.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_InitNewRow);
            this.gridViewFormProductos.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.AllowFocus = false;
            // 
            // colname
            // 
            this.colname.Caption = "Formatos";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1040, 459);
            this.panelControl1.TabIndex = 1;
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 459);
            this.Controls.Add(this.panelControl1);
            this.Name = "Ajustes";
            this.Text = "Ajustes";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFormProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlFormProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFormProductos;

        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlCatRecetas;

        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCatRecetas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlCatProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCatProductos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
