namespace ChefTools
{
    partial class Inicio_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Form));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.recipesButton = new DevExpress.XtraBars.BarButtonItem();
            this.menusButton = new DevExpress.XtraBars.BarButtonItem();
            this.inventariosButton = new DevExpress.XtraBars.BarButtonItem();
            this.proveedoresButton = new DevExpress.XtraBars.BarButtonItem();
            this.pedidosButton = new DevExpress.XtraBars.BarButtonItem();
            this.productosButton = new DevExpress.XtraBars.BarButtonItem();
            this.ajustesButton = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.backupButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::ChefTools.Properties.Resources.ic_toolbar_large;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.recipesButton,
            this.menusButton,
            this.inventariosButton,
            this.proveedoresButton,
            this.pedidosButton,
            this.productosButton,
            this.ajustesButton,
            this.skinRibbonGalleryBarItem2,
            this.backupButton,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(746, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.barButtonItem1);
            // 
            // recipesButton
            // 
            this.recipesButton.Caption = "Recetas";
            this.recipesButton.Glyph = global::ChefTools.Properties.Resources.recipe;
            this.recipesButton.Id = 1;
            this.recipesButton.LargeWidth = 80;
            this.recipesButton.Name = "recipesButton";
            this.recipesButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.recipesButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.recipes_ItemClick);
            // 
            // menusButton
            // 
            this.menusButton.Caption = "Menus/Cartas";
            this.menusButton.Glyph = global::ChefTools.Properties.Resources.rsz_menu;
            this.menusButton.Id = 2;
            this.menusButton.LargeWidth = 90;
            this.menusButton.Name = "menusButton";
            this.menusButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.menusButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menus_ItemClick);
            // 
            // inventariosButton
            // 
            this.inventariosButton.Caption = "Inventarios";
            this.inventariosButton.Glyph = global::ChefTools.Properties.Resources.boproductgroup_32x32;
            this.inventariosButton.Id = 3;
            this.inventariosButton.LargeWidth = 90;
            this.inventariosButton.Name = "inventariosButton";
            this.inventariosButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.inventariosButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.inventariosButton_ItemClick);
            // 
            // proveedoresButton
            // 
            this.proveedoresButton.Caption = "Proveedores";
            this.proveedoresButton.Glyph = global::ChefTools.Properties.Resources.boorderitem_32x32;
            this.proveedoresButton.Id = 4;
            this.proveedoresButton.LargeWidth = 80;
            this.proveedoresButton.Name = "proveedoresButton";
            this.proveedoresButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.proveedoresButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.proveedoresButton_ItemClick);
            // 
            // pedidosButton
            // 
            this.pedidosButton.Caption = "Pedidos";
            this.pedidosButton.Glyph = global::ChefTools.Properties.Resources.boreport_32x32;
            this.pedidosButton.Id = 5;
            this.pedidosButton.LargeWidth = 80;
            this.pedidosButton.Name = "pedidosButton";
            this.pedidosButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.pedidosButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pedidosButton_ItemClick);
            // 
            // productosButton
            // 
            this.productosButton.Caption = "Productos";
            this.productosButton.Glyph = global::ChefTools.Properties.Resources.rsz_manzana;
            this.productosButton.Id = 6;
            this.productosButton.LargeWidth = 80;
            this.productosButton.Name = "productosButton";
            this.productosButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.productosButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.productosButton_ItemClick);
            // 
            // ajustesButton
            // 
            this.ajustesButton.Caption = "Ajustes";
            this.ajustesButton.Glyph = global::ChefTools.Properties.Resources.properties_32x32;
            this.ajustesButton.Id = 7;
            this.ajustesButton.LargeWidth = 80;
            this.ajustesButton.Name = "ajustesButton";
            this.ajustesButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ajustesButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ajustesButton_ItemClick);
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 9;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.skinRibbonGalleryBarItem2_GalleryItemClick);
            // 
            // backupButton
            // 
            this.backupButton.Caption = "Copias de Seguridad";
            this.backupButton.Glyph = global::ChefTools.Properties.Resources.historyitem_32x32;
            this.backupButton.Id = 10;
            this.backupButton.LargeWidth = 80;
            this.backupButton.Name = "backupButton";
            this.backupButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.backupButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.backupButton_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Acerca de...";
            this.barButtonItem1.Glyph = global::ChefTools.Properties.Resources.info_16x16;
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.LargeGlyph = global::ChefTools.Properties.Resources.info_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.about_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Appearance.Options.UseTextOptions = true;
            this.ribbonPage1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ribbonPage1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "General";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.recipesButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.menusButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.inventariosButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.proveedoresButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.pedidosButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.productosButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Appearance.Options.UseTextOptions = true;
            this.ribbonPage2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ribbonPage2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Configuracion";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ajustesButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.backupButton);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Appearance.Options.UseTextOptions = true;
            this.ribbonPage3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ribbonPage3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Apariencia";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 470);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(746, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Inicio_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 501);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Inicio_Form";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Herramientas Para Chefs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem recipesButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem menusButton;
        private DevExpress.XtraBars.BarButtonItem inventariosButton;
        private DevExpress.XtraBars.BarButtonItem proveedoresButton;
        private DevExpress.XtraBars.BarButtonItem pedidosButton;
        private DevExpress.XtraBars.BarButtonItem productosButton;
        private DevExpress.XtraBars.BarButtonItem ajustesButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem backupButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

