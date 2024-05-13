namespace Курсовая_Имитация_банкомата_
{
    partial class SelectLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLanguage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxukr = new System.Windows.Forms.PictureBox();
            this.pictureBoxrus = new System.Windows.Forms.PictureBox();
            this.pictureBoxeng = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxukr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxeng)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(228, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(228, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 5;
            // 
            // pictureBoxukr
            // 
            this.pictureBoxukr.Location = new System.Drawing.Point(133, 104);
            this.pictureBoxukr.Name = "pictureBoxukr";
            this.pictureBoxukr.Size = new System.Drawing.Size(95, 65);
            this.pictureBoxukr.TabIndex = 6;
            this.pictureBoxukr.TabStop = false;
            this.pictureBoxukr.Click += new System.EventHandler(this.pictureBoxukr_Click);
            // 
            // pictureBoxrus
            // 
            this.pictureBoxrus.Location = new System.Drawing.Point(278, 104);
            this.pictureBoxrus.Name = "pictureBoxrus";
            this.pictureBoxrus.Size = new System.Drawing.Size(95, 65);
            this.pictureBoxrus.TabIndex = 7;
            this.pictureBoxrus.TabStop = false;
            this.pictureBoxrus.Click += new System.EventHandler(this.pictureBoxrus_Click);
            // 
            // pictureBoxeng
            // 
            this.pictureBoxeng.Location = new System.Drawing.Point(419, 104);
            this.pictureBoxeng.Name = "pictureBoxeng";
            this.pictureBoxeng.Size = new System.Drawing.Size(95, 65);
            this.pictureBoxeng.TabIndex = 8;
            this.pictureBoxeng.TabStop = false;
            this.pictureBoxeng.Click += new System.EventHandler(this.pictureBoxeng_Click);
            // 
            // SelectLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.pictureBoxeng);
            this.Controls.Add(this.pictureBoxrus);
            this.Controls.Add(this.pictureBoxukr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectLanguage";
            this.Text = "Choose language";
            this.Move += new System.EventHandler(this.SelectLanguage_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxukr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxeng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxukr;
        private System.Windows.Forms.PictureBox pictureBoxrus;
        private System.Windows.Forms.PictureBox pictureBoxeng;
    }
}