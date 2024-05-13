namespace Курсовая_Имитация_банкомата_
{
    partial class OperationsEng
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
            this.balance = new System.Windows.Forms.TextBox();
            this.CheckBalance = new System.Windows.Forms.Button();
            this.Tranzaksii = new System.Windows.Forms.Button();
            this.zavershit = new System.Windows.Forms.Button();
            this.sniat = new System.Windows.Forms.Button();
            this.popolnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Harrington", 14F, System.Drawing.FontStyle.Bold);
            this.balance.Location = new System.Drawing.Point(462, 37);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(54, 29);
            this.balance.TabIndex = 13;
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.balance.TextChanged += new System.EventHandler(this.balance_TextChanged);
            // 
            // CheckBalance
            // 
            this.CheckBalance.BackColor = System.Drawing.Color.White;
            this.CheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBalance.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBalance.Location = new System.Drawing.Point(355, 18);
            this.CheckBalance.Name = "CheckBalance";
            this.CheckBalance.Size = new System.Drawing.Size(92, 59);
            this.CheckBalance.TabIndex = 12;
            this.CheckBalance.Text = "View balance";
            this.CheckBalance.UseVisualStyleBackColor = false;
            this.CheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            this.CheckBalance.MouseEnter += new System.EventHandler(this.CheckBalance_MouseEnter);
            this.CheckBalance.MouseLeave += new System.EventHandler(this.CheckBalance_MouseLeave);
            // 
            // Tranzaksii
            // 
            this.Tranzaksii.BackColor = System.Drawing.Color.White;
            this.Tranzaksii.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tranzaksii.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.Tranzaksii.Location = new System.Drawing.Point(159, 163);
            this.Tranzaksii.Name = "Tranzaksii";
            this.Tranzaksii.Size = new System.Drawing.Size(92, 59);
            this.Tranzaksii.TabIndex = 11;
            this.Tranzaksii.Text = "Transactions";
            this.Tranzaksii.UseVisualStyleBackColor = false;
            this.Tranzaksii.Click += new System.EventHandler(this.Tranzaksii_Click);
            this.Tranzaksii.MouseEnter += new System.EventHandler(this.Tranzaksii_MouseEnter);
            this.Tranzaksii.MouseLeave += new System.EventHandler(this.Tranzaksii_MouseLeave);
            // 
            // zavershit
            // 
            this.zavershit.BackColor = System.Drawing.Color.Crimson;
            this.zavershit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zavershit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.zavershit.Location = new System.Drawing.Point(384, 139);
            this.zavershit.Name = "zavershit";
            this.zavershit.Size = new System.Drawing.Size(118, 70);
            this.zavershit.TabIndex = 10;
            this.zavershit.Text = "End session";
            this.zavershit.UseVisualStyleBackColor = false;
            this.zavershit.Click += new System.EventHandler(this.zavershit_Click);
            this.zavershit.MouseEnter += new System.EventHandler(this.zavershit_MouseEnter);
            this.zavershit.MouseLeave += new System.EventHandler(this.zavershit_MouseLeave);
            // 
            // sniat
            // 
            this.sniat.BackColor = System.Drawing.Color.White;
            this.sniat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sniat.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.sniat.Location = new System.Drawing.Point(159, 88);
            this.sniat.Name = "sniat";
            this.sniat.Size = new System.Drawing.Size(92, 59);
            this.sniat.TabIndex = 9;
            this.sniat.Text = "Withdraw money";
            this.sniat.UseVisualStyleBackColor = false;
            this.sniat.Click += new System.EventHandler(this.sniat_Click);
            this.sniat.MouseEnter += new System.EventHandler(this.sniat_MouseEnter);
            this.sniat.MouseLeave += new System.EventHandler(this.sniat_MouseLeave);
            // 
            // popolnit
            // 
            this.popolnit.BackColor = System.Drawing.Color.White;
            this.popolnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.popolnit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.popolnit.Location = new System.Drawing.Point(159, 13);
            this.popolnit.Name = "popolnit";
            this.popolnit.Size = new System.Drawing.Size(92, 59);
            this.popolnit.TabIndex = 8;
            this.popolnit.Text = "Top up account";
            this.popolnit.UseVisualStyleBackColor = false;
            this.popolnit.Click += new System.EventHandler(this.popolnit_Click);
            this.popolnit.MouseEnter += new System.EventHandler(this.popolnit_MouseEnter);
            this.popolnit.MouseLeave += new System.EventHandler(this.popolnit_MouseLeave);
            // 
            // OperationsEng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.CheckBalance);
            this.Controls.Add(this.Tranzaksii);
            this.Controls.Add(this.zavershit);
            this.Controls.Add(this.sniat);
            this.Controls.Add(this.popolnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OperationsEng";
            this.Text = "Operations";
            this.Move += new System.EventHandler(this.OperationsEng_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox balance;
        public System.Windows.Forms.Button CheckBalance;
        private System.Windows.Forms.Button Tranzaksii;
        private System.Windows.Forms.Button zavershit;
        private System.Windows.Forms.Button sniat;
        private System.Windows.Forms.Button popolnit;
    }
}