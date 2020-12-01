namespace testAnimation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pcNhanvat = new System.Windows.Forms.PictureBox();
            this.pcVatcan1 = new System.Windows.Forms.PictureBox();
            this.UFO = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcNhanvat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcVatcan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 200;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pcNhanvat
            // 
            this.pcNhanvat.BackColor = System.Drawing.Color.Transparent;
            this.pcNhanvat.Image = ((System.Drawing.Image)(resources.GetObject("pcNhanvat.Image")));
            this.pcNhanvat.Location = new System.Drawing.Point(123, 299);
            this.pcNhanvat.MaximumSize = new System.Drawing.Size(80, 90);
            this.pcNhanvat.MinimumSize = new System.Drawing.Size(80, 90);
            this.pcNhanvat.Name = "pcNhanvat";
            this.pcNhanvat.Size = new System.Drawing.Size(80, 90);
            this.pcNhanvat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcNhanvat.TabIndex = 0;
            this.pcNhanvat.TabStop = false;
            this.pcNhanvat.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcVatcan1
            // 
            this.pcVatcan1.BackColor = System.Drawing.Color.Transparent;
            this.pcVatcan1.Image = ((System.Drawing.Image)(resources.GetObject("pcVatcan1.Image")));
            this.pcVatcan1.Location = new System.Drawing.Point(420, 329);
            this.pcVatcan1.Name = "pcVatcan1";
            this.pcVatcan1.Size = new System.Drawing.Size(75, 75);
            this.pcVatcan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcVatcan1.TabIndex = 1;
            this.pcVatcan1.TabStop = false;
            this.pcVatcan1.Click += new System.EventHandler(this.pcVatcan1_Click);
            // 
            // UFO
            // 
            this.UFO.BackColor = System.Drawing.Color.Transparent;
            this.UFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UFO.Image = ((System.Drawing.Image)(resources.GetObject("UFO.Image")));
            this.UFO.Location = new System.Drawing.Point(811, 188);
            this.UFO.MaximumSize = new System.Drawing.Size(100, 65);
            this.UFO.Name = "UFO";
            this.UFO.Size = new System.Drawing.Size(100, 65);
            this.UFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UFO.TabIndex = 2;
            this.UFO.TabStop = false;
            this.UFO.Click += new System.EventHandler(this.UFO_Click);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("UTM Brewers KT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(349, 17);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(38, 30);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-28, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.UFO);
            this.panel1.Controls.Add(this.pcVatcan1);
            this.panel1.Controls.Add(this.pcNhanvat);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 495);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(923, 492);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameCAPTION";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcNhanvat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcVatcan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcNhanvat;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pcVatcan1;
        private System.Windows.Forms.PictureBox UFO;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

