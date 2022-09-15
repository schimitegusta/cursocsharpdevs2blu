namespace Devs2Blu.ProjetosAula6.Jogo21
{
    partial class Form1
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
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.btPlayer1 = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtConsoleP1 = new System.Windows.Forms.TextBox();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.btPlayer2 = new System.Windows.Forms.Button();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtConsoleP2 = new System.Windows.Forms.TextBox();
            this.gbConsole = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            this.gbConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.btPlayer1);
            this.gbPlayer1.Controls.Add(this.txtPlayer1);
            this.gbPlayer1.Controls.Add(this.txtConsoleP1);
            this.gbPlayer1.Location = new System.Drawing.Point(12, 281);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(300, 200);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            // 
            // btPlayer1
            // 
            this.btPlayer1.Enabled = false;
            this.btPlayer1.Location = new System.Drawing.Point(180, 171);
            this.btPlayer1.Name = "btPlayer1";
            this.btPlayer1.Size = new System.Drawing.Size(75, 23);
            this.btPlayer1.TabIndex = 2;
            this.btPlayer1.Text = "OK";
            this.btPlayer1.UseVisualStyleBackColor = true;
            this.btPlayer1.Click += new System.EventHandler(this.btPlayer1_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Enabled = false;
            this.txtPlayer1.Location = new System.Drawing.Point(48, 171);
            this.txtPlayer1.Multiline = true;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(100, 23);
            this.txtPlayer1.TabIndex = 1;
            this.txtPlayer1.Text = "0";
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConsoleP1
            // 
            this.txtConsoleP1.Enabled = false;
            this.txtConsoleP1.Location = new System.Drawing.Point(6, 19);
            this.txtConsoleP1.Multiline = true;
            this.txtConsoleP1.Name = "txtConsoleP1";
            this.txtConsoleP1.Size = new System.Drawing.Size(288, 146);
            this.txtConsoleP1.TabIndex = 0;
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.btPlayer2);
            this.gbPlayer2.Controls.Add(this.txtPlayer2);
            this.gbPlayer2.Controls.Add(this.txtConsoleP2);
            this.gbPlayer2.Location = new System.Drawing.Point(508, 281);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(300, 200);
            this.gbPlayer2.TabIndex = 1;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2";
            // 
            // btPlayer2
            // 
            this.btPlayer2.Enabled = false;
            this.btPlayer2.Location = new System.Drawing.Point(178, 171);
            this.btPlayer2.Name = "btPlayer2";
            this.btPlayer2.Size = new System.Drawing.Size(75, 23);
            this.btPlayer2.TabIndex = 3;
            this.btPlayer2.Text = "OK";
            this.btPlayer2.UseVisualStyleBackColor = true;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Enabled = false;
            this.txtPlayer2.Location = new System.Drawing.Point(50, 171);
            this.txtPlayer2.Multiline = true;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(100, 23);
            this.txtPlayer2.TabIndex = 2;
            this.txtPlayer2.Text = "0";
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConsoleP2
            // 
            this.txtConsoleP2.Enabled = false;
            this.txtConsoleP2.Location = new System.Drawing.Point(6, 19);
            this.txtConsoleP2.Multiline = true;
            this.txtConsoleP2.Name = "txtConsoleP2";
            this.txtConsoleP2.Size = new System.Drawing.Size(288, 146);
            this.txtConsoleP2.TabIndex = 0;
            // 
            // gbConsole
            // 
            this.gbConsole.Controls.Add(this.txtConsole);
            this.gbConsole.Location = new System.Drawing.Point(12, 12);
            this.gbConsole.Name = "gbConsole";
            this.gbConsole.Size = new System.Drawing.Size(796, 263);
            this.gbConsole.TabIndex = 2;
            this.gbConsole.TabStop = false;
            this.gbConsole.Text = "Jogo 21 - Console";
            // 
            // txtConsole
            // 
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.Location = new System.Drawing.Point(6, 19);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(784, 238);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "BEM VINDO AO JOGO 21!";
            this.txtConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(374, 340);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 3;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(374, 379);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(820, 493);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.gbConsole);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Name = "Form1";
            this.Text = "Jogo 21";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            this.gbConsole.ResumeLayout(false);
            this.gbConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.Button btPlayer1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtConsoleP1;
        private System.Windows.Forms.Button btPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtConsoleP2;
        private System.Windows.Forms.GroupBox gbConsole;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btLimpar;
    }
}

