namespace ChefTools
{
    partial class Inventarios
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
            this.splitContainerInventarios = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupInventarios = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonNewInventario = new DevExpress.XtraEditors.SimpleButton();
            this.listMenus = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlInventario = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInventarios)).BeginInit();
            this.splitContainerInventarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupInventarios)).BeginInit();
            this.groupInventarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerInventarios
            // 
            this.splitContainerInventarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInventarios.Location = new System.Drawing.Point(2, 2);
            this.splitContainerInventarios.Name = "splitContainerInventarios";
            this.splitContainerInventarios.Panel1.Controls.Add(this.groupInventarios);
            this.splitContainerInventarios.Panel1.Text = "Panel1";
            this.splitContainerInventarios.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerInventarios.Panel2.Text = "Panel2";
            this.splitContainerInventarios.Size = new System.Drawing.Size(865, 465);
            this.splitContainerInventarios.SplitterPosition = 407;
            this.splitContainerInventarios.TabIndex = 0;
            this.splitContainerInventarios.Text = "splitContainerControl1";
            // 
            // groupInventarios
            // 
            this.groupInventarios.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupInventarios.Appearance.Options.UseForeColor = true;
            this.groupInventarios.CaptionImage = global::ChefTools.Properties.Resources.boproductgroup_32x32;
            this.groupInventarios.Controls.Add(this.gridControl1);
            this.groupInventarios.Controls.Add(this.buttonNewInventario);
            this.groupInventarios.Controls.Add(this.listMenus);
            this.groupInventarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInventarios.Location = new System.Drawing.Point(0, 0);
            this.groupInventarios.Name = "groupInventarios";
            this.groupInventarios.Size = new System.Drawing.Size(407, 465);
            this.groupInventarios.TabIndex = 5;
            this.groupInventarios.Text = "Lista de Inventarios";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = null;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(403, 393);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.coldate,
            this.colcomentario});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.AllowFocus = false;
            this.colid.Width = 55;
            // 
            // colname
            // 
            this.colname.Caption = "Nombre";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.OptionsColumn.AllowFocus = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 103;
            // 
            // coldate
            // 
            this.coldate.Caption = "Fecha";
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.OptionsColumn.AllowEdit = false;
            this.coldate.OptionsColumn.AllowFocus = false;
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 1;
            this.coldate.Width = 103;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentarios";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.OptionsColumn.AllowFocus = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 2;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.ReadOnly = true;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "id";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // buttonNewInventario
            // 
            this.buttonNewInventario.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewInventario.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonNewInventario.Appearance.Options.UseFont = true;
            this.buttonNewInventario.Appearance.Options.UseForeColor = true;
            this.buttonNewInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewInventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNewInventario.Image = global::ChefTools.Properties.Resources.addfile_32x32;
            this.buttonNewInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonNewInventario.Location = new System.Drawing.Point(2, 432);
            this.buttonNewInventario.MinimumSize = new System.Drawing.Size(135, 0);
            this.buttonNewInventario.Name = "buttonNewInventario";
            this.buttonNewInventario.Size = new System.Drawing.Size(403, 31);
            this.buttonNewInventario.TabIndex = 1;
            this.buttonNewInventario.Tag = "2";
            this.buttonNewInventario.Text = "Nuevo Inventario";
            this.buttonNewInventario.Click += new System.EventHandler(this.buttonNewInventario_Click);
            // 
            // listMenus
            // 
            this.listMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMenus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.listMenus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listMenus.FullRowSelect = true;
            this.listMenus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listMenus.Location = new System.Drawing.Point(5, 316);
            this.listMenus.Name = "listMenus";
            this.listMenus.Size = new System.Drawing.Size(396, 60);
            this.listMenus.TabIndex = 0;
            this.listMenus.UseCompatibleStateImageBehavior = false;
            this.listMenus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 110;
            // 
            // groupBox4
            // 
            this.groupBox4.Appearance.Options.UseForeColor = true;
            this.groupBox4.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.groupBox4.Controls.Add(this.gridControlInventario);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Delete", global::ChefTools.Properties.Resources.deletelist2_32x32, false, true, "Eliminar"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Edit", global::ChefTools.Properties.Resources.edit_32x32, false, true, "Editar"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Print", global::ChefTools.Properties.Resources.print_32x32, false, true, "Imprimir")});
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 465);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupBoxDetalle_CustomButtonClick);
            // 
            // gridControlInventario
            // 
            this.gridControlInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlInventario.Location = new System.Drawing.Point(2, 45);
            this.gridControlInventario.MainView = this.gridView4;
            this.gridControlInventario.Name = "gridControlInventario";
            this.gridControlInventario.Size = new System.Drawing.Size(449, 418);
            this.gridControlInventario.TabIndex = 1;
            this.gridControlInventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnProducto,
            this.gridColumnCantidad,
            this.gridColumnFormato});
            this.gridView4.GridControl = this.gridControlInventario;
            this.gridView4.GroupPanelText = "No Definido";
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupedColumns = true;
            // 
            // gridColumnProducto
            // 
            this.gridColumnProducto.Caption = "Producto";
            this.gridColumnProducto.FieldName = "productoname";
            this.gridColumnProducto.Name = "gridColumnProducto";
            this.gridColumnProducto.OptionsColumn.AllowEdit = false;
            this.gridColumnProducto.OptionsColumn.AllowFocus = false;
            this.gridColumnProducto.Visible = true;
            this.gridColumnProducto.VisibleIndex = 0;
            // 
            // gridColumnCantidad
            // 
            this.gridColumnCantidad.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumnCantidad.Caption = "Cantidad";
            this.gridColumnCantidad.FieldName = "producto_cantidad";
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.OptionsColumn.AllowEdit = false;
            this.gridColumnCantidad.OptionsColumn.AllowFocus = false;
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 1;
            // 
            // gridColumnFormato
            // 
            this.gridColumnFormato.Caption = "Formato";
            this.gridColumnFormato.FieldName = "formatoname";
            this.gridColumnFormato.Name = "gridColumnFormato";
            this.gridColumnFormato.OptionsColumn.AllowEdit = false;
            this.gridColumnFormato.OptionsColumn.AllowFocus = false;
            this.gridColumnFormato.Visible = true;
            this.gridColumnFormato.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(873, 473);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.splitContainerInventarios);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(869, 469);
            this.panelControl2.TabIndex = 0;
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 473);
            this.Controls.Add(this.panelControl1);
            this.Name = "Inventarios";
            this.Text = "Inventarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventarios_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInventarios)).EndInit();
            this.splitContainerInventarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupInventarios)).EndInit();
            this.groupInventarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       
        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerInventarios;
        private DevExpress.XtraEditors.GroupControl groupInventarios;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton buttonNewInventario;
        public System.Windows.Forms.ListView listMenus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        
        
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraEditors.GroupControl groupBox4;
        
        private DevExpress.XtraGrid.GridControl gridControlInventario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProducto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormato;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}