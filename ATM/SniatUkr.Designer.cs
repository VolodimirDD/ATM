﻿namespace Курсовая_Имитация_банкомата_
{
    partial class SniatUkr
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
            this.Exit = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.TextBox();
            this.deneg1000 = new System.Windows.Forms.Button();
            this.deneg300 = new System.Windows.Forms.Button();
            this.deneg200 = new System.Windows.Forms.Button();
            this.deneg100 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(346, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 17;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.Exit.Location = new System.Drawing.Point(441, 166);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 50);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Завершити сеанс";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Harrington", 14F, System.Drawing.FontStyle.Bold);
            this.balance.Location = new System.Drawing.Point(441, 38);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(54, 29);
            this.balance.TabIndex = 15;
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deneg1000
            // 
            this.deneg1000.BackColor = System.Drawing.Color.White;
            this.deneg1000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deneg1000.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.deneg1000.Location = new System.Drawing.Point(134, 180);
            this.deneg1000.Name = "deneg1000";
            this.deneg1000.Size = new System.Drawing.Size(80, 50);
            this.deneg1000.TabIndex = 14;
            this.deneg1000.Text = "Зняти 1000 гр. од.";
            this.deneg1000.UseVisualStyleBackColor = false;
            this.deneg1000.Click += new System.EventHandler(this.deneg1000_Click);
            this.deneg1000.MouseEnter += new System.EventHandler(this.deneg1000_MouseEnter);
            this.deneg1000.MouseLeave += new System.EventHandler(this.deneg1000_MouseLeave);
            // 
            // deneg300
            // 
            this.deneg300.BackColor = System.Drawing.Color.White;
            this.deneg300.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deneg300.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.deneg300.Location = new System.Drawing.Point(134, 124);
            this.deneg300.Name = "deneg300";
            this.deneg300.Size = new System.Drawing.Size(80, 50);
            this.deneg300.TabIndex = 13;
            this.deneg300.Text = "Зняти 500 гр. од.";
            this.deneg300.UseVisualStyleBackColor = false;
            this.deneg300.Click += new System.EventHandler(this.deneg300_Click);
            this.deneg300.MouseEnter += new System.EventHandler(this.deneg300_MouseEnter);
            this.deneg300.MouseLeave += new System.EventHandler(this.deneg300_MouseLeave);
            // 
            // deneg200
            // 
            this.deneg200.BackColor = System.Drawing.Color.White;
            this.deneg200.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deneg200.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.deneg200.Location = new System.Drawing.Point(134, 68);
            this.deneg200.Name = "deneg200";
            this.deneg200.Size = new System.Drawing.Size(80, 50);
            this.deneg200.TabIndex = 12;
            this.deneg200.Text = "Зняти 200 гр. од.";
            this.deneg200.UseVisualStyleBackColor = false;
            this.deneg200.Click += new System.EventHandler(this.deneg200_Click);
            this.deneg200.MouseEnter += new System.EventHandler(this.deneg200_MouseEnter);
            this.deneg200.MouseLeave += new System.EventHandler(this.deneg200_MouseLeave);
            // 
            // deneg100
            // 
            this.deneg100.BackColor = System.Drawing.Color.White;
            this.deneg100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deneg100.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.deneg100.Location = new System.Drawing.Point(134, 12);
            this.deneg100.Name = "deneg100";
            this.deneg100.Size = new System.Drawing.Size(80, 50);
            this.deneg100.TabIndex = 11;
            this.deneg100.Text = "Зняти 100 гр. од.";
            this.deneg100.UseVisualStyleBackColor = false;
            this.deneg100.Click += new System.EventHandler(this.deneg100_Click);
            this.deneg100.MouseEnter += new System.EventHandler(this.deneg100_MouseEnter);
            this.deneg100.MouseLeave += new System.EventHandler(this.deneg100_MouseLeave);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Crimson;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(316, 166);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 50);
            this.Back.TabIndex = 10;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(362, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 20;
            // 
            // SniatUkr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.deneg1000);
            this.Controls.Add(this.deneg300);
            this.Controls.Add(this.deneg200);
            this.Controls.Add(this.deneg100);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SniatUkr";
            this.Text = "Withdraw money";
            this.Move += new System.EventHandler(this.SniatUkr_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        public System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button deneg1000;
        private System.Windows.Forms.Button deneg300;
        private System.Windows.Forms.Button deneg200;
        private System.Windows.Forms.Button deneg100;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}