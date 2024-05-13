namespace Курсовая_Имитация_банкомата_
{
    partial class PopovnitRus
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
            this.Back = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deneg100 = new System.Windows.Forms.Button();
            this.deneg200 = new System.Windows.Forms.Button();
            this.deneg300 = new System.Windows.Forms.Button();
            this.deneg1000 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Crimson;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(316, 166);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 50);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            this.Back.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Harrington", 14F, System.Drawing.FontStyle.Bold);
            this.balance.Location = new System.Drawing.Point(441, 45);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(54, 29);
            this.balance.TabIndex = 1;
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.Exit.Location = new System.Drawing.Point(441, 166);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 50);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Завершить сеанс";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(347, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // deneg100
            // 
            this.deneg100.BackColor = System.Drawing.Color.White;
            this.deneg100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deneg100.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.deneg100.Location = new System.Drawing.Point(134, 12);
            this.deneg100.Name = "deneg100";
            this.deneg100.Size = new System.Drawing.Size(80, 50);
            this.deneg100.TabIndex = 3;
            this.deneg100.Text = "Пополнить на 100 денежных единиц";
            this.deneg100.UseVisualStyleBackColor = false;
            this.deneg100.Click += new System.EventHandler(this.button2_Click);
            this.deneg100.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.deneg100.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // deneg200
            // 
            this.deneg200.BackColor = System.Drawing.Color.White;
            this.deneg200.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deneg200.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.deneg200.Location = new System.Drawing.Point(134, 68);
            this.deneg200.Name = "deneg200";
            this.deneg200.Size = new System.Drawing.Size(80, 50);
            this.deneg200.TabIndex = 4;
            this.deneg200.Text = "Пополнить на 200 денежных единиц";
            this.deneg200.UseVisualStyleBackColor = false;
            this.deneg200.Click += new System.EventHandler(this.button3_Click);
            this.deneg200.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.deneg200.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // deneg300
            // 
            this.deneg300.BackColor = System.Drawing.Color.White;
            this.deneg300.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deneg300.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.deneg300.Location = new System.Drawing.Point(134, 124);
            this.deneg300.Name = "deneg300";
            this.deneg300.Size = new System.Drawing.Size(80, 50);
            this.deneg300.TabIndex = 5;
            this.deneg300.Text = "Пополнить на 500 денежных единиц";
            this.deneg300.UseVisualStyleBackColor = false;
            this.deneg300.Click += new System.EventHandler(this.button4_Click);
            this.deneg300.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.deneg300.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // deneg1000
            // 
            this.deneg1000.BackColor = System.Drawing.Color.White;
            this.deneg1000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deneg1000.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.deneg1000.Location = new System.Drawing.Point(134, 180);
            this.deneg1000.Name = "deneg1000";
            this.deneg1000.Size = new System.Drawing.Size(80, 50);
            this.deneg1000.TabIndex = 6;
            this.deneg1000.Text = "Пополнить на 1000 денежных единиц";
            this.deneg1000.UseVisualStyleBackColor = false;
            this.deneg1000.Click += new System.EventHandler(this.button5_Click);
            this.deneg1000.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.deneg1000.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // PopovnitRus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.deneg1000);
            this.Controls.Add(this.deneg300);
            this.Controls.Add(this.deneg200);
            this.Controls.Add(this.deneg100);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PopovnitRus";
            this.Text = "Top up card";
            this.Move += new System.EventHandler(this.PopovnitRus_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox balance;
        public System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deneg100;
        private System.Windows.Forms.Button deneg200;
        private System.Windows.Forms.Button deneg300;
        private System.Windows.Forms.Button deneg1000;
    }
}