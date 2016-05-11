namespace ChefTools
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupBox3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlProveedores = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprov_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprov_telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprov_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprov_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.labelNombre = new DevExpress.XtraEditors.LabelControl();
            this.labelTelefono = new DevExpress.XtraEditors.LabelControl();
            this.labelPri = new DevExpress.XtraEditors.LabelControl();
            this.labelEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelDir = new DevExpress.XtraEditors.LabelControl();
            this.labelDireccion = new DevExpress.XtraEditors.LabelControl();
            this.labelCat = new DevExpress.XtraEditors.LabelControl();
            this.labelCategoria = new DevExpress.XtraEditors.LabelControl();
            this.labelComments = new DevExpress.XtraEditors.LabelControl();
            this.labelTel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(843, 483);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(839, 479);
            this.splitContainerControl1.SplitterPosition = 313;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupBox3
            // 
            this.groupBox3.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Appearance.Options.UseForeColor = true;
            this.groupBox3.CaptionImage = global::ChefTools.Properties.Resources.boorderitem_32x32;
            this.groupBox3.Controls.Add(this.gridControlProveedores);
            this.groupBox3.Controls.Add(this.buttonNewInventario);
            this.groupBox3.Controls.Add(this.listMenus);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 479);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.Text = "Lista de Proveedores";
            // 
            // gridControlProveedores
            // 
            this.gridControlProveedores.DataMember = "tbl_Proveedores";
            this.gridControlProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProveedores.Location = new System.Drawing.Point(2, 39);
            this.gridControlProveedores.MainView = this.gridView1;
            this.gridControlProveedores.Name = "gridControlProveedores";
            this.gridControlProveedores.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1});
            this.gridControlProveedores.Size = new System.Drawing.Size(309, 407);
            this.gridControlProveedores.TabIndex = 3;
            this.gridControlProveedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colprov_categoria,
            this.colprov_telefono,
            this.colprov_email,
            this.colprov_direccion,
            this.colcomentario});
            this.gridView1.GridControl = this.gridControlProveedores;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colname
            // 
            this.colname.Caption = "Proveedor";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.OptionsColumn.AllowFocus = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 52;
            // 
            // colprov_categoria
            // 
            this.colprov_categoria.Caption = "Categoria";
            this.colprov_categoria.FieldName = "prov_categoria";
            this.colprov_categoria.Name = "colprov_categoria";
            this.colprov_categoria.OptionsColumn.AllowEdit = false;
            this.colprov_categoria.OptionsColumn.AllowFocus = false;
            this.colprov_categoria.Visible = true;
            this.colprov_categoria.VisibleIndex = 1;
            this.colprov_categoria.Width = 48;
            // 
            // colprov_telefono
            // 
            this.colprov_telefono.Caption = "Telefono";
            this.colprov_telefono.FieldName = "prov_telefono";
            this.colprov_telefono.Name = "colprov_telefono";
            this.colprov_telefono.OptionsColumn.AllowEdit = false;
            this.colprov_telefono.OptionsColumn.AllowFocus = false;
            this.colprov_telefono.Width = 40;
            // 
            // colprov_email
            // 
            this.colprov_email.Caption = "Email";
            this.colprov_email.FieldName = "prov_email";
            this.colprov_email.Name = "colprov_email";
            this.colprov_email.OptionsColumn.AllowEdit = false;
            this.colprov_email.OptionsColumn.AllowFocus = false;
            this.colprov_email.Width = 56;
            // 
            // colprov_direccion
            // 
            this.colprov_direccion.Caption = "Dirección";
            this.colprov_direccion.FieldName = "prov_direccion";
            this.colprov_direccion.Name = "colprov_direccion";
            this.colprov_direccion.OptionsColumn.AllowEdit = false;
            this.colprov_direccion.OptionsColumn.AllowFocus = false;
            this.colprov_direccion.Width = 77;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Notas";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.OptionsColumn.AllowFocus = false;
            this.colcomentario.Width = 100;
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
            this.gridView2.GridControl = this.gridControlProveedores;
            this.gridView2.Name = "gridView2";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlProveedores;
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
            this.buttonNewInventario.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewInventario.Image")));
            this.buttonNewInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonNewInventario.Location = new System.Drawing.Point(2, 446);
            this.buttonNewInventario.MinimumSize = new System.Drawing.Size(135, 0);
            this.buttonNewInventario.Name = "buttonNewInventario";
            this.buttonNewInventario.Size = new System.Drawing.Size(309, 31);
            this.buttonNewInventario.TabIndex = 1;
            this.buttonNewInventario.Tag = "2";
            this.buttonNewInventario.Text = "Nuevo Proveedor";
            this.buttonNewInventario.Click += new System.EventHandler(this.buttonNewProvvedor_Click);
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
            this.listMenus.Size = new System.Drawing.Size(302, 74);
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
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Delete", global::ChefTools.Properties.Resources.deletelist2_32x32, false, true, "Eliminar"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Edit", global::ChefTools.Properties.Resources.edit_32x32, false, true, "Editar"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Print", global::ChefTools.Properties.Resources.print_32x32, false, true, "Imprimir"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Productos", global::ChefTools.Properties.Resources.rsz_manzana, false, true, "Productos de este proveedor")});
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 479);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupBox4_CustomButtonClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 497F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.labelNombre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelTelefono, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelPri, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelEmail, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelDir, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelDireccion, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.labelCat, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.labelCategoria, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.labelComments, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.labelTel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 15;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(517, 432);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Comentarios";
            // 
            // labelNombre
            // 
            this.labelNombre.Appearance.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelNombre.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelNombre.Appearance.Image")));
            this.labelNombre.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombre.AutoEllipsis = true;
            this.labelNombre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelNombre.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombre.Location = new System.Drawing.Point(13, 15);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(130, 36);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Proveedor";
            // 
            // labelTelefono
            // 
            this.labelTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTelefono.Location = new System.Drawing.Point(30, 85);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(20, 1, 3, 5);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelTelefono.Size = new System.Drawing.Size(12, 18);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "...";
            // 
            // labelPri
            // 
            this.labelPri.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPri.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPri.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelPri.Appearance.Image")));
            this.labelPri.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelPri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPri.Location = new System.Drawing.Point(25, 113);
            this.labelPri.Margin = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.labelPri.Name = "labelPri";
            this.labelPri.Size = new System.Drawing.Size(60, 20);
            this.labelPri.TabIndex = 8;
            this.labelPri.Text = "EMail";
            // 
            // labelEmail
            // 
            this.labelEmail.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEmail.Location = new System.Drawing.Point(30, 134);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(20, 1, 3, 5);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(12, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "...";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // labelDir
            // 
            this.labelDir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelDir.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDir.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDir.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelDir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDir.Location = new System.Drawing.Point(25, 157);
            this.labelDir.Margin = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(66, 16);
            this.labelDir.TabIndex = 10;
            this.labelDir.Text = "Dirección";
            // 
            // labelDireccion
            // 
            this.labelDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDireccion.Location = new System.Drawing.Point(30, 174);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(20, 1, 3, 5);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelDireccion.Size = new System.Drawing.Size(12, 18);
            this.labelDireccion.TabIndex = 11;
            this.labelDireccion.Text = "...";
            // 
            // labelCat
            // 
            this.labelCat.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCat.Location = new System.Drawing.Point(25, 202);
            this.labelCat.Margin = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(71, 16);
            this.labelCat.TabIndex = 12;
            this.labelCat.Text = "Categoria";
            // 
            // labelCategoria
            // 
            this.labelCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCategoria.Location = new System.Drawing.Point(30, 219);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(20, 1, 3, 5);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelCategoria.Size = new System.Drawing.Size(12, 18);
            this.labelCategoria.TabIndex = 13;
            this.labelCategoria.Text = "...";
            // 
            // labelComments
            // 
            this.labelComments.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelComments.Location = new System.Drawing.Point(30, 264);
            this.labelComments.Margin = new System.Windows.Forms.Padding(20, 1, 3, 15);
            this.labelComments.Name = "labelComments";
            this.labelComments.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelComments.Size = new System.Drawing.Size(12, 18);
            this.labelComments.TabIndex = 15;
            this.labelComments.Text = "...";
            // 
            // labelTel
            // 
            this.labelTel.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTel.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelTel.Appearance.Image")));
            this.labelTel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelTel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelTel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTel.Location = new System.Drawing.Point(25, 64);
            this.labelTel.Margin = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(83, 20);
            this.labelTel.TabIndex = 6;
            this.labelTel.Text = "Telefono";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 483);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Proveedores_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupBox3;
        private DevExpress.XtraGrid.GridControl gridControlProveedores;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelNombre;
        private DevExpress.XtraEditors.LabelControl labelTel;
        private DevExpress.XtraEditors.LabelControl labelTelefono;
        private DevExpress.XtraEditors.LabelControl labelPri;
        private DevExpress.XtraEditors.LabelControl labelEmail;
        private DevExpress.XtraEditors.LabelControl labelDir;
        private DevExpress.XtraEditors.LabelControl labelDireccion;
        private DevExpress.XtraEditors.LabelControl labelCat;
        private DevExpress.XtraEditors.LabelControl labelCategoria;
        
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colprov_telefono;
        private DevExpress.XtraGrid.Columns.GridColumn colprov_email;
        private DevExpress.XtraGrid.Columns.GridColumn colprov_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colprov_categoria;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl labelComments;
    }
}