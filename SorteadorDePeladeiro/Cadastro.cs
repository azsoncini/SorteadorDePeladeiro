using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteadorDePeladeiro
{
    public partial class Cadastro : Form
    {
        public List<string> cadastro_add = new List<string>();
        public DialogResult result = DialogResult.None;
        /*string nome;
        string posicao;
        int desarme=0;
        int cobertura=0;
        int passe=0;
        int lancamento=0;
        int drible=0;
        int fominha=0;
        int chute_longo=0;
        int finalizacao=0;
        int velocidade=0;
        int forca=0;
        int dominio=0;
        int folego=0;*/

        public Cadastro()
        {
            InitializeComponent();
        }

        public Cadastro(ListViewItem cadastro_edit)
        {
            int x = 0;

            InitializeComponent();
            txt_nome.Text = cadastro_edit.SubItems[x++].Text;
            cmb_posicao.Text = cadastro_edit.SubItems[x++].Text;
            num_desarme.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_cobertura.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_passe.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_lancamento.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_drible.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_fominha.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_chute_longo.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_finalizacao.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_velocidade.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_forca.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_dominio.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
            num_folego.Value = int.Parse(cadastro_edit.SubItems[x++].Text);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Coloque o nome do Jogador.");
                return;
            }
            if (cmb_posicao.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Escolha uma Posição.");
                return;
            }

            cadastro_add.Add(txt_nome.Text);
            cadastro_add.Add(cmb_posicao.SelectedItem.ToString());
            cadastro_add.Add(num_desarme.Value.ToString());
            cadastro_add.Add(num_cobertura.Value.ToString());
            cadastro_add.Add(num_passe.Value.ToString());
            cadastro_add.Add(num_lancamento.Value.ToString());
            cadastro_add.Add(num_drible.Value.ToString());
            cadastro_add.Add(num_fominha.Value.ToString());
            cadastro_add.Add(num_chute_longo.Value.ToString());
            cadastro_add.Add(num_finalizacao.Value.ToString());
            cadastro_add.Add(num_velocidade.Value.ToString());
            cadastro_add.Add(num_forca.Value.ToString());
            cadastro_add.Add(num_dominio.Value.ToString());
            cadastro_add.Add(num_folego.Value.ToString());
            result = DialogResult.OK;
            this.Close();

            /*
            this.nome = txt_nome.Text;
            this.posicao = cmb_posicao.SelectedItem.ToString();
            this.desarme = int.Parse(num_desarme.Value.ToString());
            this.cobertura = int.Parse(num_cobertura.Value.ToString());
            this.passe = int.Parse(num_passe.Value.ToString());
            this.lancamento = int.Parse(num_lancamento.ToString());
            this.drible = int.Parse(num_drible.ToString());
            this.fominha = int.Parse(num_fominha.ToString());
            this.chute_longo = int.Parse(num_chute_longo.ToString());
            this.finalizacao = int.Parse(num_finalizacao.ToString());
            this.velocidade = int.Parse(num_velocidade.ToString());
            this.forca = int.Parse(num_forca.ToString());
            this.dominio = int.Parse(num_dominio.ToString());
            this.folego = int.Parse(num_folego.ToString());*/
        }

        private void cmb_posicao_Enter(object sender, EventArgs e)
        {
            cmb_posicao.DroppedDown = true;
        }

        private void cmb_posicao_Leave(object sender, EventArgs e)
        {
            cmb_posicao.DroppedDown = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Close();
        }
    }
}
