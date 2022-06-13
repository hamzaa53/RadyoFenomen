using System;
using System.Drawing;
using System.Windows.Forms;

namespace Radyo
{
    public partial class RadyoFenomen : Form
    {
        public RadyoFenomen()
        {
            InitializeComponent();
        }

        string seciliRadyo = "Yabanci";
        private void Form1_Load(object sender, EventArgs e)
        {
            oynatici.URL = "https://listen.radyofenomen.com/fenomen/128/icecast.audio";
            oynatici.settings.volume = sesSeviyesi.Value;
            dur.Image = Properties.Resources.Pause;
        }

        int yesil = 0;
        int kirmizi = 250;
        private void sesSeviyesi_Scroll(object sender, EventArgs e)
        {
            if (sesSeviyesi.Value == 0)
            {
                susturuldu = true;
                oncekiSesSeviyesi = 100;
                ses.Image = Properties.Resources.Mute;
            }
            else if (sesSeviyesi.Value != 0)
            {
                susturuldu = false;
                ses.Image = Properties.Resources.UnMute;
            }

            if (sesSeviyesi.Value < 50)
            {
                kirmizi = (250 + sesSeviyesi.Value * 5) - 250;
                yesil = 250;
            }
            else if (sesSeviyesi.Value == 50)
            {
                kirmizi = 250;
                yesil = 250;
            }
            else if (sesSeviyesi.Value > 50)
            {
                yesil = 250 + (250 - sesSeviyesi.Value * 5);
                kirmizi = 250;
            }

            oynatici.settings.volume = sesSeviyesi.Value;
            sesSeviyesiGostergeci.Text = sesSeviyesi.Value.ToString();
            sesSeviyesiGostergeci.ForeColor = Color.FromArgb(yesil, kirmizi, 0);
        }

        bool susturuldu = false;
        private void ses_Click(object sender, EventArgs e)
        {
            if (!susturuldu) SesiKapat(); else SesiAc();
        }

        int oncekiSesSeviyesi;
        private void SesiKapat()
        {
            oncekiSesSeviyesi = sesSeviyesi.Value;
            susturuldu = true;
            sesSeviyesi.Value = 0;
            oynatici.settings.volume = 0;
            sesKontroluAcilirMenu.Text = "Sesi Aç";
            sesSeviyesiGostergeci.Text = sesSeviyesi.Value.ToString();
            sesSeviyesiGostergeci.ForeColor = Color.FromArgb(250, 0, 0);
        }
        private void SesiAc()
        {
            sesSeviyesi.Value = oncekiSesSeviyesi;
            susturuldu = false;
            ses.Image = Properties.Resources.UnMute;
            sesKontroluAcilirMenu.Text = "Sesi Kapat";
            oynatici.settings.volume = sesSeviyesi.Value;
            sesSeviyesiGostergeci.Text = sesSeviyesi.Value.ToString();
            if (oncekiSesSeviyesi == 100)
                sesSeviyesiGostergeci.ForeColor = Color.FromArgb(0, 250, 0);
            else
                sesSeviyesiGostergeci.ForeColor = Color.FromArgb(yesil, kirmizi, 0);
        }

        private void yabanciRadyo_Click(object sender, EventArgs e)
        {
            YabanciKanalaGec();
        }

        private void yerliRadyo_Click(object sender, EventArgs e)
        {
            YerliKanalaGec();
        }

        private void yabanciRadyo_MouseEnter(object sender, EventArgs e)
        {
            yabanciRadyo.Image = Properties.Resources.YabanciHover;
        }

        private void yabanciRadyo_MouseLeave(object sender, EventArgs e)
        {
            if (seciliRadyo != "Yabanci")
                yabanciRadyo.Image = Properties.Resources.Yabanci;
        }

        private void yerliRadyo_MouseEnter(object sender, EventArgs e)
        {
            yerliRadyo.Image = Properties.Resources.YerliHover;
        }

        private void yerliRadyo_MouseLeave(object sender, EventArgs e)
        {
            if (seciliRadyo != "Yerli")
                yerliRadyo.Image = Properties.Resources.Yerli;
        }

        bool durduruldu = false;
        private void devamEt_Click(object sender, EventArgs e)
        {
            DevamEt();
        }

        private void devamEt_MouseEnter(object sender, EventArgs e)
        {
            devamEt.Image = Properties.Resources.PlayHover;
        }

        private void devamEt_MouseLeave(object sender, EventArgs e)
        {
            devamEt.Image = Properties.Resources.Play;
        }

        private void dur_Click(object sender, EventArgs e)
        {
            Durdur();
        }

        private void dur_MouseEnter(object sender, EventArgs e)
        {
            dur.Image = Properties.Resources.PauseHover;
        }

        private void dur_MouseLeave(object sender, EventArgs e)
        {
            dur.Image = Properties.Resources.Pause;
        }

        private void ses_MouseEnter(object sender, EventArgs e)
        {
            if (!susturuldu) ses.Image = Properties.Resources.Mute;
        }
        private void ses_MouseLeave(object sender, EventArgs e)
        {
            if (!susturuldu) ses.Image = Properties.Resources.UnMute;
        }

        private void sesSeviyesiGostergeci_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Focus();
        }

        private void kucukSimge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gosterildi) Gizle(); else Goster();
        }

        bool gosterildi = true;
        private void pencereKontroluAcilirMenu_Click(object sender, EventArgs e)
        {
            if (gosterildi) Gizle(); else Goster();
        }

        private void Goster()
        {
            this.WindowState = FormWindowState.Normal;
            pencereKontroluAcilirMenu.Text = "Gizle";
            gosterildi = true;
            Show();
        }

        private void Gizle()
        {
            pencereKontroluAcilirMenu.Text = "Göster";
            gosterildi = false;
            Hide();
        }

        private void durumKontroluAcilirMenu_Click(object sender, EventArgs e)
        {
            if (durduruldu) DevamEt(); else Durdur();
        }

        private void DevamEt()
        {
            durumKontroluAcilirMenu.Text = "Durdur";
            oynatici.Ctlcontrols.play();
            devamEt.SendToBack();
            durduruldu = false;
        }

        private void Durdur()
        {
            durumKontroluAcilirMenu.Text = "Devam Et";
            oynatici.Ctlcontrols.pause();
            dur.SendToBack();
            durduruldu = true;
        }

        private void sesKontroluAcilirMenu_Click(object sender, EventArgs e)
        {
            if (!susturuldu) SesiKapat(); else SesiAc();
        }

        private void kanalDegistirAcilirMenu_Click(object sender, EventArgs e)
        {
            if (seciliRadyo == "Yabanci") YerliKanalaGec(); else YabanciKanalaGec();
        }

        private void YabanciKanalaGec()
        {
            oynatici.URL = "https://listen.radyofenomen.com/fenomen/128/icecast.audio";
            kanalDegistirAcilirMenu.Text = "Yerli Kanala Geç";
            yabanciRadyo.Image = Properties.Resources.YabanciHover;
            kucukSimge.Icon = Properties.Resources.YabanciIcon;
            yerliRadyo.Image = Properties.Resources.Yerli;
            Icon = Properties.Resources.YabanciIcon;
            seciliRadyo = "Yabanci";
            devamEt.SendToBack();
        }

        private void YerliKanalaGec()
        {
            oynatici.URL = "https://listen.radyofenomen.com/fenomenturk/128/icecast.audio";
            kanalDegistirAcilirMenu.Text = "Yabancı Kanala Geç";
            yerliRadyo.Image = Properties.Resources.YerliHover;
            yabanciRadyo.Image = Properties.Resources.Yabanci;
            kucukSimge.Icon = Properties.Resources.YerliIcon;
            Icon = Properties.Resources.YerliIcon;
            seciliRadyo = "Yerli";
            devamEt.SendToBack();
        }

        private void cikisAcilirMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
