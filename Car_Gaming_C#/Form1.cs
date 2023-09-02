using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; /* ses efekti icin */
    
namespace Car_Gaming_C_
{
    public partial class CarGaming : Form
    {
        public CarGaming()
        {
            InitializeComponent();
            /*InitializeComponent(), Visual Studio'da tasarladigimiz Windows Form, WPF gibi gorsel 
             * arayuzlerin olusturulmasi icin kullanilan bir yontemdir. */

        }
 
        int point = 0;/* kazanilan puan */
        int road_speed = 50; /* yol hizi */
        int car_speed = 5; /*bizim araba hizi */

        /* arabanin saga sola gitme */
        bool left_direction = false;
        bool right_direction = false;

        int other_cars_speed = 5;

        Random random = new Random();/* Yol ilerledikce random diger araba degistirme icin */
        bool sound_control = false; /* otoban sesi oyun bitince bitmesi icin kosul */

        /* ses dosyasi icin */
        SoundPlayer sound = new SoundPlayer();

        int speedIncreaseInterval = 100; /* Hizin arttirilacagi aralik (ornegin her 1 saniyede bir) */

        public void playGame()
        {   
            play_game.Enabled = false;/* oyun baslayinca oyunu baslat butonu kaybolmasi icin */
            explosion.Visible = false;/* oyun basladiginda carpisma efektini disable yapma */

            car_speed = 20;
            other_cars_speed= 20;
            point = 0;/* oyun her basladiginda puan 0 olur */

            /* bizim araba koordinati */
            my_Car.Left = 160;/* sol taraftan 160 piksellik bosluk birak */
            my_Car.Top = 290;/* araba ne kadar asagida, yukardan bosluk birakir */

            /* diger araba baslangic koordinatlari */
            car1.Left = 30;
            car1.Top = 50;

            car2.Left = 320;
            car2.Top = 50;

            /* oyun her yeniden basladiginda yonler false olur */
            left_direction = false;
            right_direction =false;


            lbl_highscore.Text = Settings1.Default.YüksekSkor.ToString();/* bir onceki yuksek skoru ekranda gosterir */

            timer1.Start(); /* timer baslar oyun baslayinca 
                            timer1_Tick fonksiyonu aktif hale gelir. */
        }
        
        private void play_game_Click(object sender, EventArgs e)
        {
            playGame();

            /* arayuzde oyunu baslata tiklayinca muzigin tekrardan calmaya baslamasi icin */
            if(sound_control == true)
            {
                turnUpSound();
            }
        }

        private void CarGaming_Load(object sender, EventArgs e)
        {
            playGame();/* oyun yuklenince bu fonksiyonu baslat */
            turnUpSound(); /* oyun baslar baslamaz sarki baslar */

        }

        private void turnUpSound()
        {

            /* ses dosyasi oyun klasorunun bin/debug icinde ve .wav uzantılı olmalı */
            string sound_path = Application.StartupPath + "\\highway-14475.wav"; /* otoban sesi efekti */            
            sound.SoundLocation = sound_path;
            sound.Play();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            point++; /* oyun basladiginda puan artmaya baslar */
            lbl_puan.Text = point.ToString(); /* puani ekranda gosterir */

            way.Top += road_speed; 
            /* yol Top mesafesi belli bir mesafeyi asarsa -100 geri getir yolu */
            if (way.Top > 100 ) {
                way.Top = -100;
            }
            
            /* arabanin saga sola yonlenmesi */
            if (left_direction) {
                my_Car.Left -= 20;
            }
            if (right_direction)
            {
                my_Car.Left += 20;
            }

            /* araba yol kenarlarina geldiyse */
            if (my_Car.Left < 1)
            {
                left_direction = false;
            }
            else if (my_Car.Left + my_Car.Width > way.Width)
            {
                right_direction = false;
            }

            /* diger arabalarin hareketi */
            car1.Top += other_cars_speed;
            car2.Top += other_cars_speed;

            /* araba1 kadrajdan cikarsa yeni araba gelmesi durumu */
            if(car1.Top > 290)
            {
                changeCar(car1);
                car1.Left = random.Next(20, 150);
                car1.Top = random.Next(40,140)* -1;/* -1 yapip arabanin kadraj disindan 
                                                    * gelmesi saglanir */
            
            }
            if (car2.Top > 290)
            {
                changeCar(car2);
                car2.Left = random.Next(210,330);
                car2.Top = random.Next(40, 140) * -1;/* -1 yapip arabanin kadraj disindan 
                                                    * gelmesi saglanir */

            }

            /* arabalarin hizi belli bir sure sonra her defasinda hizlanir */
            if(point % speedIncreaseInterval == 0)
            {
                other_cars_speed +=10; /* Diger arabalarin hizini artir */
                car_speed += 10; /* Kendi aracin hizini artir */
            }

            /* bizim araba ile diger arabalarin birbirine carpma durumu */
            if (my_Car.Bounds.IntersectsWith(car1.Bounds) || my_Car.Bounds.IntersectsWith(car2.Bounds))
            {
                gameOver();  /* arabalar carpisirsa oyun biter */
            }
        }

        private void changeCar(PictureBox car)
        {
            int number = random.Next(1, 7); /* araba degisimi icin random sayi */

            switch(number)
            {
                case 1:
                    car.Image = Properties.Resources.araba3;
                    break;
                case 2:
                    car.Image = Properties.Resources.araba4;
                    break;
                case 3:
                    car.Image = Properties.Resources.araba5;
                    break;
                case 4:
                    car.Image = Properties.Resources.araba6;
                    break;
                case 5:
                    car.Image = Properties.Resources.araba7;
                    break;
                case 6:
                    car.Image = Properties.Resources.araba8;
                    break;
                case 7:
                    car.Image = Properties.Resources.araba9;
                    break;
                default:
                    break;
            }
        }
        private void gameOver()
        {
            timer1.Stop(); /* sureyi durdur */
            

            /* yuksek skor degisimi icin */
            if (Convert.ToInt32(lbl_puan.Text) > Convert.ToInt32(Settings1.Default.YüksekSkor.ToString()))
            {
                Settings1.Default.YüksekSkor = lbl_puan.Text;
            }


            play_game.Enabled = true; /* oyunu baslat butonu aktif et */
            
            explosion.Visible = true; /* carpma aktif olur */
            my_Car.Controls.Add(explosion); /* carpma efektini arabaya ekleme */
            explosion.Location = new Point(7, -5);
            explosion.BringToFront(); /* carpma efektini one alır */
            explosion.BackColor = Color.Transparent; /* carpma efekti saydamlasir */

            sound.Stop(); /* oyun bitince muzik durur */
            sound_control = true; /* muzik bitip bitmedigini kontrol etmek icin */

            /* oyun bittiginde bilgilendirme mesaji, lbl_puan -> oyun sonunda kazanilan puan */
            MessageBox.Show("Tebrikler Puanınız:"+ lbl_puan.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        /* keyDown fonksiyonu klavyedeki tusu algilamasi icin */
        private void CarGaming_KeyDown(object sender, KeyEventArgs e)
        {
            /* araba sol tarafa gitmek isterse */
            if(e.KeyCode == Keys.Left && my_Car.Left > 0)
            {
                left_direction = true;

            }
            /* araba sag tarafa gitmek isterse */
            if (e.KeyCode == Keys.Right && (my_Car.Left + my_Car.Width) < way.Width)
            {
                right_direction = true;
            }
            
        }
        
        /* tustan elimizi cektigimizde yonleri inaktif yapar */
        private void CarGaming_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                left_direction = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right_direction = false;
            }
           
        }

        private void car2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* carpisma fonksiyonu */
        private void explosion_Click(object sender, EventArgs e)
        {

        }

        private void car1_Click(object sender, EventArgs e)
        {

        }

        private void my_Car_Click(object sender, EventArgs e)
        {

        }

        private void way_Click(object sender, EventArgs e)
        {

        }
    }
}