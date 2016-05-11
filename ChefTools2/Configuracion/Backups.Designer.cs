namespace ChefTools
{
    partial class Backups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backups));
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ListBoxBackups = new DevExpress.XtraEditors.ImageListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxBackups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dropDownButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDownButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.dropDownButton1.Location = new System.Drawing.Point(12, 281);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(97, 23);
            this.dropDownButton1.TabIndex = 1;
            this.dropDownButton1.Text = "Acciones";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "add_16x16.png");
            this.imageCollection1.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "cancel_16x16.png");
            this.imageCollection1.InsertGalleryImage("refresh_16x16.png", "images/actions/refresh_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_16x16.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "refresh_16x16.png");
            this.imageCollection1.InsertGalleryImage("historyitem_16x16.png", "images/history/historyitem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/history/historyitem_16x16.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "historyitem_16x16.png");
            // 
            // ListBoxBackups
            // 
            this.ListBoxBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxBackups.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxBackups.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBoxBackups.Appearance.Options.UseFont = true;
            this.ListBoxBackups.Appearance.Options.UseForeColor = true;
            this.ListBoxBackups.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.ListBoxBackups.ImageList = this.imageCollection1;
            this.ListBoxBackups.ItemAutoHeight = true;
            this.ListBoxBackups.ItemHeight = 30;
            this.ListBoxBackups.Location = new System.Drawing.Point(0, 1);
            this.ListBoxBackups.Name = "ListBoxBackups";
            this.ListBoxBackups.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxBackups.Size = new System.Drawing.Size(521, 263);
            this.ListBoxBackups.TabIndex = 2;
            this.ListBoxBackups.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxBackups_MouseDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(477, 281);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(33, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.ToolTip = "Explorar directorio";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(134, 286);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "NumeroMax de Copias";
            // 
            // spinEdit1
            // 
            this.spinEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(282, 284);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.spinEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(70, 20);
            this.spinEdit1.TabIndex = 5;
            this.spinEdit1.ValueChanged += new System.EventHandler(this.spinEdit1_ValueChanged);
            // 
            // Backups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 316);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ListBoxBackups);
            this.Controls.Add(this.dropDownButton1);
            this.Name = "Backups";
            this.Text = "Backups";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxBackups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.ImageListBoxControl ListBoxBackups;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
    }
}