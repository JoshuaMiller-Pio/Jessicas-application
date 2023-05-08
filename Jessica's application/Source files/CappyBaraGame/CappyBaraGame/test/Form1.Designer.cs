namespace test
{
    partial class Cappybara_Love
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cappybara_Love));
            this.textRight = new System.Windows.Forms.Label();
            this.Tmessage = new System.Windows.Forms.Timer(this.components);
            this.Twalk = new System.Windows.Forms.Timer(this.components);
            this.TmessageStop = new System.Windows.Forms.Timer(this.components);
            this.Trandomizer = new System.Windows.Forms.Timer(this.components);
            this.respawn = new System.Windows.Forms.Timer(this.components);
            this.dedcappy = new System.Windows.Forms.PictureBox();
            this.cappyleft = new System.Windows.Forms.PictureBox();
            this.cappyright = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dedcappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cappyleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cappyright)).BeginInit();
            this.SuspendLayout();
            // 
            // textRight
            // 
            this.textRight.AutoSize = true;
            this.textRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRight.ForeColor = System.Drawing.Color.DimGray;
            this.textRight.Location = new System.Drawing.Point(102, 54);
            this.textRight.Name = "textRight";
            this.textRight.Size = new System.Drawing.Size(2, 27);
            this.textRight.TabIndex = 2;
            // 
            // Tmessage
            // 
            this.Tmessage.Enabled = true;
            this.Tmessage.Interval = 300000;
            this.Tmessage.Tick += new System.EventHandler(this.Tmessage_Tick);
            // 
            // Twalk
            // 
            this.Twalk.Enabled = true;
            this.Twalk.Interval = 1;
            this.Twalk.Tick += new System.EventHandler(this.Twalk_Tick);
            // 
            // TmessageStop
            // 
            this.TmessageStop.Enabled = true;
            this.TmessageStop.Interval = 3000;
            this.TmessageStop.Tick += new System.EventHandler(this.TmessageStop_Tick);
            // 
            // Trandomizer
            // 
            this.Trandomizer.Enabled = true;
            this.Trandomizer.Interval = 3000;
            this.Trandomizer.Tick += new System.EventHandler(this.Trandomizer_Tick);
            // 
            // respawn
            // 
            this.respawn.Interval = 10000;
            this.respawn.Tick += new System.EventHandler(this.respawn_Tick);
            // 
            // dedcappy
            // 
            this.dedcappy.BackColor = System.Drawing.Color.Transparent;
            this.dedcappy.Image = global::test.Properties.Resources.dedcappy1;
            this.dedcappy.Location = new System.Drawing.Point(-3, 102);
            this.dedcappy.Name = "dedcappy";
            this.dedcappy.Size = new System.Drawing.Size(107, 96);
            this.dedcappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dedcappy.TabIndex = 4;
            this.dedcappy.TabStop = false;
            this.dedcappy.Click += new System.EventHandler(this.dedcappy_Click);
            // 
            // cappyleft
            // 
            this.cappyleft.BackColor = System.Drawing.Color.Transparent;
            this.cappyleft.Image = global::test.Properties.Resources.cappy_bara2;
            this.cappyleft.Location = new System.Drawing.Point(-3, 102);
            this.cappyleft.Name = "cappyleft";
            this.cappyleft.Size = new System.Drawing.Size(107, 96);
            this.cappyleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cappyleft.TabIndex = 3;
            this.cappyleft.TabStop = false;
            this.cappyleft.Click += new System.EventHandler(this.cappyleft_Click);
            // 
            // cappyright
            // 
            this.cappyright.BackColor = System.Drawing.Color.Transparent;
            this.cappyright.Image = global::test.Properties.Resources.cappy_bara;
            this.cappyright.Location = new System.Drawing.Point(-5, 102);
            this.cappyright.Name = "cappyright";
            this.cappyright.Size = new System.Drawing.Size(107, 96);
            this.cappyright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cappyright.TabIndex = 0;
            this.cappyright.TabStop = false;
            this.cappyright.Click += new System.EventHandler(this.cappyright_Click);
            // 
            // Cappybara_Love
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(864, 200);
            this.Controls.Add(this.dedcappy);
            this.Controls.Add(this.cappyleft);
            this.Controls.Add(this.textRight);
            this.Controls.Add(this.cappyright);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cappybara_Love";
            this.Text = "Cappybara Love";
            this.Load += new System.EventHandler(this.Cappybara_Love_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedcappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cappyleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cappyright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cappyright;
        private System.Windows.Forms.Label textRight;
        private System.Windows.Forms.PictureBox cappyleft;
        private System.Windows.Forms.Timer Tmessage;
        private System.Windows.Forms.Timer Twalk;
        private System.Windows.Forms.Timer TmessageStop;
        private System.Windows.Forms.Timer Trandomizer;
        private System.Windows.Forms.PictureBox dedcappy;
        private System.Windows.Forms.Timer respawn;
    }
}

