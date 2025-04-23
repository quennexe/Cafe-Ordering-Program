namespace WindowsFormsApp1
{
    partial class SiparisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisForm));
            this.SiparisGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tamamlaButton = new System.Windows.Forms.Button();
            this.sıfırlaButton = new System.Windows.Forms.Button();
            this.kolaeksiButton = new System.Windows.Forms.Button();
            this.kahveeksiButton = new System.Windows.Forms.Button();
            this.msuyueksiButton = new System.Windows.Forms.Button();
            this.cayeksiButton = new System.Windows.Forms.Button();
            this.kolasayiLabel = new System.Windows.Forms.Label();
            this.kahveartiButton = new System.Windows.Forms.Button();
            this.msuyuartiButton = new System.Windows.Forms.Button();
            this.kolaartiButton = new System.Windows.Forms.Button();
            this.cayartiButton = new System.Windows.Forms.Button();
            this.msuyuLabel = new System.Windows.Forms.Label();
            this.kolaLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.caysayiLabel = new System.Windows.Forms.Label();
            this.kahvesayiLabel = new System.Windows.Forms.Label();
            this.kahveLabel = new System.Windows.Forms.Label();
            this.msuyusayiLabel = new System.Windows.Forms.Label();
            this.cayLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cikisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SiparisGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SiparisGroupBox
            // 
            this.SiparisGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SiparisGroupBox.Controls.Add(this.pictureBox1);
            this.SiparisGroupBox.Controls.Add(this.cikisButton);
            this.SiparisGroupBox.Controls.Add(this.label1);
            this.SiparisGroupBox.Controls.Add(this.tamamlaButton);
            this.SiparisGroupBox.Controls.Add(this.sıfırlaButton);
            this.SiparisGroupBox.Controls.Add(this.kolaeksiButton);
            this.SiparisGroupBox.Controls.Add(this.kahveeksiButton);
            this.SiparisGroupBox.Controls.Add(this.msuyueksiButton);
            this.SiparisGroupBox.Controls.Add(this.cayeksiButton);
            this.SiparisGroupBox.Controls.Add(this.kolasayiLabel);
            this.SiparisGroupBox.Controls.Add(this.kahveartiButton);
            this.SiparisGroupBox.Controls.Add(this.msuyuartiButton);
            this.SiparisGroupBox.Controls.Add(this.kolaartiButton);
            this.SiparisGroupBox.Controls.Add(this.cayartiButton);
            this.SiparisGroupBox.Controls.Add(this.msuyuLabel);
            this.SiparisGroupBox.Controls.Add(this.kolaLabel);
            this.SiparisGroupBox.Controls.Add(this.label7);
            this.SiparisGroupBox.Controls.Add(this.caysayiLabel);
            this.SiparisGroupBox.Controls.Add(this.kahvesayiLabel);
            this.SiparisGroupBox.Controls.Add(this.kahveLabel);
            this.SiparisGroupBox.Controls.Add(this.msuyusayiLabel);
            this.SiparisGroupBox.Controls.Add(this.cayLabel);
            this.SiparisGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SiparisGroupBox.Name = "SiparisGroupBox";
            this.SiparisGroupBox.Size = new System.Drawing.Size(327, 434);
            this.SiparisGroupBox.TabIndex = 0;
            this.SiparisGroupBox.TabStop = false;
            this.SiparisGroupBox.Text = "Sipariş";
            this.SiparisGroupBox.Enter += new System.EventHandler(this.SiparisGroupBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Made by QuennExe";
            // 
            // tamamlaButton
            // 
            this.tamamlaButton.Image = ((System.Drawing.Image)(resources.GetObject("tamamlaButton.Image")));
            this.tamamlaButton.Location = new System.Drawing.Point(108, 402);
            this.tamamlaButton.Name = "tamamlaButton";
            this.tamamlaButton.Size = new System.Drawing.Size(113, 26);
            this.tamamlaButton.TabIndex = 21;
            this.tamamlaButton.Text = "Siparişi Tamamla";
            this.tamamlaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tamamlaButton.UseVisualStyleBackColor = true;
            this.tamamlaButton.Click += new System.EventHandler(this.tamamlaButton_Click);
            // 
            // sıfırlaButton
            // 
            this.sıfırlaButton.Image = ((System.Drawing.Image)(resources.GetObject("sıfırlaButton.Image")));
            this.sıfırlaButton.Location = new System.Drawing.Point(0, 402);
            this.sıfırlaButton.Name = "sıfırlaButton";
            this.sıfırlaButton.Size = new System.Drawing.Size(113, 26);
            this.sıfırlaButton.TabIndex = 20;
            this.sıfırlaButton.Text = "Sıfırla";
            this.sıfırlaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sıfırlaButton.UseVisualStyleBackColor = true;
            this.sıfırlaButton.Click += new System.EventHandler(this.sıfırlaButton_Click);
            // 
            // kolaeksiButton
            // 
            this.kolaeksiButton.Location = new System.Drawing.Point(206, 344);
            this.kolaeksiButton.Name = "kolaeksiButton";
            this.kolaeksiButton.Size = new System.Drawing.Size(39, 26);
            this.kolaeksiButton.TabIndex = 19;
            this.kolaeksiButton.Text = "-";
            this.kolaeksiButton.UseVisualStyleBackColor = true;
            this.kolaeksiButton.Click += new System.EventHandler(this.kolaeksiButton_Click);
            // 
            // kahveeksiButton
            // 
            this.kahveeksiButton.Location = new System.Drawing.Point(206, 259);
            this.kahveeksiButton.Name = "kahveeksiButton";
            this.kahveeksiButton.Size = new System.Drawing.Size(39, 26);
            this.kahveeksiButton.TabIndex = 18;
            this.kahveeksiButton.Text = "-";
            this.kahveeksiButton.UseVisualStyleBackColor = true;
            this.kahveeksiButton.Click += new System.EventHandler(this.kahveeksiButton_Click);
            // 
            // msuyueksiButton
            // 
            this.msuyueksiButton.Location = new System.Drawing.Point(206, 303);
            this.msuyueksiButton.Name = "msuyueksiButton";
            this.msuyueksiButton.Size = new System.Drawing.Size(39, 26);
            this.msuyueksiButton.TabIndex = 17;
            this.msuyueksiButton.Text = "-";
            this.msuyueksiButton.UseVisualStyleBackColor = true;
            this.msuyueksiButton.Click += new System.EventHandler(this.msuyueksiButton_Click);
            // 
            // cayeksiButton
            // 
            this.cayeksiButton.Location = new System.Drawing.Point(206, 218);
            this.cayeksiButton.Name = "cayeksiButton";
            this.cayeksiButton.Size = new System.Drawing.Size(39, 26);
            this.cayeksiButton.TabIndex = 16;
            this.cayeksiButton.Text = "-";
            this.cayeksiButton.UseVisualStyleBackColor = true;
            this.cayeksiButton.Click += new System.EventHandler(this.cayeksiButton_Click);
            // 
            // kolasayiLabel
            // 
            this.kolasayiLabel.AutoSize = true;
            this.kolasayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolasayiLabel.Location = new System.Drawing.Point(167, 350);
            this.kolasayiLabel.Name = "kolasayiLabel";
            this.kolasayiLabel.Size = new System.Drawing.Size(18, 20);
            this.kolasayiLabel.TabIndex = 15;
            this.kolasayiLabel.Text = "0";
            // 
            // kahveartiButton
            // 
            this.kahveartiButton.Location = new System.Drawing.Point(251, 259);
            this.kahveartiButton.Name = "kahveartiButton";
            this.kahveartiButton.Size = new System.Drawing.Size(39, 26);
            this.kahveartiButton.TabIndex = 14;
            this.kahveartiButton.Text = "+";
            this.kahveartiButton.UseVisualStyleBackColor = true;
            this.kahveartiButton.Click += new System.EventHandler(this.kahveartiButton_Click);
            // 
            // msuyuartiButton
            // 
            this.msuyuartiButton.Location = new System.Drawing.Point(251, 299);
            this.msuyuartiButton.Name = "msuyuartiButton";
            this.msuyuartiButton.Size = new System.Drawing.Size(39, 26);
            this.msuyuartiButton.TabIndex = 13;
            this.msuyuartiButton.Text = "+";
            this.msuyuartiButton.UseVisualStyleBackColor = true;
            this.msuyuartiButton.Click += new System.EventHandler(this.msuyuartiButton_Click);
            // 
            // kolaartiButton
            // 
            this.kolaartiButton.Location = new System.Drawing.Point(251, 344);
            this.kolaartiButton.Name = "kolaartiButton";
            this.kolaartiButton.Size = new System.Drawing.Size(39, 26);
            this.kolaartiButton.TabIndex = 12;
            this.kolaartiButton.Text = "+";
            this.kolaartiButton.UseVisualStyleBackColor = true;
            this.kolaartiButton.Click += new System.EventHandler(this.kolaartiButton_Click);
            // 
            // cayartiButton
            // 
            this.cayartiButton.Location = new System.Drawing.Point(251, 218);
            this.cayartiButton.Name = "cayartiButton";
            this.cayartiButton.Size = new System.Drawing.Size(39, 26);
            this.cayartiButton.TabIndex = 11;
            this.cayartiButton.Text = "+";
            this.cayartiButton.UseVisualStyleBackColor = true;
            this.cayartiButton.Click += new System.EventHandler(this.cayartiButton_Click);
            // 
            // msuyuLabel
            // 
            this.msuyuLabel.AutoSize = true;
            this.msuyuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msuyuLabel.Location = new System.Drawing.Point(19, 305);
            this.msuyuLabel.Name = "msuyuLabel";
            this.msuyuLabel.Size = new System.Drawing.Size(94, 20);
            this.msuyuLabel.TabIndex = 10;
            this.msuyuLabel.Text = "Meyve Suyu";
            // 
            // kolaLabel
            // 
            this.kolaLabel.AutoSize = true;
            this.kolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaLabel.Location = new System.Drawing.Point(19, 350);
            this.kolaLabel.Name = "kolaLabel";
            this.kolaLabel.Size = new System.Drawing.Size(40, 20);
            this.kolaLabel.TabIndex = 9;
            this.kolaLabel.Text = "Kola";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(155, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adet";
            // 
            // caysayiLabel
            // 
            this.caysayiLabel.AutoSize = true;
            this.caysayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.caysayiLabel.Location = new System.Drawing.Point(167, 224);
            this.caysayiLabel.Name = "caysayiLabel";
            this.caysayiLabel.Size = new System.Drawing.Size(18, 20);
            this.caysayiLabel.TabIndex = 5;
            this.caysayiLabel.Text = "0";
            // 
            // kahvesayiLabel
            // 
            this.kahvesayiLabel.AutoSize = true;
            this.kahvesayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahvesayiLabel.Location = new System.Drawing.Point(167, 265);
            this.kahvesayiLabel.Name = "kahvesayiLabel";
            this.kahvesayiLabel.Size = new System.Drawing.Size(18, 20);
            this.kahvesayiLabel.TabIndex = 4;
            this.kahvesayiLabel.Text = "0";
            // 
            // kahveLabel
            // 
            this.kahveLabel.AutoSize = true;
            this.kahveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveLabel.Location = new System.Drawing.Point(19, 265);
            this.kahveLabel.Name = "kahveLabel";
            this.kahveLabel.Size = new System.Drawing.Size(53, 20);
            this.kahveLabel.TabIndex = 2;
            this.kahveLabel.Text = "Kahve";
            // 
            // msuyusayiLabel
            // 
            this.msuyusayiLabel.AutoSize = true;
            this.msuyusayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msuyusayiLabel.Location = new System.Drawing.Point(167, 305);
            this.msuyusayiLabel.Name = "msuyusayiLabel";
            this.msuyusayiLabel.Size = new System.Drawing.Size(18, 20);
            this.msuyusayiLabel.TabIndex = 1;
            this.msuyusayiLabel.Text = "0";
            // 
            // cayLabel
            // 
            this.cayLabel.AutoSize = true;
            this.cayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayLabel.Location = new System.Drawing.Point(19, 224);
            this.cayLabel.Name = "cayLabel";
            this.cayLabel.Size = new System.Drawing.Size(36, 20);
            this.cayLabel.TabIndex = 0;
            this.cayLabel.Text = "Çay";
            // 
            // cikisButton
            // 
            this.cikisButton.Image = ((System.Drawing.Image)(resources.GetObject("cikisButton.Image")));
            this.cikisButton.Location = new System.Drawing.Point(216, 402);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(113, 26);
            this.cikisButton.TabIndex = 23;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikisButton.UseVisualStyleBackColor = true;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 458);
            this.ControlBox = false;
            this.Controls.Add(this.SiparisGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(369, 497);
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Sipariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SiparisGroupBox.ResumeLayout(false);
            this.SiparisGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SiparisGroupBox;
        private System.Windows.Forms.Label msuyuLabel;
        private System.Windows.Forms.Label kolaLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label caysayiLabel;
        private System.Windows.Forms.Label kahvesayiLabel;
        private System.Windows.Forms.Label kahveLabel;
        private System.Windows.Forms.Label msuyusayiLabel;
        private System.Windows.Forms.Label cayLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button tamamlaButton;
        private System.Windows.Forms.Button sıfırlaButton;
        private System.Windows.Forms.Button kolaeksiButton;
        private System.Windows.Forms.Button kahveeksiButton;
        private System.Windows.Forms.Button msuyueksiButton;
        private System.Windows.Forms.Button cayeksiButton;
        private System.Windows.Forms.Label kolasayiLabel;
        private System.Windows.Forms.Button kahveartiButton;
        private System.Windows.Forms.Button msuyuartiButton;
        private System.Windows.Forms.Button kolaartiButton;
        private System.Windows.Forms.Button cayartiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

