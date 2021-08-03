
namespace GenerateQRCodeWithLOGO
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.btnReader = new DevExpress.XtraEditors.SimpleButton();
            this.txtReader = new System.Windows.Forms.TextBox();
            this.txtGenerate = new System.Windows.Forms.TextBox();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(30, 12);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Size = new System.Drawing.Size(366, 363);
            this.pictureEdit.TabIndex = 0;
            // 
            // btnReader
            // 
            this.btnReader.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReader.Appearance.Options.UseFont = true;
            this.btnReader.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReader.ImageOptions.Image")));
            this.btnReader.Location = new System.Drawing.Point(610, 95);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(112, 51);
            this.btnReader.TabIndex = 2;
            this.btnReader.Text = "&Reader";
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // txtReader
            // 
            this.txtReader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReader.Location = new System.Drawing.Point(402, 12);
            this.txtReader.Multiline = true;
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(320, 77);
            this.txtReader.TabIndex = 3;
            // 
            // txtGenerate
            // 
            this.txtGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerate.Location = new System.Drawing.Point(30, 381);
            this.txtGenerate.Multiline = true;
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(366, 77);
            this.txtGenerate.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Appearance.Options.UseFont = true;
            this.btnGenerate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.ImageOptions.Image")));
            this.btnGenerate.Location = new System.Drawing.Point(260, 464);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(136, 51);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 527);
            this.Controls.Add(this.txtGenerate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtReader);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.pictureEdit);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate QR Code With LOGO ~ cOde by Pattharapol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.SimpleButton btnReader;
        private System.Windows.Forms.TextBox txtReader;
        private System.Windows.Forms.TextBox txtGenerate;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
    }
}

