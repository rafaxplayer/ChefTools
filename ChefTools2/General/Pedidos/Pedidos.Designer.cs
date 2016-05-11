namespace ChefTools
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.splitContainerInventarios = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupPedidos = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.labelProveedor = new DevExpress.XtraEditors.LabelControl();
            this.gridControlPedido = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInventarios)).BeginInit();
            this.splitContainerInventarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPedidos)).BeginInit();
            this.groupPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerInventarios
            // 
            this.splitContainerInventarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInventarios.Location = new System.Drawing.Point(0, 0);
            this.splitContainerInventarios.Name = "splitContainerInventarios";
            this.splitContainerInventarios.Panel1.Controls.Add(this.groupPedidos);
            this.splitContainerInventarios.Panel1.Text = "Panel1";
            this.splitContainerInventarios.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerInventarios.Panel2.Text = "Panel2";
            this.splitContainerInventarios.Size = new System.Drawing.Size(728, 462);
            this.splitContainerInventarios.SplitterPosition = 339;
            this.splitContainerInventarios.TabIndex = 1;
            this.splitContainerInventarios.Text = "splitContainerControl1";
            // 
            // groupPedidos
            // 
            this.groupPedidos.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupPedidos.Appearance.Options.UseForeColor = true;
            this.groupPedidos.CaptionImage = global::ChefTools.Properties.Resources.boreport_32x32;
            this.groupPedidos.Controls.Add(this.gridControl1);
            this.groupPedidos.Controls.Add(this.buttonNewInventario);
            this.groupPedidos.Controls.Add(this.listMenus);
            this.groupPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPedidos.Location = new System.Drawing.Point(0, 0);
            this.groupPedidos.Name = "groupPedidos";
            this.groupPedidos.Size = new System.Drawing.Size(339, 462);
            this.groupPedidos.TabIndex = 5;
            this.groupPedidos.Text = "Lista de Pedidos";
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
            this.gridControl1.Size = new System.Drawing.Size(335, 390);
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
            this.colproveedor_id,
            this.colcomentario,
            this.coldate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
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
            // 
            // colproveedor_id
            // 
            this.colproveedor_id.FieldName = "proveedor_id";
            this.colproveedor_id.Name = "colproveedor_id";
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.OptionsColumn.AllowFocus = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 1;
            // 
            // coldate
            // 
            this.coldate.Caption = "Fecha";
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.OptionsColumn.AllowFocus = false;
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 2;
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
            this.buttonNewInventario.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewInventario.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonNewInventario.Appearance.Options.UseFont = true;
            this.buttonNewInventario.Appearance.Options.UseForeColor = true;
            this.buttonNewInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewInventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNewInventario.Image = global::ChefTools.Properties.Resources.addfile_32x32;
            this.buttonNewInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonNewInventario.Location = new System.Drawing.Point(2, 429);
            this.buttonNewInventario.MinimumSize = new System.Drawing.Size(135, 0);
            this.buttonNewInventario.Name = "buttonNewInventario";
            this.buttonNewInventario.Size = new System.Drawing.Size(335, 31);
            this.buttonNewInventario.TabIndex = 1;
            this.buttonNewInventario.Tag = "2";
            this.buttonNewInventario.Text = "Nuevo Pedido";
            this.buttonNewInventario.Click += new System.EventHandler(this.buttonNewPedido_Click);
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
            this.listMenus.Size = new System.Drawing.Size(328, 57);
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
            this.groupBox4.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Appearance.Options.UseBackColor = true;
            this.groupBox4.Appearance.Options.UseForeColor = true;
            this.groupBox4.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.groupBox4.Controls.Add(this.labelProveedor);
            this.groupBox4.Controls.Add(this.gridControlPedido);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Delete", global::ChefTools.Properties.Resources.deletelist2_32x32, false, true, "Eliminar"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Edit", global::ChefTools.Properties.Resources.edit_32x32, false, true, "Editar"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Print", global::ChefTools.Properties.Resources.print_32x32, false, true, "Imprimir")});
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 462);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupBoxDetalle_CustomButtonClick);
            // 
            // labelProveedor
            // 
            this.labelProveedor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelProveedor.Appearance.Image")));
            this.labelProveedor.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelProveedor.Location = new System.Drawing.Point(2, 48);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(165, 20);
            this.labelProveedor.TabIndex = 2;
            this.labelProveedor.Tag = "0";
            this.labelProveedor.Text = "Proveedor para el pedido";
            this.labelProveedor.Click += new System.EventHandler(this.labelProveedor_Click);
            // 
            // gridControlPedido
            // 
            this.gridControlPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPedido.Location = new System.Drawing.Point(2, 83);
            this.gridControlPedido.MainView = this.gridView4;
            this.gridControlPedido.Name = "gridControlPedido";
            this.gridControlPedido.Size = new System.Drawing.Size(380, 377);
            this.gridControlPedido.TabIndex = 1;
            this.gridControlPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView4.GridControl = this.gridControlPedido;
            this.gridView4.GroupPanelText = "No Definido";
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupedColumns = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Producto";
            this.gridColumn1.FieldName = "productoname";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.Caption = "Cantidad";
            this.gridColumn2.FieldName = "producto_cantidad";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Formato";
            this.gridColumn3.FieldName = "formatoname";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 462);
            this.Controls.Add(this.splitContainerInventarios);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pedidos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInventarios)).EndInit();
            this.splitContainerInventarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupPedidos)).EndInit();
            this.groupPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerInventarios;
        private DevExpress.XtraEditors.GroupControl groupPedidos;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton buttonNewInventario;
        public System.Windows.Forms.ListView listMenus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraEditors.GroupControl groupBox4;
        private DevExpress.XtraGrid.GridControl gridControlPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;



        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;


        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelProveedor;
    }
}