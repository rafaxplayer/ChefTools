namespace ChefTools
{
    partial class DialogNewRecipe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogNewRecipe));
            this.textRecipeUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textIngredientes = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.ButtonRecipeUrl = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textRecipeName = new DevExpress.XtraEditors.TextEdit();
            this.textElaboracion = new DevExpress.XtraEditors.MemoEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textIngredientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRecipeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textElaboracion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // textRecipeUrl
            // 
            this.textRecipeUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRecipeUrl.BackColor = System.Drawing.Color.Gainsboro;
            this.textRecipeUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRecipeUrl.Location = new System.Drawing.Point(28, 442);
            this.textRecipeUrl.Name = "textRecipeUrl";
            this.textRecipeUrl.Size = new System.Drawing.Size(570, 14);
            this.textRecipeUrl.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(27, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Url";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Appearance.Options.UseFont = true;
            this.button2.Appearance.Options.UseForeColor = true;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::ChefTools.Properties.Resources.save_16x16;
            this.button2.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.button2.ImageToTextIndent = 8;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(279, 472);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "Guardar";
            this.button2.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(27, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Elaboración";
            // 
            // textIngredientes
            // 
            this.textIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIngredientes.Location = new System.Drawing.Point(28, 234);
            this.textIngredientes.Name = "textIngredientes";
            this.textIngredientes.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.textIngredientes.Properties.Appearance.Options.UseBackColor = true;
            this.textIngredientes.Size = new System.Drawing.Size(605, 71);
            this.textIngredientes.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ingredientes";
            // 
            // comboCategorias
            // 
            this.comboCategorias.BackColor = System.Drawing.Color.Gainsboro;
            this.comboCategorias.DisplayMember = "name";
            this.comboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(364, 91);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(208, 21);
            this.comboCategorias.TabIndex = 19;
            this.comboCategorias.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(276, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(265, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre Receta";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.textRecipeUrl);
            this.panelControl1.Controls.Add(this.dropDownButton1);
            this.panelControl1.Controls.Add(this.ButtonRecipeUrl);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.textElaboracion);
            this.panelControl1.Controls.Add(this.comboCategorias);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.textRecipeName);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(681, 526);
            this.panelControl1.TabIndex = 27;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dropDownButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dropDownButton1.Appearance.Options.UseFont = true;
            this.dropDownButton1.Appearance.Options.UseForeColor = true;
            this.dropDownButton1.Location = new System.Drawing.Point(99, 164);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(82, 34);
            this.dropDownButton1.TabIndex = 1;
            this.dropDownButton1.Text = "Imagen\r\n";
            // 
            // ButtonRecipeUrl
            // 
            this.ButtonRecipeUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRecipeUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRecipeUrl.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRecipeUrl.Image")));
            this.ButtonRecipeUrl.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRecipeUrl.Location = new System.Drawing.Point(606, 437);
            this.ButtonRecipeUrl.Name = "ButtonRecipeUrl";
            this.ButtonRecipeUrl.Size = new System.Drawing.Size(27, 24);
            this.ButtonRecipeUrl.TabIndex = 0;
            this.ButtonRecipeUrl.Click += new System.EventHandler(this.ButtonRecipeUrl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ChefTools.Properties.Resources.recipe_placeholder;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(28, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textRecipeName
            // 
            this.textRecipeName.Location = new System.Drawing.Point(364, 57);
            this.textRecipeName.Name = "textRecipeName";
            this.textRecipeName.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.textRecipeName.Properties.Appearance.Options.UseBackColor = true;
            this.textRecipeName.Size = new System.Drawing.Size(208, 20);
            this.textRecipeName.TabIndex = 17;
            // 
            // textElaboracion
            // 
            this.textElaboracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textElaboracion.Location = new System.Drawing.Point(28, 330);
            this.textElaboracion.Name = "textElaboracion";
            this.textElaboracion.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.textElaboracion.Properties.Appearance.Options.UseBackColor = true;
            this.textElaboracion.Size = new System.Drawing.Size(605, 77);
            this.textElaboracion.TabIndex = 23;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("image_16x16.png", "images/content/image_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/image_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "image_16x16.png");
            this.imageCollection1.InsertGalleryImage("bolocalization_16x16.png", "images/business%20objects/bolocalization_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bolocalization_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "bolocalization_16x16.png");
            // 
            // DialogNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.textIngredientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelControl1);
            this.Name = "DialogNewRecipe";
            this.Size = new System.Drawing.Size(681, 526);
            this.Load += new System.EventHandler(this.DialogNewRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textIngredientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRecipeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textElaboracion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRecipeUrl;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton button2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.MemoEdit textIngredientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.SimpleButton ButtonRecipeUrl;
        private DevExpress.XtraEditors.MemoEdit textElaboracion;
        private DevExpress.XtraEditors.TextEdit textRecipeName;
        private DevExpress.Utils.ImageCollection imageCollection1;


    }
}
