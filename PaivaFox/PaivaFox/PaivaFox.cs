using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaivaFox
{
    public partial class PaivaFox : Form
    {
        string home = null;
        public PaivaFox()
        {
            InitializeComponent();
        }

        private void Navegar()
        {
            if (tb_url.Text != "")
                webBrowser1.Navigate(tb_url.Text);
            else
            {
                MessageBox.Show("Digite um endereço válido");
                tb_url.Focus();
            }
        }

        private void Btn_ir_Click(object sender, EventArgs e)
        {
            Navegar();
        }

        private void Tb_url_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                Navegar();
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            if(home == null)
                webBrowser1.GoHome();
            else
            {
                webBrowser1.Navigate(home);
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Btn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_GoForwardChanged(object sender, EventArgs e)
        {
            btn_proximo.Enabled = webBrowser1.CanGoForward;
        }
        private void webBrowser1_GoBackChanged(object sender, EventArgs e)
        {
            btn_voltar.Enabled = webBrowser1.CanGoBack;
        }

        private void Btn_parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Btn_pesquisar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void Btn_definirHome_Click(object sender, EventArgs e)
        {
            home = tb_url.Text;
        }

        private void PaivaFox_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }
    }
}
