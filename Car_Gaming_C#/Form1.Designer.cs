namespace Car_Gaming_C_
{
    partial class CarGaming
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.my_Car = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.way = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.play_game = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.way)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.my_Car);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.way);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // my_Car
            // 
            this.my_Car.Image = global::Car_Gaming_C_.Properties.Resources.araba3;
            this.my_Car.Location = new System.Drawing.Point(201, 360);
            this.my_Car.Name = "my_Car";
            this.my_Car.Size = new System.Drawing.Size(69, 160);
            this.my_Car.TabIndex = 4;
            this.my_Car.TabStop = false;
            this.my_Car.Click += new System.EventHandler(this.my_Car_Click);
            // 
            // explosion
            // 
            this.explosion.Image = global::Car_Gaming_C_.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(266, 289);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(62, 65);
            this.explosion.TabIndex = 3;
            this.explosion.TabStop = false;
            this.explosion.Click += new System.EventHandler(this.explosion_Click);
            // 
            // car2
            // 
            this.car2.Image = global::Car_Gaming_C_.Properties.Resources.araba9;
            this.car2.Location = new System.Drawing.Point(344, 142);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(69, 134);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 2;
            this.car2.TabStop = false;
            this.car2.Click += new System.EventHandler(this.car2_Click);
            // 
            // car1
            // 
            this.car1.Image = global::Car_Gaming_C_.Properties.Resources.araba5;
            this.car1.Location = new System.Drawing.Point(95, 142);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(69, 134);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 2;
            this.car1.TabStop = false;
            this.car1.Click += new System.EventHandler(this.car1_Click);
            // 
            // way
            // 
            this.way.Image = global::Car_Gaming_C_.Properties.Resources.yol;
            this.way.Location = new System.Drawing.Point(-6, -196);
            this.way.Name = "way";
            this.way.Size = new System.Drawing.Size(513, 743);
            this.way.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.way.TabIndex = 1;
            this.way.TabStop = false;
            this.way.Click += new System.EventHandler(this.way_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(400, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.Location = new System.Drawing.Point(489, 562);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(25, 27);
            this.lbl_puan.TabIndex = 1;
            this.lbl_puan.Text = "0";
            this.lbl_puan.Click += new System.EventHandler(this.label1_Click);
            // 
            // play_game
            // 
            this.play_game.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.play_game.Location = new System.Drawing.Point(12, 606);
            this.play_game.Name = "play_game";
            this.play_game.Size = new System.Drawing.Size(507, 54);
            this.play_game.TabIndex = 2;
            this.play_game.Text = "Play game";
            this.play_game.UseVisualStyleBackColor = true;
            this.play_game.Click += new System.EventHandler(this.play_game_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yüksek Skor:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_highscore
            // 
            this.lbl_highscore.AutoSize = true;
            this.lbl_highscore.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_highscore.Location = new System.Drawing.Point(182, 562);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(25, 27);
            this.lbl_highscore.TabIndex = 1;
            this.lbl_highscore.Text = "0";
            this.lbl_highscore.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarGaming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 677);
            this.Controls.Add(this.play_game);
            this.Controls.Add(this.lbl_highscore);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CarGaming";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CarGaming_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarGaming_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CarGaming_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.way)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox way;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Button play_game;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox my_Car;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_highscore;
    }
}

