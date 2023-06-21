namespace Disconected_Architecture_Ornek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOgrenciler = new DataGridView();
            btnDegisiklikleriKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(12, 12);
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.RowTemplate.Height = 25;
            dgvOgrenciler.Size = new Size(1208, 559);
            dgvOgrenciler.TabIndex = 0;
            // 
            // btnDegisiklikleriKaydet
            // 
            btnDegisiklikleriKaydet.Location = new Point(962, 591);
            btnDegisiklikleriKaydet.Name = "btnDegisiklikleriKaydet";
            btnDegisiklikleriKaydet.Size = new Size(258, 23);
            btnDegisiklikleriKaydet.TabIndex = 1;
            btnDegisiklikleriKaydet.Text = "DEGISIKLIKLERI KAYDET";
            btnDegisiklikleriKaydet.UseVisualStyleBackColor = true;
            btnDegisiklikleriKaydet.Click += btnDegisiklikleriKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 645);
            Controls.Add(btnDegisiklikleriKaydet);
            Controls.Add(dgvOgrenciler);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOgrenciler;
        private Button btnDegisiklikleriKaydet;
    }
}