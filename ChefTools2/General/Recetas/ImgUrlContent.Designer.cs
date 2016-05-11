namespace ChefTools
{
    partial class ImgUrlContent
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
       private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImgUrlContent));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEditUrl = new DevExpress.XtraEditors.TextEdit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Pega aqui la url de tu imagen";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton1.Location = new System.Drawing.Point(273, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(27, 24);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEditUrl
            // 
            this.textEditUrl.Location = new System.Drawing.Point(25, 36);
            this.textEditUrl.Name = "textEditUrl";
            this.textEditUrl.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.textEditUrl.Properties.Appearance.Options.UseBackColor = true;
            this.textEditUrl.Size = new System.Drawing.Size(242, 20);
            this.textEditUrl.TabIndex = 0;
            
            this.textEditUrl.Size = new System.Drawing.Size(242, 20);
            this.textEditUrl.TabIndex = 3;
            // 
            // ImgUrlContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEditUrl);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Name = "ImgUrlContent";
            this.Size = new System.Drawing.Size(321, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       private DevExpress.XtraEditors.LabelControl labelControl1;
       private DevExpress.XtraEditors.SimpleButton simpleButton1;
       public DevExpress.XtraEditors.TextEdit textEditUrl;
    }
}

