namespace ChefTools
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_formato_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditFormato = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colproduct_categoria_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditCategoria = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colproduct_provider_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupRecetas = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditFormato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupRecetas)).BeginInit();
            this.groupRecetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "tbl_Productos";
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEditFormato,
            this.LookUpEditCategoria,
            this.LookUpEditProveedor});
            this.gridControl1.Size = new System.Drawing.Size(699, 406);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colproduct_formato_id,
            this.colproduct_categoria_id,
            this.colproduct_provider_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Para modificar Categoria, Proveedores y Formatos vaya a la pestaña \"Ajustes\"";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView_RowDeleting);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
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
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // colproduct_formato_id
            // 
            this.colproduct_formato_id.Caption = "Formato";
            this.colproduct_formato_id.ColumnEdit = this.LookUpEditFormato;
            this.colproduct_formato_id.FieldName = "product_formato_id";
            this.colproduct_formato_id.Name = "colproduct_formato_id";
            this.colproduct_formato_id.Visible = true;
            this.colproduct_formato_id.VisibleIndex = 1;
            // 
            // LookUpEditFormato
            // 
            this.LookUpEditFormato.AutoHeight = false;
            this.LookUpEditFormato.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditFormato.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Nombre", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LookUpEditFormato.DisplayMember = "name";
            this.LookUpEditFormato.Name = "LookUpEditFormato";
            this.LookUpEditFormato.NullText = "";
            this.LookUpEditFormato.ValueMember = "id";
            // 
            // colproduct_categoria_id
            // 
            this.colproduct_categoria_id.Caption = "Categoria";
            this.colproduct_categoria_id.ColumnEdit = this.LookUpEditCategoria;
            this.colproduct_categoria_id.FieldName = "product_categoria_id";
            this.colproduct_categoria_id.Name = "colproduct_categoria_id";
            this.colproduct_categoria_id.Visible = true;
            this.colproduct_categoria_id.VisibleIndex = 2;
            // 
            // LookUpEditCategoria
            // 
            this.LookUpEditCategoria.AutoHeight = false;
            this.LookUpEditCategoria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditCategoria.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Nombre", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LookUpEditCategoria.DisplayMember = "name";
            this.LookUpEditCategoria.Name = "LookUpEditCategoria";
            this.LookUpEditCategoria.NullText = "";
            this.LookUpEditCategoria.ValueMember = "id";
            // 
            // colproduct_provider_id
            // 
            this.colproduct_provider_id.Caption = "Proveedor";
            this.colproduct_provider_id.ColumnEdit = this.LookUpEditProveedor;
            this.colproduct_provider_id.FieldName = "product_provider_id";
            this.colproduct_provider_id.Name = "colproduct_provider_id";
            this.colproduct_provider_id.Visible = true;
            this.colproduct_provider_id.VisibleIndex = 3;
            // 
            // LookUpEditProveedor
            // 
            this.LookUpEditProveedor.AutoHeight = false;
            this.LookUpEditProveedor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditProveedor.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Nombre", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("prov_telefono", "prov_telefono", 78, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("prov_email", "prov_email", 62, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("prov_direccion", "prov_direccion", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("comentario", "comentario", 63, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("prov_categoria", "Categoria", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LookUpEditProveedor.DisplayMember = "name";
            this.LookUpEditProveedor.Name = "LookUpEditProveedor";
            this.LookUpEditProveedor.NullText = "";
            this.LookUpEditProveedor.ValueMember = "id";
            // 
            // groupRecetas
            // 
            this.groupRecetas.CaptionImage = global::ChefTools.Properties.Resources.rsz_manzana;
            this.groupRecetas.Controls.Add(this.gridControl1);
            this.groupRecetas.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Print", global::ChefTools.Properties.Resources.print_32x32, false, true, "")});
            this.groupRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupRecetas.Location = new System.Drawing.Point(2, 2);
            this.groupRecetas.Name = "groupRecetas";
            this.groupRecetas.Size = new System.Drawing.Size(703, 453);
            this.groupRecetas.TabIndex = 1;
            this.groupRecetas.Text = "Listado de Productos";
            this.groupRecetas.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl1_CustomButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupRecetas);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(707, 457);
            this.panelControl1.TabIndex = 2;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 457);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.Text = "Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Productos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditFormato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupRecetas)).EndInit();
            this.groupRecetas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupRecetas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_formato_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_categoria_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_provider_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditFormato;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditCategoria;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditProveedor;
        
        private DevExpress.XtraEditors.PanelControl panelControl1;
        
       
    }
}