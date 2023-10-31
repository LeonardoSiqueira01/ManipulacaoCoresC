namespace FrmMdiPai
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.retangulo = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTextData = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHr = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblRValor = new System.Windows.Forms.Label();
            this.lblGValor = new System.Windows.Forms.Label();
            this.lblBValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // retangulo
            // 
            this.retangulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.retangulo.Location = new System.Drawing.Point(12, 71);
            this.retangulo.Name = "retangulo";
            this.retangulo.Size = new System.Drawing.Size(236, 109);
            this.retangulo.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 354);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // lblTextData
            // 
            this.lblTextData.AutoSize = true;
            this.lblTextData.Location = new System.Drawing.Point(418, 39);
            this.lblTextData.Name = "lblTextData";
            this.lblTextData.Size = new System.Drawing.Size(33, 13);
            this.lblTextData.TabIndex = 6;
            this.lblTextData.Text = "Data:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(452, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(65, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "00/00/0000";
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Location = new System.Drawing.Point(460, 53);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(49, 13);
            this.lblHr.TabIndex = 8;
            this.lblHr.Text = "00:00:00";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 195);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(236, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 246);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(236, 45);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(12, 297);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(236, 45);
            this.trackBar3.TabIndex = 11;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(254, 227);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(18, 13);
            this.lblR.TabIndex = 12;
            this.lblR.Text = "R:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(254, 278);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(18, 13);
            this.lblG.TabIndex = 13;
            this.lblG.Text = "G:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(254, 329);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 14;
            this.lblB.Text = "B:";
            // 
            // lblRValor
            // 
            this.lblRValor.AutoSize = true;
            this.lblRValor.Location = new System.Drawing.Point(274, 227);
            this.lblRValor.Name = "lblRValor";
            this.lblRValor.Size = new System.Drawing.Size(25, 13);
            this.lblRValor.TabIndex = 15;
            this.lblRValor.Text = "000";
            // 
            // lblGValor
            // 
            this.lblGValor.AutoSize = true;
            this.lblGValor.Location = new System.Drawing.Point(274, 278);
            this.lblGValor.Name = "lblGValor";
            this.lblGValor.Size = new System.Drawing.Size(25, 13);
            this.lblGValor.TabIndex = 16;
            this.lblGValor.Text = "000";
            // 
            // lblBValor
            // 
            this.lblBValor.AutoSize = true;
            this.lblBValor.Location = new System.Drawing.Point(273, 329);
            this.lblBValor.Name = "lblBValor";
            this.lblBValor.Size = new System.Drawing.Size(25, 13);
            this.lblBValor.TabIndex = 17;
            this.lblBValor.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "RGB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBValor);
            this.Controls.Add(this.lblGValor);
            this.Controls.Add(this.lblRValor);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTextData);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.retangulo);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel retangulo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTextData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblRValor;
        private System.Windows.Forms.Label lblGValor;
        private System.Windows.Forms.Label lblBValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

