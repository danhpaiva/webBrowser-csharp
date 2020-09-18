namespace PaivaFox
{
    partial class PaivaFox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaivaFox));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.btn_ir = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_definirHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(922, 532);
            this.webBrowser1.TabIndex = 0;
            // 
            // tb_url
            // 
            this.tb_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.Location = new System.Drawing.Point(149, 6);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(390, 31);
            this.tb_url.TabIndex = 1;
            this.tb_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_url_KeyDown);
            // 
            // btn_ir
            // 
            this.btn_ir.BackColor = System.Drawing.Color.Transparent;
            this.btn_ir.BackgroundImage = global::PaivaFox.Properties.Resources.worldwide;
            this.btn_ir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ir.Location = new System.Drawing.Point(560, 3);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.Size = new System.Drawing.Size(35, 35);
            this.btn_ir.TabIndex = 2;
            this.btn_ir.UseVisualStyleBackColor = false;
            this.btn_ir.Click += new System.EventHandler(this.Btn_ir_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = global::PaivaFox.Properties.Resources.home_icon_silhouette;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Location = new System.Drawing.Point(49, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(35, 35);
            this.btn_home.TabIndex = 3;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.BackgroundImage = global::PaivaFox.Properties.Resources.left_arrow;
            this.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(5, 3);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.BackColor = System.Drawing.Color.Transparent;
            this.btn_proximo.BackgroundImage = global::PaivaFox.Properties.Resources.right_arrow;
            this.btn_proximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_proximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proximo.Location = new System.Drawing.Point(95, 3);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(35, 35);
            this.btn_proximo.TabIndex = 5;
            this.btn_proximo.UseVisualStyleBackColor = false;
            this.btn_proximo.Click += new System.EventHandler(this.Btn_proximo_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.BackColor = System.Drawing.Color.Transparent;
            this.btn_parar.BackgroundImage = global::PaivaFox.Properties.Resources.cancel_button;
            this.btn_parar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_parar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_parar.Location = new System.Drawing.Point(664, 3);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(35, 35);
            this.btn_parar.TabIndex = 6;
            this.btn_parar.UseVisualStyleBackColor = false;
            this.btn_parar.Click += new System.EventHandler(this.Btn_parar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.BackgroundImage = global::PaivaFox.Properties.Resources.refresh_button;
            this.btn_atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.Location = new System.Drawing.Point(611, 3);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(35, 35);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Location = new System.Drawing.Point(742, 3);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(80, 35);
            this.btn_pesquisar.TabIndex = 8;
            this.btn_pesquisar.Text = "Pesquisa";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.Btn_pesquisar_Click);
            // 
            // btn_definirHome
            // 
            this.btn_definirHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_definirHome.FlatAppearance.BorderSize = 0;
            this.btn_definirHome.Location = new System.Drawing.Point(834, 3);
            this.btn_definirHome.Name = "btn_definirHome";
            this.btn_definirHome.Size = new System.Drawing.Size(80, 35);
            this.btn_definirHome.TabIndex = 9;
            this.btn_definirHome.Text = "Definir Home";
            this.btn_definirHome.UseVisualStyleBackColor = true;
            this.btn_definirHome.Click += new System.EventHandler(this.Btn_definirHome_Click);
            // 
            // PaivaFox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 573);
            this.Controls.Add(this.btn_definirHome);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_ir);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaivaFox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaivaFox - Uma maneira rápida de navegar na Web";
            this.Load += new System.EventHandler(this.PaivaFox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_definirHome;
    }
}

