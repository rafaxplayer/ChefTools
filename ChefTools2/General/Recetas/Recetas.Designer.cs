namespace ChefTools
{
    partial class Recetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recetas));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupRecetas = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonNewRecipe = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIngredientes = new System.Windows.Forms.Label();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.pictureRecipe = new DevExpress.XtraEditors.PictureEdit();
            this.labelRecipeName = new System.Windows.Forms.Label();
            this.labelCats = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.labelElaboracion = new System.Windows.Forms.Label();
            this.labelTitleUrl = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupRecetas)).BeginInit();
            this.groupRecetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRecipe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupRecetas);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(790, 499);
            this.splitContainerControl1.SplitterPosition = 399;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupRecetas
            // 
            this.groupRecetas.CaptionImage = global::ChefTools.Properties.Resources.tableofcontent_32x32;
            this.groupRecetas.Controls.Add(this.gridControl1);
            this.groupRecetas.Controls.Add(this.buttonNewRecipe);
            this.groupRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupRecetas.Location = new System.Drawing.Point(0, 0);
            this.groupRecetas.Name = "groupRecetas";
            this.groupRecetas.Size = new System.Drawing.Size(399, 499);
            this.groupRecetas.TabIndex = 0;
            this.groupRecetas.Text = "Lista De Recetas";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(395, 424);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnImage,
            this.gridColumnName,
            this.gridColumnCat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.RowHeight = 50;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumnId
            // 
            this.gridColumnId.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gridColumnId.AppearanceCell.Options.UseFont = true;
            this.gridColumnId.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gridColumnId.AppearanceHeader.Options.UseFont = true;
            this.gridColumnId.Caption = "ID";
            this.gridColumnId.FieldName = "id";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.OptionsColumn.AllowEdit = false;
            this.gridColumnId.OptionsColumn.AllowFocus = false;
            // 
            // gridColumnImage
            // 
            this.gridColumnImage.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnImage.AppearanceHeader.Options.UseFont = true;
            this.gridColumnImage.Caption = "Imagen";
            this.gridColumnImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumnImage.FieldName = "imagen";
            this.gridColumnImage.Name = "gridColumnImage";
            this.gridColumnImage.OptionsColumn.AllowEdit = false;
            this.gridColumnImage.OptionsColumn.AllowFocus = false;
            this.gridColumnImage.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumnImage.Visible = true;
            this.gridColumnImage.VisibleIndex = 0;
            this.gridColumnImage.Width = 95;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.ErrorImage = global::ChefTools.Properties.Resources.recipe_placeholder;
            this.repositoryItemPictureEdit1.InitialImage = global::ChefTools.Properties.Resources.recipe_placeholder;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.Padding = new System.Windows.Forms.Padding(2);
            this.repositoryItemPictureEdit1.ReadOnly = true;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gridColumnName.AppearanceCell.Options.UseFont = true;
            this.gridColumnName.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnName.Caption = "Nombre";
            this.gridColumnName.FieldName = "name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 80;
            // 
            // gridColumnCat
            // 
            this.gridColumnCat.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gridColumnCat.AppearanceCell.Options.UseFont = true;
            this.gridColumnCat.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnCat.AppearanceHeader.Options.UseFont = true;
            this.gridColumnCat.Caption = "Categoria";
            this.gridColumnCat.FieldName = "categorianame";
            this.gridColumnCat.Name = "gridColumnCat";
            this.gridColumnCat.OptionsColumn.AllowEdit = false;
            this.gridColumnCat.OptionsColumn.AllowFocus = false;
            this.gridColumnCat.Visible = true;
            this.gridColumnCat.VisibleIndex = 2;
            // 
            // buttonNewRecipe
            // 
            this.buttonNewRecipe.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRecipe.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonNewRecipe.Appearance.Options.UseFont = true;
            this.buttonNewRecipe.Appearance.Options.UseForeColor = true;
            this.buttonNewRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewRecipe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNewRecipe.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewRecipe.Image")));
            this.buttonNewRecipe.Location = new System.Drawing.Point(2, 463);
            this.buttonNewRecipe.Name = "buttonNewRecipe";
            this.buttonNewRecipe.Size = new System.Drawing.Size(395, 34);
            this.buttonNewRecipe.TabIndex = 0;
            this.buttonNewRecipe.Text = "Nueva Receta";
            this.buttonNewRecipe.Click += new System.EventHandler(this.buttonNewRecipe_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AutoSize = true;
            this.groupControl2.Controls.Add(this.tableLayoutPanel1);
            this.groupControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Delete", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons"))), false, true, "Eliminar"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Edit", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons1"))), false, true, "Editar"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Print", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons2"))), false, true, "Imprimir")});
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(386, 499);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupBoxDetalle_CustomButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelIngredientes, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureRecipe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRecipeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCats, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCategoria, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelElaboracion, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelTitleUrl, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelUrl, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 45);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 452);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelIngredientes
            // 
            this.labelIngredientes.AutoSize = true;
            this.labelIngredientes.Location = new System.Drawing.Point(8, 248);
            this.labelIngredientes.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.labelIngredientes.Name = "labelIngredientes";
            this.labelIngredientes.Size = new System.Drawing.Size(27, 13);
            this.labelIngredientes.TabIndex = 5;
            this.labelIngredientes.Text = ".....";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Location = new System.Drawing.Point(8, 226);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ingredientes";
            // 
            // pictureRecipe
            // 
            this.pictureRecipe.EditValue = global::ChefTools.Properties.Resources.recipe_placeholder;
            this.pictureRecipe.Location = new System.Drawing.Point(5, 5);
            this.pictureRecipe.Margin = new System.Windows.Forms.Padding(5);
            this.pictureRecipe.Name = "pictureRecipe";
            this.pictureRecipe.Properties.ErrorImage = global::ChefTools.Properties.Resources.recipe_placeholder;
            this.pictureRecipe.Properties.InitialImage = global::ChefTools.Properties.Resources.recipe_placeholder;
            this.pictureRecipe.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureRecipe.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureRecipe.Size = new System.Drawing.Size(247, 123);
            this.pictureRecipe.TabIndex = 0;
            // 
            // labelRecipeName
            // 
            this.labelRecipeName.AutoEllipsis = true;
            this.labelRecipeName.AutoSize = true;
            this.labelRecipeName.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecipeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelRecipeName.Location = new System.Drawing.Point(8, 141);
            this.labelRecipeName.Margin = new System.Windows.Forms.Padding(8);
            this.labelRecipeName.Name = "labelRecipeName";
            this.labelRecipeName.Size = new System.Drawing.Size(144, 18);
            this.labelRecipeName.TabIndex = 1;
            this.labelRecipeName.Text = "Nombre Receta";
            // 
            // labelCats
            // 
            this.labelCats.AutoSize = true;
            this.labelCats.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCats.Location = new System.Drawing.Point(8, 175);
            this.labelCats.Margin = new System.Windows.Forms.Padding(8);
            this.labelCats.Name = "labelCats";
            this.labelCats.Size = new System.Drawing.Size(69, 13);
            this.labelCats.TabIndex = 2;
            this.labelCats.Text = "Categoria";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(8, 197);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(27, 13);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = ".....";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSize = true;
            this.labelControl2.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Location = new System.Drawing.Point(8, 277);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Elaboracion";
            // 
            // labelElaboracion
            // 
            this.labelElaboracion.AutoSize = true;
            this.labelElaboracion.Location = new System.Drawing.Point(10, 299);
            this.labelElaboracion.Margin = new System.Windows.Forms.Padding(10, 0, 8, 8);
            this.labelElaboracion.Name = "labelElaboracion";
            this.labelElaboracion.Size = new System.Drawing.Size(27, 13);
            this.labelElaboracion.TabIndex = 7;
            this.labelElaboracion.Text = ".....";
            // 
            // labelTitleUrl
            // 
            this.labelTitleUrl.AutoSize = true;
            this.labelTitleUrl.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleUrl.Location = new System.Drawing.Point(8, 328);
            this.labelTitleUrl.Margin = new System.Windows.Forms.Padding(8);
            this.labelTitleUrl.Name = "labelTitleUrl";
            this.labelTitleUrl.Size = new System.Drawing.Size(26, 13);
            this.labelTitleUrl.TabIndex = 8;
            this.labelTitleUrl.Text = "Url";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.ForeColor = System.Drawing.Color.Blue;
            this.labelUrl.Location = new System.Drawing.Point(10, 351);
            this.labelUrl.Margin = new System.Windows.Forms.Padding(10, 0, 8, 8);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(27, 13);
            this.labelUrl.TabIndex = 9;
            this.labelUrl.Text = ".....";
            this.labelUrl.Click += new System.EventHandler(this.labelUrl_Click);
            // 
            // Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 499);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Recetas";
            this.Text = "Recetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Recetas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupRecetas)).EndInit();
            this.groupRecetas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRecipe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupRecetas;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton buttonNewRecipe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelIngredientes;
        private System.Windows.Forms.Label labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureRecipe;
        private System.Windows.Forms.Label labelRecipeName;
        private System.Windows.Forms.Label labelCats;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelControl2;
        private System.Windows.Forms.Label labelElaboracion;
        private System.Windows.Forms.Label labelTitleUrl;
        private System.Windows.Forms.Label labelUrl;

    }
}