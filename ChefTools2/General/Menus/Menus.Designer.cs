namespace ChefTools
{
    partial class Menus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menus));
            this.splitContainerMenus = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupMenus = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblMenusCartasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonNewMenu = new DevExpress.XtraEditors.SimpleButton();
            this.listMenus = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.labelNombre = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.labelEntrantes = new DevExpress.XtraEditors.LabelControl();
            this.labelPri = new DevExpress.XtraEditors.LabelControl();
            this.labelPrimeros = new DevExpress.XtraEditors.LabelControl();
            this.labelSeg = new DevExpress.XtraEditors.LabelControl();
            this.labelSegundos = new DevExpress.XtraEditors.LabelControl();
            this.labelPos = new DevExpress.XtraEditors.LabelControl();
            this.labelPostres = new DevExpress.XtraEditors.LabelControl();
            this.labelComments = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenus)).BeginInit();
            this.splitContainerMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMenus)).BeginInit();
            this.groupMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMenusCartasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMenus
            // 
            this.splitContainerMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenus.Location = new System.Drawing.Point(2, 2);
            this.splitContainerMenus.Name = "splitContainerMenus";
            this.splitContainerMenus.Panel1.Controls.Add(this.groupMenus);
            this.splitContainerMenus.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerMenus.Size = new System.Drawing.Size(866, 471);
            this.splitContainerMenus.SplitterPosition = 379;
            this.splitContainerMenus.TabIndex = 0;
            // 
            // groupMenus
            // 
            this.groupMenus.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupMenus.Appearance.Options.UseForeColor = true;
            this.groupMenus.CaptionImage = global::ChefTools.Properties.Resources.rsz_menu;
            this.groupMenus.Controls.Add(this.gridControl1);
            this.groupMenus.Controls.Add(this.buttonNewMenu);
            this.groupMenus.Controls.Add(this.listMenus);
            this.groupMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMenus.Location = new System.Drawing.Point(0, 0);
            this.groupMenus.Name = "groupMenus";
            this.groupMenus.Size = new System.Drawing.Size(379, 471);
            this.groupMenus.TabIndex = 4;
            this.groupMenus.Text = "Lista de Menus";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = null;
            this.gridControl1.DataSource = this.tblMenusCartasBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(375, 399);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.gridView3});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.coldate});
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
            // buttonNewMenu
            // 
            this.buttonNewMenu.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewMenu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonNewMenu.Appearance.Options.UseFont = true;
            this.buttonNewMenu.Appearance.Options.UseForeColor = true;
            this.buttonNewMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNewMenu.Image = global::ChefTools.Properties.Resources.addfile_32x32;
            this.buttonNewMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonNewMenu.Location = new System.Drawing.Point(2, 438);
            this.buttonNewMenu.MinimumSize = new System.Drawing.Size(135, 0);
            this.buttonNewMenu.Name = "buttonNewMenu";
            this.buttonNewMenu.Size = new System.Drawing.Size(375, 31);
            this.buttonNewMenu.TabIndex = 1;
            this.buttonNewMenu.Tag = "2";
            this.buttonNewMenu.Text = "Nuevo Menu";
            this.buttonNewMenu.Click += new System.EventHandler(this.buttonNewMenu_Click);
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
            this.listMenus.Size = new System.Drawing.Size(623, 66);
            this.listMenus.TabIndex = 0;
            this.listMenus.UseCompatibleStateImageBehavior = false;
            this.listMenus.View = System.Windows.Forms.View.Details;
            this.listMenus.SelectedIndexChanged += new System.EventHandler(this.listMenus_SelectedIndexChanged);
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
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Print", global::ChefTools.Properties.Resources.print_32x32, false, true, "Imprimir")});
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 471);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupBox4_CustomButtonClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.labelNombre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelEntrantes, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelPri, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelPrimeros, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelSeg, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelSegundos, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.labelPos, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.labelPostres, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.labelComments, 0, 13);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 16;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 424);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(20, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Comentarios";
            // 
            // labelNombre
            // 
            this.labelNombre.Appearance.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelNombre.Appearance.Image = global::ChefTools.Properties.Resources.rsz_menu;
            this.labelNombre.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombre.AutoEllipsis = true;
            this.labelNombre.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombre.Location = new System.Drawing.Point(13, 15);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(160, 36);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Menu Nombre";
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(20, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aperitivos";
            // 
            // labelEntrantes
            // 
            this.labelEntrantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEntrantes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEntrantes.Location = new System.Drawing.Point(25, 81);
            this.labelEntrantes.Margin = new System.Windows.Forms.Padding(15, 1, 3, 5);
            this.labelEntrantes.Name = "labelEntrantes";
            this.labelEntrantes.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelEntrantes.Size = new System.Drawing.Size(0, 18);
            this.labelEntrantes.TabIndex = 7;
            // 
            // labelPri
            // 
            this.labelPri.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPri.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPri.Location = new System.Drawing.Point(20, 109);
            this.labelPri.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelPri.Name = "labelPri";
            this.labelPri.Size = new System.Drawing.Size(114, 16);
            this.labelPri.TabIndex = 8;
            this.labelPri.Text = "Primeros Platos";
            // 
            // labelPrimeros
            // 
            this.labelPrimeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrimeros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPrimeros.Location = new System.Drawing.Point(25, 126);
            this.labelPrimeros.Margin = new System.Windows.Forms.Padding(15, 1, 3, 5);
            this.labelPrimeros.Name = "labelPrimeros";
            this.labelPrimeros.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPrimeros.Size = new System.Drawing.Size(0, 18);
            this.labelPrimeros.TabIndex = 9;
            // 
            // labelSeg
            // 
            this.labelSeg.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeg.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSeg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSeg.Location = new System.Drawing.Point(20, 154);
            this.labelSeg.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelSeg.Name = "labelSeg";
            this.labelSeg.Size = new System.Drawing.Size(119, 16);
            this.labelSeg.TabIndex = 10;
            this.labelSeg.Text = "Segundos Platos";
            // 
            // labelSegundos
            // 
            this.labelSegundos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSegundos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSegundos.Location = new System.Drawing.Point(25, 171);
            this.labelSegundos.Margin = new System.Windows.Forms.Padding(15, 1, 3, 5);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelSegundos.Size = new System.Drawing.Size(0, 18);
            this.labelSegundos.TabIndex = 11;
            // 
            // labelPos
            // 
            this.labelPos.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPos.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPos.Location = new System.Drawing.Point(20, 199);
            this.labelPos.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(55, 16);
            this.labelPos.TabIndex = 12;
            this.labelPos.Text = "Postres";
            // 
            // labelPostres
            // 
            this.labelPostres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPostres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPostres.Location = new System.Drawing.Point(25, 216);
            this.labelPostres.Margin = new System.Windows.Forms.Padding(15, 1, 3, 5);
            this.labelPostres.Name = "labelPostres";
            this.labelPostres.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPostres.Size = new System.Drawing.Size(0, 18);
            this.labelPostres.TabIndex = 13;
            // 
            // labelComments
            // 
            this.labelComments.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelComments.Location = new System.Drawing.Point(25, 261);
            this.labelComments.Margin = new System.Windows.Forms.Padding(15, 1, 3, 5);
            this.labelComments.Name = "labelComments";
            this.labelComments.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelComments.Size = new System.Drawing.Size(0, 18);
            this.labelComments.TabIndex = 15;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerMenus);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(870, 475);
            this.panelControl1.TabIndex = 1;
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 475);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menus";
            this.Text = "Menus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menus_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenus)).EndInit();
            this.splitContainerMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupMenus)).EndInit();
            this.groupMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMenusCartasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private DevExpress.XtraEditors.SplitContainerControl splitContainerMenus;
        private DevExpress.XtraEditors.GroupControl groupMenus;
        private DevExpress.XtraEditors.SimpleButton buttonNewMenu;
        public System.Windows.Forms.ListView listMenus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevExpress.XtraEditors.GroupControl groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelNombre;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl labelEntrantes;
        private DevExpress.XtraEditors.LabelControl labelPri;
        private DevExpress.XtraEditors.LabelControl labelPrimeros;
        private DevExpress.XtraEditors.LabelControl labelSeg;

        private System.Windows.Forms.BindingSource tblMenusCartasBindingSource;

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelSegundos;
        private DevExpress.XtraEditors.LabelControl labelPos;
        private DevExpress.XtraEditors.LabelControl labelPostres;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl labelComments;
        private DevExpress.XtraEditors.PanelControl panelControl1;






    }
}