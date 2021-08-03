using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace GenerateQRCodeWithLOGO
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(txtGenerate.Text);

            string path = Application.StartupPath.Replace("\\bin\\Debug", "\\") + "twitter_48px.png";
            Bitmap logo = new Bitmap(path);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            pictureEdit.Image = bitmap;
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(new Bitmap(pictureEdit.Image));
            if (result != null)
            {
                txtReader.Text = result.Text;
            }
        }
    }
}