namespace Курсовая_Имитация_банкомата_
{
    partial class InsertCardRus
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
            this.label1 = new System.Windows.Forms.Label();
            this.karta = new System.Windows.Forms.PictureBox();
            this.vstavka = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.karta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vstavka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(250, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // karta
            // 
            this.karta.Location = new System.Drawing.Point(188, 96);
            this.karta.Name = "karta";
            this.karta.Size = new System.Drawing.Size(99, 61);
            this.karta.TabIndex = 2;
            this.karta.TabStop = false;
            this.karta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.karta_MouseClick);
            this.karta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.karta_MouseDown);
            // 
            // vstavka
            // 
            this.vstavka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vstavka.Location = new System.Drawing.Point(355, 96);
            this.vstavka.Name = "vstavka";
            this.vstavka.Size = new System.Drawing.Size(99, 61);
            this.vstavka.TabIndex = 3;
            this.vstavka.TabStop = false;
            this.vstavka.DragDrop += new System.Windows.Forms.DragEventHandler(this.vstavka_DragDrop);
            this.vstavka.DragEnter += new System.Windows.Forms.DragEventHandler(this.vstavka_DragEnter);
            this.vstavka.DragLeave += new System.EventHandler(this.vstavka_DragLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shel
            // 
            this.shel.Location = new System.Drawing.Point(405, 76);
            this.shel.Name = "shel";
            this.shel.Size = new System.Drawing.Size(99, 92);
            this.shel.TabIndex = 4;
            this.shel.TabStop = false;
            // 
            // InsertCardRus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.shel);
            this.Controls.Add(this.vstavka);
            this.Controls.Add(this.karta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InsertCardRus";
            this.Text = "Insert card";
            this.Load += new System.EventHandler(this.InsertCardRus_Load);
            this.Move += new System.EventHandler(this.InsertCardRus_Move);
            ((System.ComponentModel.ISupportInitialize)(this.karta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vstavka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox karta;
        private System.Windows.Forms.PictureBox vstavka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox shel;
    }
}