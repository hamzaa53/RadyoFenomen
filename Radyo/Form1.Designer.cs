
namespace Radyo
{
    partial class RadyoFenomen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadyoFenomen));
            this.sesSeviyesi = new System.Windows.Forms.TrackBar();
            this.oynatici = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sesSeviyesiGostergeci = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kucukSimge = new System.Windows.Forms.NotifyIcon(this.components);
            this.acilirMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pencereKontroluAcilirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.durumKontroluAcilirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sesKontroluAcilirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalDegistirAcilirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisAcilirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ses = new System.Windows.Forms.PictureBox();
            this.yerliRadyo = new System.Windows.Forms.PictureBox();
            this.dur = new System.Windows.Forms.PictureBox();
            this.yabanciRadyo = new System.Windows.Forms.PictureBox();
            this.devamEt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sesSeviyesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oynatici)).BeginInit();
            this.acilirMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yerliRadyo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yabanciRadyo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devamEt)).BeginInit();
            this.SuspendLayout();
            // 
            // sesSeviyesi
            // 
            this.sesSeviyesi.LargeChange = 10;
            this.sesSeviyesi.Location = new System.Drawing.Point(26, 155);
            this.sesSeviyesi.Maximum = 100;
            this.sesSeviyesi.Name = "sesSeviyesi";
            this.sesSeviyesi.Size = new System.Drawing.Size(344, 45);
            this.sesSeviyesi.SmallChange = 5;
            this.sesSeviyesi.TabIndex = 3;
            this.sesSeviyesi.TickFrequency = 10;
            this.sesSeviyesi.Value = 100;
            this.sesSeviyesi.Scroll += new System.EventHandler(this.sesSeviyesi_Scroll);
            // 
            // oynatici
            // 
            this.oynatici.Enabled = true;
            this.oynatici.Location = new System.Drawing.Point(-2, 221);
            this.oynatici.Name = "oynatici";
            this.oynatici.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("oynatici.OcxState")));
            this.oynatici.Size = new System.Drawing.Size(402, 190);
            this.oynatici.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mont Heavy DEMO", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-2, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 17);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sesSeviyesiGostergeci
            // 
            this.sesSeviyesiGostergeci.BackColor = System.Drawing.Color.Black;
            this.sesSeviyesiGostergeci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sesSeviyesiGostergeci.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sesSeviyesiGostergeci.Font = new System.Drawing.Font("Mont Heavy DEMO", 21.75F, System.Drawing.FontStyle.Bold);
            this.sesSeviyesiGostergeci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(0)))));
            this.sesSeviyesiGostergeci.Location = new System.Drawing.Point(307, 184);
            this.sesSeviyesiGostergeci.Name = "sesSeviyesiGostergeci";
            this.sesSeviyesiGostergeci.ReadOnly = true;
            this.sesSeviyesiGostergeci.Size = new System.Drawing.Size(100, 41);
            this.sesSeviyesiGostergeci.TabIndex = 10;
            this.sesSeviyesiGostergeci.Text = "100";
            this.sesSeviyesiGostergeci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sesSeviyesiGostergeci.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sesSeviyesiGostergeci_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(26, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 11;
            // 
            // kucukSimge
            // 
            this.kucukSimge.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.kucukSimge.BalloonTipText = "Radyo Fenomen";
            this.kucukSimge.BalloonTipTitle = "Radyo";
            this.kucukSimge.ContextMenuStrip = this.acilirMenu;
            this.kucukSimge.Icon = ((System.Drawing.Icon)(resources.GetObject("kucukSimge.Icon")));
            this.kucukSimge.Text = "Radyo Fenomen";
            this.kucukSimge.Visible = true;
            this.kucukSimge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.kucukSimge_MouseDoubleClick);
            // 
            // acilirMenu
            // 
            this.acilirMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencereKontroluAcilirMenu,
            this.durumKontroluAcilirMenu,
            this.sesKontroluAcilirMenu,
            this.kanalDegistirAcilirMenu,
            this.cikisAcilirMenu});
            this.acilirMenu.Name = "contextMenuStrip1";
            this.acilirMenu.Size = new System.Drawing.Size(158, 114);
            // 
            // pencereKontroluAcilirMenu
            // 
            this.pencereKontroluAcilirMenu.Name = "pencereKontroluAcilirMenu";
            this.pencereKontroluAcilirMenu.Size = new System.Drawing.Size(157, 22);
            this.pencereKontroluAcilirMenu.Text = "Gizle";
            this.pencereKontroluAcilirMenu.Click += new System.EventHandler(this.pencereKontroluAcilirMenu_Click);
            // 
            // durumKontroluAcilirMenu
            // 
            this.durumKontroluAcilirMenu.Name = "durumKontroluAcilirMenu";
            this.durumKontroluAcilirMenu.Size = new System.Drawing.Size(157, 22);
            this.durumKontroluAcilirMenu.Text = "Durdur";
            this.durumKontroluAcilirMenu.Click += new System.EventHandler(this.durumKontroluAcilirMenu_Click);
            // 
            // sesKontroluAcilirMenu
            // 
            this.sesKontroluAcilirMenu.Name = "sesKontroluAcilirMenu";
            this.sesKontroluAcilirMenu.Size = new System.Drawing.Size(157, 22);
            this.sesKontroluAcilirMenu.Text = "Sesi Kapat";
            this.sesKontroluAcilirMenu.Click += new System.EventHandler(this.sesKontroluAcilirMenu_Click);
            // 
            // kanalDegistirAcilirMenu
            // 
            this.kanalDegistirAcilirMenu.Name = "kanalDegistirAcilirMenu";
            this.kanalDegistirAcilirMenu.Size = new System.Drawing.Size(157, 22);
            this.kanalDegistirAcilirMenu.Text = "Yerli Kanala Geç";
            this.kanalDegistirAcilirMenu.Click += new System.EventHandler(this.kanalDegistirAcilirMenu_Click);
            // 
            // cikisAcilirMenu
            // 
            this.cikisAcilirMenu.Name = "cikisAcilirMenu";
            this.cikisAcilirMenu.Size = new System.Drawing.Size(157, 22);
            this.cikisAcilirMenu.Text = "Çıkış";
            this.cikisAcilirMenu.Click += new System.EventHandler(this.cikisAcilirMenu_Click);
            // 
            // ses
            // 
            this.ses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ses.Image = ((System.Drawing.Image)(resources.GetObject("ses.Image")));
            this.ses.Location = new System.Drawing.Point(175, 186);
            this.ses.Name = "ses";
            this.ses.Size = new System.Drawing.Size(47, 34);
            this.ses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ses.TabIndex = 8;
            this.ses.TabStop = false;
            this.ses.Click += new System.EventHandler(this.ses_Click);
            this.ses.MouseEnter += new System.EventHandler(this.ses_MouseEnter);
            this.ses.MouseLeave += new System.EventHandler(this.ses_MouseLeave);
            // 
            // yerliRadyo
            // 
            this.yerliRadyo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yerliRadyo.Image = global::Radyo.Properties.Resources.Yerli;
            this.yerliRadyo.Location = new System.Drawing.Point(270, 28);
            this.yerliRadyo.Name = "yerliRadyo";
            this.yerliRadyo.Size = new System.Drawing.Size(100, 100);
            this.yerliRadyo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yerliRadyo.TabIndex = 2;
            this.yerliRadyo.TabStop = false;
            this.yerliRadyo.Click += new System.EventHandler(this.yerliRadyo_Click);
            this.yerliRadyo.MouseEnter += new System.EventHandler(this.yerliRadyo_MouseEnter);
            this.yerliRadyo.MouseLeave += new System.EventHandler(this.yerliRadyo_MouseLeave);
            // 
            // dur
            // 
            this.dur.Image = ((System.Drawing.Image)(resources.GetObject("dur.Image")));
            this.dur.Location = new System.Drawing.Point(146, 28);
            this.dur.Name = "dur";
            this.dur.Size = new System.Drawing.Size(100, 100);
            this.dur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dur.TabIndex = 1;
            this.dur.TabStop = false;
            this.dur.Click += new System.EventHandler(this.dur_Click);
            this.dur.MouseEnter += new System.EventHandler(this.dur_MouseEnter);
            this.dur.MouseLeave += new System.EventHandler(this.dur_MouseLeave);
            // 
            // yabanciRadyo
            // 
            this.yabanciRadyo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yabanciRadyo.Image = global::Radyo.Properties.Resources.YabanciHover;
            this.yabanciRadyo.Location = new System.Drawing.Point(26, 28);
            this.yabanciRadyo.Name = "yabanciRadyo";
            this.yabanciRadyo.Size = new System.Drawing.Size(100, 100);
            this.yabanciRadyo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yabanciRadyo.TabIndex = 0;
            this.yabanciRadyo.TabStop = false;
            this.yabanciRadyo.Click += new System.EventHandler(this.yabanciRadyo_Click);
            this.yabanciRadyo.MouseEnter += new System.EventHandler(this.yabanciRadyo_MouseEnter);
            this.yabanciRadyo.MouseLeave += new System.EventHandler(this.yabanciRadyo_MouseLeave);
            // 
            // devamEt
            // 
            this.devamEt.Image = global::Radyo.Properties.Resources.Play;
            this.devamEt.Location = new System.Drawing.Point(146, 28);
            this.devamEt.Name = "devamEt";
            this.devamEt.Size = new System.Drawing.Size(100, 100);
            this.devamEt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.devamEt.TabIndex = 5;
            this.devamEt.TabStop = false;
            this.devamEt.Click += new System.EventHandler(this.devamEt_Click);
            this.devamEt.MouseEnter += new System.EventHandler(this.devamEt_MouseEnter);
            this.devamEt.MouseLeave += new System.EventHandler(this.devamEt_MouseLeave);
            // 
            // RadyoFenomen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(397, 346);
            this.Controls.Add(this.sesSeviyesiGostergeci);
            this.Controls.Add(this.ses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yerliRadyo);
            this.Controls.Add(this.yabanciRadyo);
            this.Controls.Add(this.sesSeviyesi);
            this.Controls.Add(this.oynatici);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dur);
            this.Controls.Add(this.devamEt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RadyoFenomen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadyoFenomen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sesSeviyesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oynatici)).EndInit();
            this.acilirMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yerliRadyo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yabanciRadyo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devamEt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yabanciRadyo;
        private System.Windows.Forms.PictureBox dur;
        private System.Windows.Forms.PictureBox yerliRadyo;
        private System.Windows.Forms.TrackBar sesSeviyesi;
        private AxWMPLib.AxWindowsMediaPlayer oynatici;
        private System.Windows.Forms.PictureBox devamEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sesSeviyesiGostergeci;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon kucukSimge;
        private System.Windows.Forms.ContextMenuStrip acilirMenu;
        private System.Windows.Forms.ToolStripMenuItem pencereKontroluAcilirMenu;
        private System.Windows.Forms.ToolStripMenuItem durumKontroluAcilirMenu;
        private System.Windows.Forms.ToolStripMenuItem sesKontroluAcilirMenu;
        private System.Windows.Forms.ToolStripMenuItem cikisAcilirMenu;
        private System.Windows.Forms.ToolStripMenuItem kanalDegistirAcilirMenu;
    }
}

