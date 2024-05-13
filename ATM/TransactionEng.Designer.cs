namespace Курсовая_Имитация_банкомата_
{
    partial class TransactionEng
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summa = new System.Windows.Forms.TextBox();
            this.perevod = new System.Windows.Forms.Button();
            this.karta = new System.Windows.Forms.TextBox();
            this.perevodnakartu = new System.Windows.Forms.Button();
            this.vvodkolichestva = new System.Windows.Forms.TextBox();
            this.pop = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PodtverditTelefon = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(397, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(403, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 30;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.Exit.Location = new System.Drawing.Point(445, 192);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 50);
            this.Exit.TabIndex = 29;
            this.Exit.Text = "End session";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(112, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(112, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 27;
            // 
            // summa
            // 
            this.summa.Font = new System.Drawing.Font("Harrington", 14F, System.Drawing.FontStyle.Bold);
            this.summa.Location = new System.Drawing.Point(457, 139);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(79, 29);
            this.summa.TabIndex = 26;
            this.summa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.summa_KeyPress);
            // 
            // perevod
            // 
            this.perevod.BackColor = System.Drawing.Color.White;
            this.perevod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.perevod.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.perevod.Location = new System.Drawing.Point(362, 130);
            this.perevod.Name = "perevod";
            this.perevod.Size = new System.Drawing.Size(89, 50);
            this.perevod.TabIndex = 25;
            this.perevod.Text = "Transfer";
            this.perevod.UseVisualStyleBackColor = false;
            this.perevod.Click += new System.EventHandler(this.perevod_Click);
            this.perevod.MouseEnter += new System.EventHandler(this.perevod_MouseEnter);
            this.perevod.MouseLeave += new System.EventHandler(this.perevod_MouseLeave);
            // 
            // karta
            // 
            this.karta.Font = new System.Drawing.Font("Harrington", 14F, System.Drawing.FontStyle.Bold);
            this.karta.Location = new System.Drawing.Point(216, 139);
            this.karta.Name = "karta";
            this.karta.Size = new System.Drawing.Size(140, 29);
            this.karta.TabIndex = 24;
            this.karta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.karta_KeyPress);
            // 
            // perevodnakartu
            // 
            this.perevodnakartu.BackColor = System.Drawing.Color.White;
            this.perevodnakartu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.perevodnakartu.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.perevodnakartu.Location = new System.Drawing.Point(115, 131);
            this.perevodnakartu.Name = "perevodnakartu";
            this.perevodnakartu.Size = new System.Drawing.Size(95, 43);
            this.perevodnakartu.TabIndex = 23;
            this.perevodnakartu.Text = "Card entry";
            this.perevodnakartu.UseVisualStyleBackColor = false;
            this.perevodnakartu.Click += new System.EventHandler(this.perevodnakartu_Click);
            this.perevodnakartu.MouseEnter += new System.EventHandler(this.perevodnakartu_MouseEnter);
            this.perevodnakartu.MouseLeave += new System.EventHandler(this.perevodnakartu_MouseLeave);
            // 
            // vvodkolichestva
            // 
            this.vvodkolichestva.Font = new System.Drawing.Font("Harrington", 14F, System.Drawing.FontStyle.Bold);
            this.vvodkolichestva.Location = new System.Drawing.Point(457, 73);
            this.vvodkolichestva.Name = "vvodkolichestva";
            this.vvodkolichestva.Size = new System.Drawing.Size(79, 29);
            this.vvodkolichestva.TabIndex = 22;
            this.vvodkolichestva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodkolichestva_KeyPress);
            // 
            // pop
            // 
            this.pop.BackColor = System.Drawing.Color.White;
            this.pop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pop.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.pop.Location = new System.Drawing.Point(362, 62);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(89, 50);
            this.pop.TabIndex = 21;
            this.pop.Text = "Replenish";
            this.pop.UseVisualStyleBackColor = false;
            this.pop.Click += new System.EventHandler(this.pop_Click);
            this.pop.MouseEnter += new System.EventHandler(this.pop_MouseEnter);
            this.pop.MouseLeave += new System.EventHandler(this.pop_MouseLeave);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.Location = new System.Drawing.Point(216, 81);
            this.maskedTextBox1.Mask = "+38(000)-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(140, 25);
            this.maskedTextBox1.TabIndex = 20;
            
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 19;
            // 
            // PodtverditTelefon
            // 
            this.PodtverditTelefon.BackColor = System.Drawing.Color.White;
            this.PodtverditTelefon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PodtverditTelefon.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.PodtverditTelefon.Location = new System.Drawing.Point(115, 69);
            this.PodtverditTelefon.Name = "PodtverditTelefon";
            this.PodtverditTelefon.Size = new System.Drawing.Size(95, 43);
            this.PodtverditTelefon.TabIndex = 18;
            this.PodtverditTelefon.Text = "Verify Phone";
            this.PodtverditTelefon.UseVisualStyleBackColor = false;
            this.PodtverditTelefon.Click += new System.EventHandler(this.PodtverditTelefon_Click);
            this.PodtverditTelefon.MouseEnter += new System.EventHandler(this.PodtverditTelefon_MouseEnter);
            this.PodtverditTelefon.MouseLeave += new System.EventHandler(this.PodtverditTelefon_MouseLeave);
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Harrington", 14F, System.Drawing.FontStyle.Bold);
            this.balance.Location = new System.Drawing.Point(343, 17);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(54, 29);
            this.balance.TabIndex = 16;
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Crimson;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(235, 192);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 50);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TransactionEng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.perevod);
            this.Controls.Add(this.karta);
            this.Controls.Add(this.perevodnakartu);
            this.Controls.Add(this.vvodkolichestva);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PodtverditTelefon);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.Back);
            this.Name = "TransactionEng";
            this.Text = "Transaction";
            this.Move += new System.EventHandler(this.TransactionEng_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox summa;
        private System.Windows.Forms.Button perevod;
        private System.Windows.Forms.TextBox karta;
        private System.Windows.Forms.Button perevodnakartu;
        private System.Windows.Forms.TextBox vvodkolichestva;
        private System.Windows.Forms.Button pop;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PodtverditTelefon;
        public System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}