namespace TugbaWinFormApp
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
            txtGirilen = new TextBox();
            btnEkle = new Button();
            cmbEklenenler = new ComboBox();
            listEklenenler = new ListBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtGirilen
            // 
            txtGirilen.Location = new Point(51, 32);
            txtGirilen.Name = "txtGirilen";
            txtGirilen.Size = new Size(504, 27);
            txtGirilen.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(601, 32);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(177, 29);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbEklenenler
            // 
            cmbEklenenler.FormattingEnabled = true;
            cmbEklenenler.Location = new Point(53, 77);
            cmbEklenenler.Name = "cmbEklenenler";
            cmbEklenenler.Size = new Size(725, 28);
            cmbEklenenler.TabIndex = 2;
            cmbEklenenler.SelectedIndexChanged += cmbEklenenler_SelectedIndexChanged;
            // 
            // listEklenenler
            // 
            listEklenenler.FormattingEnabled = true;
            listEklenenler.ItemHeight = 20;
            listEklenenler.Location = new Point(53, 144);
            listEklenenler.Name = "listEklenenler";
            listEklenenler.Size = new Size(723, 244);
            listEklenenler.TabIndex = 3;
            listEklenenler.DoubleClick += listEklenenler_DoubleClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(51, 405);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(727, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Seçimi temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(listEklenenler);
            Controls.Add(cmbEklenenler);
            Controls.Add(btnEkle);
            Controls.Add(txtGirilen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGirilen;
        private Button btnEkle;
        private ComboBox cmbEklenenler;
        private ListBox listEklenenler;
        private Button btnClear;
    }
}