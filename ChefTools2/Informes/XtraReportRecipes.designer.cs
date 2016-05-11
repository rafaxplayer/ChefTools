using System.Data;
namespace ChefTools.Informes
{
    partial class XtraReportRecipes
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportRecipes));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabelCategoria = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelUrl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabelElaboracion = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPictureBoxImg = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabelIngredientes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabelName = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelCategoria,
            this.xrLabel1,
            this.xrLabelUrl,
            this.xrLabel7,
            this.xrLine3,
            this.xrLabelElaboracion,
            this.xrLabel5,
            this.xrLine1,
            this.xrPictureBoxImg,
            this.xrLine2,
            this.xrLabelIngredientes,
            this.xrLabel2});
            this.Detail.HeightF = 534.4583F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabelCategoria
            // 
            this.xrLabelCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabelCategoria.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "categorianame")});
            this.xrLabelCategoria.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabelCategoria.LocationFloat = new DevExpress.Utils.PointFloat(118.8335F, 159F);
            this.xrLabelCategoria.Name = "xrLabelCategoria";
            this.xrLabelCategoria.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabelCategoria.SizeF = new System.Drawing.SizeF(248.0001F, 23.00002F);
            this.xrLabelCategoria.StylePriority.UseBorderColor = false;
            this.xrLabelCategoria.StylePriority.UseFont = false;
            this.xrLabelCategoria.StylePriority.UsePadding = false;
            this.xrLabelCategoria.StylePriority.UseTextAlignment = false;
            this.xrLabelCategoria.Text = "Categoria ";
            this.xrLabelCategoria.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 159F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(118.8334F, 23F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.Text = "Categoria :";
            // 
            // xrLabelUrl
            // 
            this.xrLabelUrl.BorderColor = System.Drawing.Color.White;
            this.xrLabelUrl.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "url")});
            this.xrLabelUrl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabelUrl.ForeColor = System.Drawing.Color.Gray;
            this.xrLabelUrl.LocationFloat = new DevExpress.Utils.PointFloat(0F, 477.5F);
            this.xrLabelUrl.Multiline = true;
            this.xrLabelUrl.Name = "xrLabelUrl";
            this.xrLabelUrl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabelUrl.SizeF = new System.Drawing.SizeF(738.9999F, 21.95831F);
            this.xrLabelUrl.StylePriority.UseBorderColor = false;
            this.xrLabelUrl.StylePriority.UseFont = false;
            this.xrLabelUrl.StylePriority.UseForeColor = false;
            this.xrLabelUrl.StylePriority.UsePadding = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 442.9583F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(748F, 23F);
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.Text = "Url";
            // 
            // xrLine3
            // 
            this.xrLine3.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 465.9583F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLine3.SizeF = new System.Drawing.SizeF(738.9999F, 11.54167F);
            this.xrLine3.StylePriority.UseForeColor = false;
            this.xrLine3.StylePriority.UsePadding = false;
            // 
            // xrLabelElaboracion
            // 
            this.xrLabelElaboracion.BorderColor = System.Drawing.Color.White;
            this.xrLabelElaboracion.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "elaboracion")});
            this.xrLabelElaboracion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabelElaboracion.ForeColor = System.Drawing.Color.Gray;
            this.xrLabelElaboracion.LocationFloat = new DevExpress.Utils.PointFloat(0.0002543131F, 345.3958F);
            this.xrLabelElaboracion.Multiline = true;
            this.xrLabelElaboracion.Name = "xrLabelElaboracion";
            this.xrLabelElaboracion.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabelElaboracion.SizeF = new System.Drawing.SizeF(747.9998F, 83.41666F);
            this.xrLabelElaboracion.StylePriority.UseBorderColor = false;
            this.xrLabelElaboracion.StylePriority.UseFont = false;
            this.xrLabelElaboracion.StylePriority.UseForeColor = false;
            this.xrLabelElaboracion.StylePriority.UsePadding = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 310.8542F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(748F, 23F);
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.Text = "Elaboracion";
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 333.8542F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLine1.SizeF = new System.Drawing.SizeF(738.9999F, 11.54167F);
            this.xrLine1.StylePriority.UseForeColor = false;
            this.xrLine1.StylePriority.UsePadding = false;
            // 
            // xrPictureBoxImg
            // 
            this.xrPictureBoxImg.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("ImageUrl", null, "img")});
            this.xrPictureBoxImg.LocationFloat = new DevExpress.Utils.PointFloat(176.6666F, 0F);
            this.xrPictureBoxImg.Name = "xrPictureBoxImg";
            this.xrPictureBoxImg.SizeF = new System.Drawing.SizeF(388.9583F, 159F);
            this.xrPictureBoxImg.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // xrLine2
            // 
            this.xrLine2.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 218.0416F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLine2.SizeF = new System.Drawing.SizeF(738.9999F, 11.54167F);
            this.xrLine2.StylePriority.UseForeColor = false;
            this.xrLine2.StylePriority.UsePadding = false;
            // 
            // xrLabelIngredientes
            // 
            this.xrLabelIngredientes.BorderColor = System.Drawing.Color.White;
            this.xrLabelIngredientes.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ingredientes")});
            this.xrLabelIngredientes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabelIngredientes.ForeColor = System.Drawing.Color.Gray;
            this.xrLabelIngredientes.LocationFloat = new DevExpress.Utils.PointFloat(0F, 229.5833F);
            this.xrLabelIngredientes.Multiline = true;
            this.xrLabelIngredientes.Name = "xrLabelIngredientes";
            this.xrLabelIngredientes.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabelIngredientes.SizeF = new System.Drawing.SizeF(747.9999F, 81.27095F);
            this.xrLabelIngredientes.StylePriority.UseBorderColor = false;
            this.xrLabelIngredientes.StylePriority.UseFont = false;
            this.xrLabelIngredientes.StylePriority.UseForeColor = false;
            this.xrLabelIngredientes.StylePriority.UsePadding = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 195.0416F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(748F, 23F);
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.Text = "Ingredientes";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabelName});
            this.TopMargin.HeightF = 111.4583F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(600.4583F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(137.5417F, 111.4583F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.xrPictureBox1.StylePriority.UseBackColor = false;
            // 
            // xrLabelName
            // 
            this.xrLabelName.BackColor = System.Drawing.Color.SandyBrown;
            this.xrLabelName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "name")});
            this.xrLabelName.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.xrLabelName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.875F);
            this.xrLabelName.Name = "xrLabelName";
            this.xrLabelName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabelName.SizeF = new System.Drawing.SizeF(738.9999F, 62.58334F);
            this.xrLabelName.StylePriority.UseBackColor = false;
            this.xrLabelName.StylePriority.UseFont = false;
            this.xrLabelName.StylePriority.UseForeColor = false;
            this.xrLabelName.StylePriority.UsePadding = false;
            this.xrLabelName.StylePriority.UseTextAlignment = false;
            this.xrLabelName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageBreak1});
            this.BottomMargin.HeightF = 2F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(174.9999F, 10.00001F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(390.625F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Creado Por Herramientas para Chefs";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8});
            this.PageFooter.HeightF = 47.91667F;
            this.PageFooter.Name = "PageFooter";
            // 
            // XtraReportRecipes
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter});
            this.Margins = new System.Drawing.Printing.Margins(54, 48, 111, 2);
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabelName;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        
        
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabelIngredientes;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrLabelUrl;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLabel xrLabelElaboracion;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxImg;
        private DevExpress.XtraReports.UI.XRPageBreak xrPageBreak1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabelCategoria;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
