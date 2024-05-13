namespace Курсовая_Имитация_банкомата_
{
    partial class ChooseATM
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseATM));
            this.bank5 = new System.Windows.Forms.PictureBox();
            this.bank3 = new System.Windows.Forms.PictureBox();
            this.bank4 = new System.Windows.Forms.PictureBox();
            this.bank2 = new System.Windows.Forms.PictureBox();
            this.bank1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bank5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1)).BeginInit();
            this.SuspendLayout();
            // 
            // bank5
            // 
            this.bank5.Location = new System.Drawing.Point(633, 96);
            this.bank5.Name = "bank5";
            this.bank5.Size = new System.Drawing.Size(89, 287);
            this.bank5.TabIndex = 8;
            this.bank5.TabStop = false;
            this.bank5.Click += new System.EventHandler(this.bank5_Click);
            // 
            // bank3
            // 
            this.bank3.Location = new System.Drawing.Point(183, 96);
            this.bank3.Name = "bank3";
            this.bank3.Size = new System.Drawing.Size(87, 287);
            this.bank3.TabIndex = 7;
            this.bank3.TabStop = false;
            this.bank3.Click += new System.EventHandler(this.bank3_Click);
            // 
            // bank4
            // 
            this.bank4.Location = new System.Drawing.Point(36, 110);
            this.bank4.Name = "bank4";
            this.bank4.Size = new System.Drawing.Size(83, 273);
            this.bank4.TabIndex = 6;
            this.bank4.TabStop = false;
            this.bank4.Click += new System.EventHandler(this.bank4_Click);
            // 
            // bank2
            // 
            this.bank2.Location = new System.Drawing.Point(327, 96);
            this.bank2.Name = "bank2";
            this.bank2.Size = new System.Drawing.Size(89, 287);
            this.bank2.TabIndex = 5;
            this.bank2.TabStop = false;
            this.bank2.Click += new System.EventHandler(this.bank2_Click);
            // 
            // bank1
            // 
            this.bank1.Location = new System.Drawing.Point(483, 96);
            this.bank1.Name = "bank1";
            this.bank1.Size = new System.Drawing.Size(80, 287);
            this.bank1.TabIndex = 4;
            this.bank1.TabStop = false;
            this.bank1.Click += new System.EventHandler(this.bank1_Click);
            // 
            // ChooseATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.bank5);
            this.Controls.Add(this.bank3);
            this.Controls.Add(this.bank4);
            this.Controls.Add(this.bank2);
            this.Controls.Add(this.bank1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseATM";
            this.Text = "Go to ATM";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Move += new System.EventHandler(this.ChooseATM_Move);
            ((System.ComponentModel.ISupportInitialize)(this.bank5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox bank1;
        private System.Windows.Forms.PictureBox bank2;
        private System.Windows.Forms.PictureBox bank4;
        private System.Windows.Forms.PictureBox bank3;
        private System.Windows.Forms.PictureBox bank5;
    }
}

