namespace ArabaYarisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSolSerit1 = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelRoad = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelSolSerit5 = new System.Windows.Forms.Label();
            this.labelSolSerit4 = new System.Windows.Forms.Label();
            this.labelSolSerit3 = new System.Windows.Forms.Label();
            this.labelSolSerit2 = new System.Windows.Forms.Label();
            this.labelSagSerit5 = new System.Windows.Forms.Label();
            this.labelSagSerit4 = new System.Windows.Forms.Label();
            this.labelSagSerit3 = new System.Windows.Forms.Label();
            this.labelSagSerit2 = new System.Windows.Forms.Label();
            this.labelSagSerit1 = new System.Windows.Forms.Label();
            this.RedCar = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerSerit = new System.Windows.Forms.Timer(this.components);
            this.timerRandomCar = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(-1, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 725);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(661, -14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 725);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Violet;
            this.label3.Location = new System.Drawing.Point(0, 660);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(707, 53);
            this.label3.TabIndex = 2;
            // 
            // labelSolSerit1
            // 
            this.labelSolSerit1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSolSerit1.Location = new System.Drawing.Point(242, 535);
            this.labelSolSerit1.Name = "labelSolSerit1";
            this.labelSolSerit1.Size = new System.Drawing.Size(13, 124);
            this.labelSolSerit1.TabIndex = 9;
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.BackColor = System.Drawing.Color.Violet;
            this.LabelSpeed.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelSpeed.ForeColor = System.Drawing.Color.Black;
            this.LabelSpeed.Location = new System.Drawing.Point(62, 667);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(64, 23);
            this.LabelSpeed.TabIndex = 16;
            this.LabelSpeed.Text = "Speed :";
            this.LabelSpeed.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Violet;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(146, 667);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 17;
            this.label13.Text = "0 km/ h";
            // 
            // LabelRoad
            // 
            this.LabelRoad.AutoSize = true;
            this.LabelRoad.BackColor = System.Drawing.Color.Violet;
            this.LabelRoad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelRoad.ForeColor = System.Drawing.Color.Black;
            this.LabelRoad.Location = new System.Drawing.Point(254, 667);
            this.LabelRoad.Name = "LabelRoad";
            this.LabelRoad.Size = new System.Drawing.Size(53, 23);
            this.LabelRoad.TabIndex = 22;
            this.LabelRoad.Text = "Road:";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.Violet;
            this.LabelScore.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelScore.ForeColor = System.Drawing.Color.Black;
            this.LabelScore.Location = new System.Drawing.Point(482, 667);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(56, 23);
            this.LabelScore.TabIndex = 23;
            this.LabelScore.Text = "Score:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Violet;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(568, 667);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 23);
            this.label20.TabIndex = 24;
            this.label20.Text = "0 m";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Violet;
            this.label22.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(350, 667);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 23);
            this.label22.TabIndex = 26;
            this.label22.Text = "0 m";
            // 
            // labelSolSerit5
            // 
            this.labelSolSerit5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSolSerit5.Location = new System.Drawing.Point(240, -14);
            this.labelSolSerit5.Name = "labelSolSerit5";
            this.labelSolSerit5.Size = new System.Drawing.Size(14, 80);
            this.labelSolSerit5.TabIndex = 29;
            // 
            // labelSolSerit4
            // 
            this.labelSolSerit4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSolSerit4.Location = new System.Drawing.Point(242, 100);
            this.labelSolSerit4.Name = "labelSolSerit4";
            this.labelSolSerit4.Size = new System.Drawing.Size(13, 124);
            this.labelSolSerit4.TabIndex = 30;
            // 
            // labelSolSerit3
            // 
            this.labelSolSerit3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSolSerit3.Location = new System.Drawing.Point(242, 245);
            this.labelSolSerit3.Name = "labelSolSerit3";
            this.labelSolSerit3.Size = new System.Drawing.Size(13, 124);
            this.labelSolSerit3.TabIndex = 31;
            // 
            // labelSolSerit2
            // 
            this.labelSolSerit2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSolSerit2.Location = new System.Drawing.Point(242, 386);
            this.labelSolSerit2.Name = "labelSolSerit2";
            this.labelSolSerit2.Size = new System.Drawing.Size(13, 124);
            this.labelSolSerit2.TabIndex = 32;
            // 
            // labelSagSerit5
            // 
            this.labelSagSerit5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSagSerit5.Location = new System.Drawing.Point(414, -16);
            this.labelSagSerit5.Name = "labelSagSerit5";
            this.labelSagSerit5.Size = new System.Drawing.Size(13, 82);
            this.labelSagSerit5.TabIndex = 33;
            // 
            // labelSagSerit4
            // 
            this.labelSagSerit4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSagSerit4.Location = new System.Drawing.Point(414, 80);
            this.labelSagSerit4.Name = "labelSagSerit4";
            this.labelSagSerit4.Size = new System.Drawing.Size(13, 124);
            this.labelSagSerit4.TabIndex = 34;
            // 
            // labelSagSerit3
            // 
            this.labelSagSerit3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSagSerit3.Location = new System.Drawing.Point(414, 231);
            this.labelSagSerit3.Name = "labelSagSerit3";
            this.labelSagSerit3.Size = new System.Drawing.Size(13, 124);
            this.labelSagSerit3.TabIndex = 35;
            // 
            // labelSagSerit2
            // 
            this.labelSagSerit2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSagSerit2.Location = new System.Drawing.Point(414, 386);
            this.labelSagSerit2.Name = "labelSagSerit2";
            this.labelSagSerit2.Size = new System.Drawing.Size(13, 124);
            this.labelSagSerit2.TabIndex = 36;
            // 
            // labelSagSerit1
            // 
            this.labelSagSerit1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSagSerit1.Location = new System.Drawing.Point(414, 535);
            this.labelSagSerit1.Name = "labelSagSerit1";
            this.labelSagSerit1.Size = new System.Drawing.Size(13, 124);
            this.labelSagSerit1.TabIndex = 37;
            // 
            // RedCar
            // 
            this.RedCar.Image = ((System.Drawing.Image)(resources.GetObject("RedCar.Image")));
            this.RedCar.Location = new System.Drawing.Point(312, 508);
            this.RedCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RedCar.Name = "RedCar";
            this.RedCar.Size = new System.Drawing.Size(90, 149);
            this.RedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedCar.TabIndex = 38;
            this.RedCar.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(51, 508);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 39;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(614, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timerSerit
            // 
            this.timerSerit.Enabled = true;
            this.timerSerit.Tick += new System.EventHandler(this.timerSerit_Tick);
            // 
            // timerRandomCar
            // 
            this.timerRandomCar.Enabled = true;
            this.timerRandomCar.Tick += new System.EventHandler(this.timerRandomCar_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Violet;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(0, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Sena Nur";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ceylan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(706, 699);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.RedCar);
            this.Controls.Add(this.labelSagSerit1);
            this.Controls.Add(this.labelSagSerit2);
            this.Controls.Add(this.labelSagSerit3);
            this.Controls.Add(this.labelSagSerit4);
            this.Controls.Add(this.labelSagSerit5);
            this.Controls.Add(this.labelSolSerit2);
            this.Controls.Add(this.labelSolSerit3);
            this.Controls.Add(this.labelSolSerit4);
            this.Controls.Add(this.labelSolSerit5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LabelRoad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LabelSpeed);
            this.Controls.Add(this.labelSolSerit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Traffic Racer 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSolSerit1;
        private System.Windows.Forms.Label LabelSpeed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelRoad;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelSolSerit5;
        private System.Windows.Forms.Label labelSolSerit4;
        private System.Windows.Forms.Label labelSolSerit3;
        private System.Windows.Forms.Label labelSolSerit2;
        private System.Windows.Forms.Label labelSagSerit5;
        private System.Windows.Forms.Label labelSagSerit4;
        private System.Windows.Forms.Label labelSagSerit3;
        private System.Windows.Forms.Label labelSagSerit2;
        private System.Windows.Forms.Label labelSagSerit1;
        private System.Windows.Forms.PictureBox RedCar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerSerit;
        private System.Windows.Forms.Timer timerRandomCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

