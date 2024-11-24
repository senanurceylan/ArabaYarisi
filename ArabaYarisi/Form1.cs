using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        private int HighScore = 0; // En yüksek skor değişkeni
     

        private bool SeritHareket = false; // Şerit hareket durumu
        public Form1()
        {
            InitializeComponent();
        }
        int SeriSayisi = 1, Road = 0, Speed = 70;
        Random r = new Random();
        class Random_CAR
        {
            public bool FakeHaveCar = false;
            public PictureBox FakeCar;
            public bool vakit = false;

        }
        Random_CAR[] rndCar = new Random_CAR[2];
        void BringRandomCar(PictureBox Pb)
        {
            int rnd = r.Next(0, 4);
            switch (rnd)
            {
                case 0:
                    Pb.Image = Properties.Resources.car0;
                    break;
                case 1:
                    Pb.Image = Properties.Resources.car1;
                    break;
                case 2:
                    Pb.Image = Properties.Resources.car2;
                    break;
                case 3:
                    Pb.Image = Properties.Resources.car3;
                    break;

            }
            Pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        int SeritSayisi = 1;
        private void AracYerine()
        {
            if (SeritSayisi == 1)
            {
                RedCar.Location = new Point(223, 373);
            }
            else if (SeritSayisi == 0)
            {
                RedCar.Location = new Point(60, 373);
            }
            else if (SeritSayisi == 2)
            {
                RedCar.Location = new Point(400, 373);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (SeritSayisi < 2)
                    SeritSayisi++;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (SeritSayisi > 0)
                    SeritSayisi--;
            }
            AracYerine();
        }

        private void RandomMusicEkle()
        {
            int MuzikDeger = r.Next(1, 4);
            axWindowsMediaPlayer1.URL = @"music/track" + MuzikDeger.ToString() + ".mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < rndCar.Length; i++)
            {
                rndCar[i] = new Random_CAR();
            }
            rndCar[0].vakit = true;
            AracYerine();
            RandomMusicEkle();
        }

        bool SesKontrol = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SesKontrol == true)
            {
                SesKontrol = false;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                pictureBox2.Image = Properties.Resources.volumeOff;
            }
            else if (SesKontrol == false)
            {
                SesKontrol = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox2.Image = Properties.Resources.volumeON;
            }
        }

        private void timerRandomCar_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < rndCar.Length; i++)
            {
                // Eğer arabaya atanmış bir PictureBox yoksa ve vakit uygunsa yeni bir araba oluştur
                if (!rndCar[i].FakeHaveCar && rndCar[i].vakit)
                {
                    rndCar[i].FakeCar = new PictureBox();
                    BringRandomCar(rndCar[i].FakeCar); // Rastgele bir araba resmi getir
                    rndCar[i].FakeCar.Size = new Size(90, 150);
                    rndCar[i].FakeCar.Top = -rndCar[i].FakeCar.Height;

                    // Rastgele bir şerite yerleştir
                    int SeriteYerlestir = r.Next(0, 3);
                    if (SeriteYerlestir == 0)
                    {
                        rndCar[i].FakeCar.Left = 55;
                    }
                    else if (SeriteYerlestir == 1)
                    {
                        rndCar[i].FakeCar.Left = 210;
                    }
                    else if (SeriteYerlestir == 2)
                    {
                        rndCar[i].FakeCar.Left = 390;
                    }

                    // PictureBox'ı forma ekle ve durumları güncelle
                    this.Controls.Add(rndCar[i].FakeCar);
                    rndCar[i].FakeHaveCar = true;

                    // Debug kontrol
                    Console.WriteLine($"Araba {i} oluşturuldu.");
                }
                else
                {
                    // Eğer araba mevcutsa, hareket ettir
                    if (rndCar[i].FakeCar != null)
                    {
                        rndCar[i].FakeCar.Top += 20; // Arabayı hareket ettir

                        // Debug kontrol
                        Console.WriteLine($"Araba {i} hareket ediyor: {rndCar[i].FakeCar.Top}");

                        // Araba formun dışına çıktıysa kaldır
                        if (rndCar[i].FakeCar.Top >= this.Height - 20)
                        {
                            this.Controls.Remove(rndCar[i].FakeCar);
                            rndCar[i].FakeCar.Dispose();
                            rndCar[i].FakeHaveCar = false;
                            rndCar[i].vakit = false;

                            // Debug kontrol
                            Console.WriteLine($"Araba {i} silindi.");
                        }
                    }
                }

                // Çarpışma kontrolü (yalnızca bir kez çalışacak)
                if (rndCar[i].FakeCar != null && rndCar[i].vakit)
                {
                    float MutlakX = Math.Abs((RedCar.Left + (RedCar.Width / 2)) -
                                             (rndCar[i].FakeCar.Left + (rndCar[i].FakeCar.Width / 2)));

                    float MutlakY = Math.Abs((RedCar.Top + (RedCar.Height / 2)) -
                                             (rndCar[i].FakeCar.Top + (rndCar[i].FakeCar.Height / 2)));

                    float FarkGenislik = (RedCar.Width / 2) + (rndCar[i].FakeCar.Width / 2);
                    float FarkYukseklik = (RedCar.Height / 2) + (rndCar[i].FakeCar.Height / 2);

                    if ((FarkGenislik > MutlakX) && (FarkYukseklik > MutlakY))
                    {
                        // Timer'ları durdur
                        timerRandomCar.Enabled = false;
                        timerSerit.Enabled = false;

                        // Çarpışma sesini çal
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                        axWindowsMediaPlayer1.URL = @"music/crash.mp3";
                        axWindowsMediaPlayer1.Ctlcontrols.play();

                        // "Game Over" mesajı
                        DialogResult dr = MessageBox.Show("Game Over! Wanna Try Again?",
                                                          "Warning",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            RestartGame(); // Oyunu yeniden başlat
                        }
                        else
                        {
                            this.Close(); // Uygulamayı kapat
                        }
                        return; // Çarpışma sonrası daha fazla işlem yapılmasın
                    }
                }
            }

            // Yeni bir araba için bir vakit kontrolü yap
            for (int j = 0; j < rndCar.Length; j++)
            {
                if (!rndCar[j].FakeHaveCar && !rndCar[j].vakit)
                {
                    rndCar[j].vakit = true; // Yeni araba oluşturulabilir
                    break; // Sadece bir araba için vakit açılır
                }
            }
        }

        private void RestartGame()
        {


            // Arabayı yerine koy
            AracYerine();

            // Tüm rastgele arabaları temizle ve durumlarını sıfırla
            for (int j = 0; j < rndCar.Length; j++)
            {
                if (rndCar[j].FakeCar != null)
                {
                    rndCar[j].FakeCar.Dispose(); // Arabayı formdan kaldır
                }
                rndCar[j].FakeHaveCar = false; // Arabayı kullanılabilir duruma getir
                rndCar[j].vakit = false;       // Zamanlayıcı sıfırla
            }

            // Oyun değişkenlerini sıfırla
            Road = 0;
            Speed = 70;

            // İlk arabayı aktif et
            rndCar[0].vakit = true;

            // Timer'ları yeniden başlat
            timerRandomCar.Enabled = true;
            timerRandomCar.Interval = 200;

            timerSerit.Enabled = true;
            timerSerit.Interval = 200;

            // Müziği yeniden başlat
            RandomMusicEkle();
            axWindowsMediaPlayer1.Ctlcontrols.play();

            // Yeni bir araba için bir vakit kontrolü yap
            for (int j = 0; j < rndCar.Length; j++)
            {
                if (!rndCar[j].FakeHaveCar && !rndCar[j].vakit)
                {
                    rndCar[j].vakit = true; // Yeni araba oluşturulabilir
                    break; // Sadece bir araba için vakit açılır
                }
            }
        }

        private void timerSerit_Tick(object sender, EventArgs e)
        {
            Road += Speed / 10; // Hıza bağlı olarak yol artışı

            // High Score kontrolü
            if (Road > HighScore)
            {
                HighScore = Road; // Yeni High Score'u güncelle
            }

            // Şerit hareketleri
            if (!SeritHareket)
            {
                for (int i = 1; i < 7; i++)
                {
                    var solSerit = this.Controls.Find("labelSolSerit" + i.ToString(), true);
                    if (solSerit.Length > 0) solSerit[0].Top -= 25;

                    var sagSerit = this.Controls.Find("labelSagSerit" + i.ToString(), true);
                    if (sagSerit.Length > 0) sagSerit[0].Top -= 25;
                }
                SeritHareket = true;
            }
            else
            {
                for (int i = 1; i < 7; i++)
                {
                    var solSerit = this.Controls.Find("labelSolSerit" + i.ToString(), true);
                    if (solSerit.Length > 0) solSerit[0].Top += 25;

                    var sagSerit = this.Controls.Find("labelSagSerit" + i.ToString(), true);
                    if (sagSerit.Length > 0) sagSerit[0].Top += 25;
                }
                SeritHareket = false;
            }

            // Etiketleri güncelle
            label22.Text = $"{Road} m";
            label13.Text = $"{Speed} km/h";
            label20.Text = $" {HighScore} m"; // High Score etiketini güncelle
        }
    }
}