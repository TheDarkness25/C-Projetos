namespace Pedra_Papel_Tesoura
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnTesoura = new System.Windows.Forms.Button();
            this.BtnPapel = new System.Windows.Forms.Button();
            this.BtnPedra = new System.Windows.Forms.Button();
            this.PicJogador = new System.Windows.Forms.PictureBox();
            this.PicMaq = new System.Windows.Forms.PictureBox();
            this.Jogador = new System.Windows.Forms.Label();
            this.Maquina = new System.Windows.Forms.Label();
            this.LbPtJog = new System.Windows.Forms.Label();
            this.LbPtmaq = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaq)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTesoura
            // 
            this.BtnTesoura.BackColor = System.Drawing.SystemColors.Window;
            this.BtnTesoura.BackgroundImage = global::Pedra_Papel_Tesoura.Properties.Resources.Tesoura;
            this.BtnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTesoura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTesoura.Location = new System.Drawing.Point(357, 304);
            this.BtnTesoura.Name = "BtnTesoura";
            this.BtnTesoura.Size = new System.Drawing.Size(90, 90);
            this.BtnTesoura.TabIndex = 0;
            this.BtnTesoura.Tag = "2";
            this.BtnTesoura.UseVisualStyleBackColor = false;
            this.BtnTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtnPapel
            // 
            this.BtnPapel.BackColor = System.Drawing.SystemColors.Window;
            this.BtnPapel.BackgroundImage = global::Pedra_Papel_Tesoura.Properties.Resources.Papel;
            this.BtnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPapel.Location = new System.Drawing.Point(184, 304);
            this.BtnPapel.Name = "BtnPapel";
            this.BtnPapel.Size = new System.Drawing.Size(90, 90);
            this.BtnPapel.TabIndex = 1;
            this.BtnPapel.Tag = "1";
            this.BtnPapel.UseVisualStyleBackColor = false;
            this.BtnPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtnPedra
            // 
            this.BtnPedra.BackColor = System.Drawing.SystemColors.Window;
            this.BtnPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPedra.BackgroundImage")));
            this.BtnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPedra.Location = new System.Drawing.Point(12, 304);
            this.BtnPedra.Name = "BtnPedra";
            this.BtnPedra.Size = new System.Drawing.Size(90, 90);
            this.BtnPedra.TabIndex = 2;
            this.BtnPedra.Tag = "0";
            this.BtnPedra.UseVisualStyleBackColor = false;
            this.BtnPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // PicJogador
            // 
            this.PicJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicJogador.Location = new System.Drawing.Point(12, 65);
            this.PicJogador.Name = "PicJogador";
            this.PicJogador.Size = new System.Drawing.Size(150, 150);
            this.PicJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicJogador.TabIndex = 3;
            this.PicJogador.TabStop = false;
            // 
            // PicMaq
            // 
            this.PicMaq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicMaq.Location = new System.Drawing.Point(297, 65);
            this.PicMaq.Name = "PicMaq";
            this.PicMaq.Size = new System.Drawing.Size(150, 150);
            this.PicMaq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMaq.TabIndex = 4;
            this.PicMaq.TabStop = false;
            // 
            // Jogador
            // 
            this.Jogador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jogador.Location = new System.Drawing.Point(12, 25);
            this.Jogador.Name = "Jogador";
            this.Jogador.Size = new System.Drawing.Size(150, 37);
            this.Jogador.TabIndex = 5;
            this.Jogador.Text = "Jogador";
            this.Jogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Maquina
            // 
            this.Maquina.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maquina.Location = new System.Drawing.Point(297, 25);
            this.Maquina.Name = "Maquina";
            this.Maquina.Size = new System.Drawing.Size(150, 37);
            this.Maquina.TabIndex = 6;
            this.Maquina.Text = "Máquina";
            this.Maquina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPtJog
            // 
            this.LbPtJog.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtJog.Location = new System.Drawing.Point(168, 133);
            this.LbPtJog.Name = "LbPtJog";
            this.LbPtJog.Size = new System.Drawing.Size(40, 20);
            this.LbPtJog.TabIndex = 7;
            this.LbPtJog.Text = "0";
            this.LbPtJog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbPtJog.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbPtmaq
            // 
            this.LbPtmaq.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtmaq.Location = new System.Drawing.Point(251, 133);
            this.LbPtmaq.Name = "LbPtmaq";
            this.LbPtmaq.Size = new System.Drawing.Size(40, 20);
            this.LbPtmaq.TabIndex = 8;
            this.LbPtmaq.Text = "0";
            this.LbPtmaq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pedra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Papel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tesoura";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(459, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbPtmaq);
            this.Controls.Add(this.LbPtJog);
            this.Controls.Add(this.Maquina);
            this.Controls.Add(this.Jogador);
            this.Controls.Add(this.PicMaq);
            this.Controls.Add(this.PicJogador);
            this.Controls.Add(this.BtnPedra);
            this.Controls.Add(this.BtnPapel);
            this.Controls.Add(this.BtnTesoura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra Papel Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTesoura;
        private System.Windows.Forms.Button BtnPapel;
        private System.Windows.Forms.Button BtnPedra;
        private System.Windows.Forms.PictureBox PicJogador;
        private System.Windows.Forms.PictureBox PicMaq;
        private System.Windows.Forms.Label Jogador;
        private System.Windows.Forms.Label Maquina;
        private System.Windows.Forms.Label LbPtJog;
        private System.Windows.Forms.Label LbPtmaq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

