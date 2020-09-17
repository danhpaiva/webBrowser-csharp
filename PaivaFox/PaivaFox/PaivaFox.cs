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
            Navegar();
        }
    }
}
