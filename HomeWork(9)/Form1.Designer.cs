namespace FaylMeneceri
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnQovluq = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnSaxla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.grpFayllar = new System.Windows.Forms.GroupBox();
            this.lstFayllar = new System.Windows.Forms.ListBox();
            this.lblMetn = new System.Windows.Forms.Label();
            this.txtMetn = new System.Windows.Forms.TextBox();
            this.pnlMelumat = new System.Windows.Forms.Panel();
            this.lblMelumat = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpFayllar.SuspendLayout();
            this.pnlMelumat.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQovluq
            // 
            this.btnQovluq.Location = new System.Drawing.Point(14, 14);
            this.btnQovluq.Name = "btnQovluq";
            this.btnQovluq.Size = new System.Drawing.Size(107, 27);
            this.btnQovluq.TabIndex = 0;
            this.btnQovluq.Text = "Qovluq seç";
            this.btnQovluq.UseVisualStyleBackColor = true;
            this.btnQovluq.Click += new System.EventHandler(this.btnQovluq_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(134, 14);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(107, 27);
            this.btnAc.TabIndex = 1;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnSaxla
            // 
            this.btnSaxla.Location = new System.Drawing.Point(254, 14);
            this.btnSaxla.Name = "btnSaxla";
            this.btnSaxla.Size = new System.Drawing.Size(107, 27);
            this.btnSaxla.TabIndex = 2;
            this.btnSaxla.Text = "Yadda saxla";
            this.btnSaxla.UseVisualStyleBackColor = true;
            this.btnSaxla.Click += new System.EventHandler(this.btnSaxla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(374, 14);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 27);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtYol
            // 
            this.txtYol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYol.Location = new System.Drawing.Point(494, 18);
            this.txtYol.Name = "txtYol";
            this.txtYol.ReadOnly = true;
            this.txtYol.Size = new System.Drawing.Size(212, 23);
            this.txtYol.TabIndex = 4;
            this.txtYol.Text = "C:\\Users\\...\\Documents";
            // 
            // grpFayllar
            // 
            this.grpFayllar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpFayllar.Controls.Add(this.lstFayllar);
            this.grpFayllar.Location = new System.Drawing.Point(14, 56);
            this.grpFayllar.Name = "grpFayllar";
            this.grpFayllar.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.grpFayllar.Size = new System.Drawing.Size(198, 303);
            this.grpFayllar.TabIndex = 5;
            this.grpFayllar.TabStop = false;
            this.grpFayllar.Text = "Fayllar";
            // 
            // lstFayllar
            // 
            this.lstFayllar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFayllar.FormattingEnabled = true;
            this.lstFayllar.ItemHeight = 15;
            this.lstFayllar.Location = new System.Drawing.Point(6, 19);
            this.lstFayllar.Name = "lstFayllar";
            this.lstFayllar.Size = new System.Drawing.Size(186, 278);
            this.lstFayllar.TabIndex = 0;
            this.lstFayllar.SelectedIndexChanged += new System.EventHandler(this.lstFayllar_SelectedIndexChanged);
            // 
            // lblMetn
            // 
            this.lblMetn.AutoSize = true;
            this.lblMetn.Location = new System.Drawing.Point(226, 56);
            this.lblMetn.Name = "lblMetn";
            this.lblMetn.Size = new System.Drawing.Size(35, 15);
            this.lblMetn.TabIndex = 6;
            this.lblMetn.Text = "Mətn";
            // 
            // txtMetn
            // 
            this.txtMetn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetn.Location = new System.Drawing.Point(226, 74);
            this.txtMetn.Multiline = true;
            this.txtMetn.Name = "txtMetn";
            this.txtMetn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMetn.Size = new System.Drawing.Size(480, 285);
            this.txtMetn.TabIndex = 7;
            this.txtMetn.Text = "Salam! Bu fayl mətni burada göstərilir...";
            // 
            // pnlMelumat
            // 
            this.pnlMelumat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMelumat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMelumat.Controls.Add(this.lblMelumat);
            this.pnlMelumat.Location = new System.Drawing.Point(14, 377);
            this.pnlMelumat.Name = "pnlMelumat";
            this.pnlMelumat.Size = new System.Drawing.Size(692, 38);
            this.pnlMelumat.TabIndex = 8;
            // 
            // lblMelumat
            // 
            this.lblMelumat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMelumat.Location = new System.Drawing.Point(0, 0);
            this.lblMelumat.Name = "lblMelumat";
            this.lblMelumat.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblMelumat.Size = new System.Drawing.Size(690, 36);
            this.lblMelumat.TabIndex = 0;
            this.lblMelumat.Text = "Ad: qeydler.txt     Ölçü: 2.4 KB     Yaranma tarixi: 26.10.2026";
            this.lblMelumat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 17);
            this.lblStatus.Text = "Hazırdır  |  Fayl sayı: 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMelumat);
            this.Controls.Add(this.txtMetn);
            this.Controls.Add(this.lblMetn);
            this.Controls.Add(this.grpFayllar);
            this.Controls.Add(this.txtYol);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSaxla);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnQovluq);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fayl Meneceri";
            this.grpFayllar.ResumeLayout(false);
            this.pnlMelumat.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnQovluq;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnSaxla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.GroupBox grpFayllar;
        private System.Windows.Forms.ListBox lstFayllar;
        private System.Windows.Forms.Label lblMetn;
        private System.Windows.Forms.TextBox txtMetn;
        private System.Windows.Forms.Panel pnlMelumat;
        private System.Windows.Forms.Label lblMelumat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}