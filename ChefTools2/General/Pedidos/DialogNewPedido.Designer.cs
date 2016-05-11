namespace ChefTools{
    partial class DialogNewPedido
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogNewPedido));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lookUpEditProveedores = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPedidoName = new DevExpress.XtraEditors.TextEdit();
            this.buttonCreate = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textPedidoComment = new DevExpress.XtraEditors.MemoEdit();
            this.gridControlPedido = new DevExpress.XtraGrid.GridControl();
            this.gridViewPedidoLista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpedido_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchGridLookUpEditProductos = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SpinEditCantidades = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colproduct_categoria_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_formato_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditFormatos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.newProduct = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEditProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.butDeleteLine = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditFormato = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.butNewData = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProveedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPedidoName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPedidoComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidoLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridLookUpEditProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditCantidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditFormatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.lookUpEditProveedores);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.textPedidoName);
            this.splitContainerControl1.Panel1.Controls.Add(this.buttonCreate);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.textPedidoComment);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlPedido);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(761, 517);
            this.splitContainerControl1.SplitterPosition = 207;
            this.splitContainerControl1.TabIndex = 21;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lookUpEditProveedores
            // 
            this.lookUpEditProveedores.EditValue = 1;
            this.lookUpEditProveedores.Location = new System.Drawing.Point(145, 79);
            this.lookUpEditProveedores.Name = "lookUpEditProveedores";
            this.lookUpEditProveedores.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.lookUpEditProveedores.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEditProveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProveedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Nombre", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("prov_telefono", "Telefono", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("prov_email", "Email", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("prov_direccion", "Direccion", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("comentario", "Comentario", 63, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("prov_categoria", "Categoria", 83, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditProveedores.Properties.DisplayMember = "name";
            this.lookUpEditProveedores.Properties.NullText = "";
            this.lookUpEditProveedores.Properties.ValueMember = "id";
            this.lookUpEditProveedores.Size = new System.Drawing.Size(262, 20);
            this.lookUpEditProveedores.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Proveedor \r\npara el pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre pedido";
            // 
            // textPedidoName
            // 
            this.textPedidoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPedidoName.Location = new System.Drawing.Point(145, 32);
            this.textPedidoName.Name = "textPedidoName";
            this.textPedidoName.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.textPedidoName.Properties.Appearance.Options.UseBackColor = true;
            this.textPedidoName.Size = new System.Drawing.Size(433, 20);
            this.textPedidoName.TabIndex = 25;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonCreate.Appearance.Options.UseFont = true;
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.Image = global::ChefTools.Properties.Resources.add_32x32;
            this.buttonCreate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.buttonCreate.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.buttonCreate.ImageToTextIndent = 8;
            this.buttonCreate.Location = new System.Drawing.Point(620, 35);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(125, 51);
            this.buttonCreate.TabIndex = 24;
            this.buttonCreate.Text = "Crear \r\nPedido";
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Comentarios";
            // 
            // textPedidoComment
            // 
            this.textPedidoComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPedidoComment.Location = new System.Drawing.Point(145, 114);
            this.textPedidoComment.Name = "textPedidoComment";
            this.textPedidoComment.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.textPedidoComment.Properties.Appearance.Options.UseBackColor = true;
            this.textPedidoComment.Size = new System.Drawing.Size(433, 64);
            this.textPedidoComment.TabIndex = 22;
            // 
            // gridControlPedido
            // 
            this.gridControlPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPedido.Location = new System.Drawing.Point(0, 1);
            this.gridControlPedido.MainView = this.gridViewPedidoLista;
            this.gridControlPedido.Name = "gridControlPedido";
            this.gridControlPedido.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SpinEditCantidades,
            this.LookUpEditFormatos,
            this.searchGridLookUpEditProductos});
            this.gridControlPedido.Size = new System.Drawing.Size(758, 215);
            this.gridControlPedido.TabIndex = 9;
            this.gridControlPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidoLista});
            // 
            // gridViewPedidoLista
            // 
            this.gridViewPedidoLista.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colpedido_id,
            this.colproducto_id,
            this.colproducto_cantidad,
            this.colproduct_categoria_id,
            this.colproduct_formato_id});
            this.gridViewPedidoLista.GridControl = this.gridControlPedido;
            this.gridViewPedidoLista.Name = "gridViewPedidoLista";
            this.gridViewPedidoLista.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView2_RowDeleting);
            this.gridViewPedidoLista.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            this.gridViewPedidoLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyDown);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colpedido_id
            // 
            this.colpedido_id.FieldName = "pedido_id";
            this.colpedido_id.Name = "colpedido_id";
            // 
            // colproducto_id
            // 
            this.colproducto_id.Caption = "Producto";
            this.colproducto_id.ColumnEdit = this.searchGridLookUpEditProductos;
            this.colproducto_id.FieldName = "producto_id";
            this.colproducto_id.Name = "colproducto_id";
            this.colproducto_id.Visible = true;
            this.colproducto_id.VisibleIndex = 0;
            // 
            // searchGridLookUpEditProductos
            // 
            this.searchGridLookUpEditProductos.AutoHeight = false;
            this.searchGridLookUpEditProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchGridLookUpEditProductos.DisplayMember = "name";
            this.searchGridLookUpEditProductos.Name = "searchGridLookUpEditProductos";
            this.searchGridLookUpEditProductos.ValueMember = "id";
            this.searchGridLookUpEditProductos.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Producto";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Categoria";
            this.gridColumn3.FieldName = "categorianame";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Proveedor";
            this.gridColumn4.FieldName = "proveedorname";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // colproducto_cantidad
            // 
            this.colproducto_cantidad.Caption = "Cantidad";
            this.colproducto_cantidad.ColumnEdit = this.SpinEditCantidades;
            this.colproducto_cantidad.FieldName = "producto_cantidad";
            this.colproducto_cantidad.Name = "colproducto_cantidad";
            this.colproducto_cantidad.Visible = true;
            this.colproducto_cantidad.VisibleIndex = 1;
            // 
            // SpinEditCantidades
            // 
            this.SpinEditCantidades.AutoHeight = false;
            this.SpinEditCantidades.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinEditCantidades.MaxValue = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.SpinEditCantidades.Name = "SpinEditCantidades";
            // 
            // colproduct_categoria_id
            // 
            this.colproduct_categoria_id.FieldName = "product_categoria_id";
            this.colproduct_categoria_id.Name = "colproduct_categoria_id";
            // 
            // colproduct_formato_id
            // 
            this.colproduct_formato_id.Caption = "Formato";
            this.colproduct_formato_id.ColumnEdit = this.LookUpEditFormatos;
            this.colproduct_formato_id.FieldName = "product_formato_id";
            this.colproduct_formato_id.Name = "colproduct_formato_id";
            this.colproduct_formato_id.Visible = true;
            this.colproduct_formato_id.VisibleIndex = 2;
            // 
            // LookUpEditFormatos
            // 
            this.LookUpEditFormatos.AutoHeight = false;
            this.LookUpEditFormatos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditFormatos.DisplayMember = "name";
            this.LookUpEditFormatos.Name = "LookUpEditFormatos";
            this.LookUpEditFormatos.ValueMember = "id";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.newProduct);
            this.groupControl1.Controls.Add(this.searchLookUpEditProducto);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.butDeleteLine);
            this.groupControl1.Controls.Add(this.lookUpEditFormato);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.butNewData);
            this.groupControl1.Controls.Add(this.spinEditCantidad);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 222);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(755, 80);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Gestión de Productos";
            // 
            // newProduct
            // 
            this.newProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newProduct.Image = global::ChefTools.Properties.Resources.add_16x16;
            this.newProduct.Location = new System.Drawing.Point(623, 41);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(119, 23);
            this.newProduct.TabIndex = 11;
            this.newProduct.Text = "Nuevo producto";
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // searchLookUpEditProducto
            // 
            this.searchLookUpEditProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchLookUpEditProducto.EditValue = "1";
            this.searchLookUpEditProducto.Location = new System.Drawing.Point(18, 44);
            this.searchLookUpEditProducto.Name = "searchLookUpEditProducto";
            this.searchLookUpEditProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditProducto.Properties.DisplayMember = "name";
            this.searchLookUpEditProducto.Properties.NullText = "";
            this.searchLookUpEditProducto.Properties.ValueMember = "id";
            this.searchLookUpEditProducto.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEditProducto.Size = new System.Drawing.Size(152, 20);
            this.searchLookUpEditProducto.TabIndex = 10;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID";
            this.gridColumn5.FieldName = "id";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Producto";
            this.gridColumn6.FieldName = "name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Categoria";
            this.gridColumn7.FieldName = "categorianame";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Proveedor";
            this.gridColumn8.FieldName = "proveedorname";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F);
            this.labelControl3.Location = new System.Drawing.Point(281, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 11);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Formato";
            // 
            // butDeleteLine
            // 
            this.butDeleteLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butDeleteLine.Image = ((System.Drawing.Image)(resources.GetObject("butDeleteLine.Image")));
            this.butDeleteLine.Location = new System.Drawing.Point(477, 43);
            this.butDeleteLine.Name = "butDeleteLine";
            this.butDeleteLine.Size = new System.Drawing.Size(75, 23);
            this.butDeleteLine.TabIndex = 2;
            this.butDeleteLine.Text = "Eliminar";
            this.butDeleteLine.Click += new System.EventHandler(this.butDeleteLine_Click);
            // 
            // lookUpEditFormato
            // 
            this.lookUpEditFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lookUpEditFormato.EditValue = 1;
            this.lookUpEditFormato.Location = new System.Drawing.Point(281, 44);
            this.lookUpEditFormato.Name = "lookUpEditFormato";
            this.lookUpEditFormato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFormato.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditFormato.Properties.DisplayMember = "name";
            this.lookUpEditFormato.Properties.NullText = "";
            this.lookUpEditFormato.Properties.ValueMember = "id";
            this.lookUpEditFormato.Size = new System.Drawing.Size(100, 20);
            this.lookUpEditFormato.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F);
            this.labelControl2.Location = new System.Drawing.Point(185, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 11);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Cantidad";
            // 
            // butNewData
            // 
            this.butNewData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butNewData.Image = ((System.Drawing.Image)(resources.GetObject("butNewData.Image")));
            this.butNewData.Location = new System.Drawing.Point(387, 43);
            this.butNewData.Name = "butNewData";
            this.butNewData.Size = new System.Drawing.Size(75, 23);
            this.butNewData.TabIndex = 1;
            this.butNewData.Text = "Añadir";
            this.butNewData.Click += new System.EventHandler(this.butNewLine_Click);
            // 
            // spinEditCantidad
            // 
            this.spinEditCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinEditCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCantidad.Location = new System.Drawing.Point(185, 44);
            this.spinEditCantidad.Name = "spinEditCantidad";
            this.spinEditCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCantidad.Properties.MaxValue = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.spinEditCantidad.Size = new System.Drawing.Size(80, 20);
            this.spinEditCantidad.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F);
            this.labelControl1.Location = new System.Drawing.Point(18, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 11);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Producto";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::ChefTools.Properties.Resources.add_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(447, 76);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(131, 23);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "Nuevo Proveedor";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DialogNewPedido
            // 
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "DialogNewPedido";
            this.Size = new System.Drawing.Size(761, 517);
            this.Load += new System.EventHandler(this.DialogoNewPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProveedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPedidoName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPedidoComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidoLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridLookUpEditProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditCantidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditFormatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton buttonCreate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.MemoEdit textPedidoComment;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEditCantidad;
        private DevExpress.XtraEditors.SimpleButton butDeleteLine;
        private DevExpress.XtraEditors.SimpleButton butNewData;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFormato;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textPedidoName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditProveedores;
        private System.Windows.Forms.Label label3;
        
        private DevExpress.XtraGrid.GridControl gridControlPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidoLista;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit SpinEditCantidades;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditFormatos;
        
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colpedido_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_categoria_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_formato_id;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit searchGridLookUpEditProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton newProduct;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
