namespace TimerKullanimi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            pictureBoxempty = new PictureBox();
            pictureBoxred = new PictureBox();
            pictureBoxyellow = new PictureBox();
            pictureBoxgreen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxempty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxred).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxyellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxgreen).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(474, 184);
            button1.Name = "button1";
            button1.Size = new Size(86, 43);
            button1.TabIndex = 0;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 23);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 1;
            label1.Text = "Saniye";
            // 
            // pictureBoxempty
            // 
            pictureBoxempty.Image = (Image)resources.GetObject("pictureBoxempty.Image");
            pictureBoxempty.Location = new Point(201, 23);
            pictureBoxempty.Name = "pictureBoxempty";
            pictureBoxempty.Size = new Size(98, 215);
            pictureBoxempty.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxempty.TabIndex = 2;
            pictureBoxempty.TabStop = false;
            pictureBoxempty.Visible = false;
            // 
            // pictureBoxred
            // 
            pictureBoxred.Image = (Image)resources.GetObject("pictureBoxred.Image");
            pictureBoxred.Location = new Point(197, 23);
            pictureBoxred.Name = "pictureBoxred";
            pictureBoxred.Size = new Size(102, 215);
            pictureBoxred.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxred.TabIndex = 3;
            pictureBoxred.TabStop = false;
            pictureBoxred.Visible = false;
            // 
            // pictureBoxyellow
            // 
            pictureBoxyellow.Image = (Image)resources.GetObject("pictureBoxyellow.Image");
            pictureBoxyellow.Location = new Point(197, 23);
            pictureBoxyellow.Name = "pictureBoxyellow";
            pictureBoxyellow.Size = new Size(100, 215);
            pictureBoxyellow.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxyellow.TabIndex = 4;
            pictureBoxyellow.TabStop = false;
            pictureBoxyellow.Visible = false;
            // 
            // pictureBoxgreen
            // 
            pictureBoxgreen.Image = (Image)resources.GetObject("pictureBoxgreen.Image");
            pictureBoxgreen.Location = new Point(199, 23);
            pictureBoxgreen.Name = "pictureBoxgreen";
            pictureBoxgreen.Size = new Size(100, 215);
            pictureBoxgreen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxgreen.TabIndex = 5;
            pictureBoxgreen.TabStop = false;
            pictureBoxgreen.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(651, 337);
            Controls.Add(pictureBoxgreen);
            Controls.Add(pictureBoxyellow);
            Controls.Add(pictureBoxred);
            Controls.Add(pictureBoxempty);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Trafik Isik Uygulaması";
            ((System.ComponentModel.ISupportInitialize)pictureBoxempty).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxred).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxyellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxgreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBoxempty;
        private PictureBox pictureBoxred;
        private PictureBox pictureBoxyellow;
        private PictureBox pictureBoxgreen;
    }
}