using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SorteadorDePeladeiro
{
    public partial class Main_Form : Form
    {
        public struct Peladeiro
        {
            public int id;
            public string nome;
            public string posicao;
            public int desarme;
            public int cobertura;
            public int passe;
            public int lancamento;
            public int drible;
            public int fominha;
            public int chute_longo;
            public int finalizacao;
            public int velocidade;
            public int forca;
            public int dominio;
            public int folego;
            public double nota;
        };
        Peladeiro[] jogador;


        public Main_Form()
        {
            InitializeComponent();
            lst_peladeiros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            if(File.Exists("jogadores.txt"))
            {
                string[] rows = new string[14];
                StreamReader sr = new StreamReader("jogadores.txt");

                while (!sr.EndOfStream)
                {
                    for (int x = 0; x < 14; x++)
                    {
                        rows[x] = sr.ReadLine();
                    }

                    ListViewItem lvi = new ListViewItem(rows);
                    lst_peladeiros.Items.Add(lvi);
                }
                sr.Close();

                lst_peladeiros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Cadastro form_cadastro = new Cadastro();
            form_cadastro.ShowDialog();
            if (form_cadastro.result == DialogResult.OK)
            {
                string[] rows = new string[14];

                for (int x = 0; x < form_cadastro.cadastro_add.Count; x++)
                {
                    rows[x] = form_cadastro.cadastro_add[x];
                }

                ListViewItem lvi = new ListViewItem(rows);

                lst_peladeiros.Items.Add(lvi);
                lst_peladeiros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                save_peladeiros();
            }
        }

        private void save_peladeiros ()
        {
           // if(File.Exists("jogadores.txt"))
             //   File.Delete("jogadores.txt")

            using (StreamWriter sw = new StreamWriter("jogadores.txt"))
            {
                foreach (ListViewItem item in lst_peladeiros.Items)
                {
                    sw.WriteLine(item.Text);
                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                        sw.WriteLine(item.SubItems[i].Text);
                    }
                }
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (lst_peladeiros.SelectedItems.Count != 0)
            {
                for (int x = lst_peladeiros.SelectedItems.Count; x > 0 ; x--)
                {
                    lst_peladeiros.Items.RemoveAt(lst_peladeiros.SelectedItems[x-1].Index);
                }
                save_peladeiros();
                lst_peladeiros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_peladeiros.SelectedItems.Count != 0)
            {
                int edit_index = lst_peladeiros.SelectedIndices[0];
                ListViewItem lvi_edit = lst_peladeiros.SelectedItems[0];
                Cadastro form_cadastro = new Cadastro(lvi_edit);
                form_cadastro.ShowDialog();
                if (form_cadastro.result == DialogResult.OK)
                {
                    string[] rows = new string[14];

                    for (int x = 0; x < form_cadastro.cadastro_add.Count; x++)
                    {
                        rows[x] = form_cadastro.cadastro_add[x];
                    }

                    ListViewItem lvi = new ListViewItem(rows);
                    lst_peladeiros.Items.Insert(edit_index, lvi);
                    lst_peladeiros.Items.RemoveAt(edit_index+1);
                }
                save_peladeiros();
                lst_peladeiros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void lst_peladeiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_qtd_jogadores.Text = lst_peladeiros.SelectedIndices.Count.ToString();
        }

        private void btn_sortear_Click(object sender, EventArgs e)
        {
            bool ok;

            ok = get_jogadores();
            if(ok)
            {
                calcula_atributo_por_posicao();
                normaliza();
                sortear_jogadores();
            }
        }

        private bool get_jogadores()
        {
            int qtd_jogadores = lst_peladeiros.SelectedIndices.Count;
            if (lst_peladeiros.SelectedIndices.Count < 2)
            {
                MessageBox.Show("Selecione mais jogadores");
                return false;
            }

            jogador = new Peladeiro[qtd_jogadores];

            for (int x = 0; x < qtd_jogadores; x++)
            {
                jogador[x].id = x;
                jogador[x].nome = lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[0].Text;
                jogador[x].posicao = lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[1].Text;
                jogador[x].desarme = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[2].Text);
                jogador[x].cobertura = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[3].Text);
                jogador[x].passe = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[4].Text);
                jogador[x].lancamento = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[5].Text);
                jogador[x].drible = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[6].Text);
                jogador[x].fominha = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[7].Text);
                jogador[x].chute_longo = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[8].Text);
                jogador[x].finalizacao = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[9].Text);
                jogador[x].velocidade = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[10].Text);
                jogador[x].forca = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[11].Text);
                jogador[x].dominio = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[12].Text);
                jogador[x].folego = int.Parse(lst_peladeiros.Items[lst_peladeiros.SelectedIndices[x]].SubItems[13].Text);
            }
            return true;
        }

        private void calcula_atributo_por_posicao()
        {
            int x = 0;
            while (x != lst_peladeiros.SelectedIndices.Count)
            {
                jogador[x].nota = 0;
                if (jogador[x].posicao == "Zagueiro")
                {
                    jogador[x].nota += jogador[x].desarme * 1.1;
                    jogador[x].nota += jogador[x].cobertura * 1.1;
                    jogador[x].nota += jogador[x].passe * 1;
                    jogador[x].nota += jogador[x].lancamento * 0.6;
                    jogador[x].nota += jogador[x].drible * 0.5;
                    jogador[x].nota += jogador[x].chute_longo * 0.5;
                    jogador[x].nota += jogador[x].finalizacao * 0.1;
                    jogador[x].nota += jogador[x].velocidade * 0.6;
                    jogador[x].nota += jogador[x].forca * 0.8;
                    jogador[x].nota += jogador[x].dominio * 0.2;
                    jogador[x].nota += jogador[x].folego * 0.3;
                    //jogador[x].nota = Math.Round((jogador[x].nota * 78) / 61);
                    x++;
                }
                else if (jogador[x].posicao == "Volante")
                {
                    jogador[x].nota += jogador[x].desarme * 0.6;
                    jogador[x].nota += jogador[x].cobertura * 0.7;
                    jogador[x].nota += jogador[x].passe * 1;
                    jogador[x].nota += jogador[x].lancamento * 0.8;
                    jogador[x].nota += jogador[x].drible * 0.8;
                    jogador[x].nota += jogador[x].chute_longo * 0.9;
                    jogador[x].nota += jogador[x].finalizacao * 0.5;
                    jogador[x].nota += jogador[x].velocidade * 0.6;
                    jogador[x].nota += jogador[x].forca * 0.5;
                    jogador[x].nota += jogador[x].dominio * 1;
                    jogador[x].nota += jogador[x].folego * 0.4;
                    //jogador[x].nota = Math.Round((jogador[x].nota * 78) / 51);
                    x++;
                }
                else if (jogador[x].posicao == "Lateral")
                {
                    jogador[x].nota += jogador[x].desarme * 0.6;
                    jogador[x].nota += jogador[x].cobertura * 0.8;
                    jogador[x].nota += jogador[x].passe * 0.6;
                    jogador[x].nota += jogador[x].lancamento * 0.8;
                    jogador[x].nota += jogador[x].drible * 0.4;
                    jogador[x].nota += jogador[x].chute_longo * 0.2;
                    jogador[x].nota += jogador[x].finalizacao * 0.2;
                    jogador[x].nota += jogador[x].velocidade * 1;
                    jogador[x].nota += jogador[x].forca * 0.3;
                    jogador[x].nota += jogador[x].dominio * 0.4;
                    jogador[x].nota += jogador[x].folego * 0.7;
                    //jogador[x].nota = Math.Round((jogador[x].nota * 78) / 51);
                    x++;
                }
                else if (jogador[x].posicao == "Meio Campo")
                {
                    jogador[x].nota += jogador[x].desarme * 0.2;
                    jogador[x].nota += jogador[x].cobertura * 0.5;
                    jogador[x].nota += jogador[x].passe * 1;
                    jogador[x].nota += jogador[x].lancamento * 0.8;
                    jogador[x].nota += jogador[x].drible * 1;
                    jogador[x].nota += jogador[x].chute_longo * 0.8;
                    jogador[x].nota += jogador[x].finalizacao * 0.6;
                    jogador[x].nota += jogador[x].velocidade * 0.8;
                    jogador[x].nota += jogador[x].forca * 0.3;
                    jogador[x].nota += jogador[x].dominio * 1;
                    jogador[x].nota += jogador[x].folego * 0.5;
                    //jogador[x].nota = Math.Round((jogador[x].nota * 78) / 51);
                    x++;
                }
                else if (jogador[x].posicao == "Atacante")
                {
                    jogador[x].nota += jogador[x].desarme * 0.1;
                    jogador[x].nota += jogador[x].cobertura * 0.3;
                    jogador[x].nota += jogador[x].passe * 0.6;
                    jogador[x].nota += jogador[x].lancamento * 0.2;
                    jogador[x].nota += jogador[x].drible * 1;
                    jogador[x].nota += jogador[x].chute_longo * 0.7;
                    jogador[x].nota += jogador[x].finalizacao * 1;
                    jogador[x].nota += jogador[x].velocidade * 0.8;
                    jogador[x].nota += jogador[x].forca * 0.5;
                    jogador[x].nota += jogador[x].dominio * 0.9;
                    jogador[x].nota += jogador[x].folego * 0.7;
                    //jogador[x].nota = Math.Round((jogador[x].nota * 78) / 51);
                    x++;
                }
                else if (jogador[x].posicao == "Banheira")
                {
                    jogador[x].nota += jogador[x].desarme * 0;
                    jogador[x].nota += jogador[x].cobertura * 0;
                    jogador[x].nota += jogador[x].passe * 0.9;
                    jogador[x].nota += jogador[x].lancamento * 0.2;
                    jogador[x].nota += jogador[x].drible * 1;
                    jogador[x].nota += jogador[x].chute_longo * 0.2;
                    jogador[x].nota += jogador[x].finalizacao * 1;
                    jogador[x].nota += jogador[x].velocidade * 1;
                    jogador[x].nota += jogador[x].forca * 1;
                    jogador[x].nota += jogador[x].dominio * 1;
                    jogador[x].nota += jogador[x].folego * 0;
                    //jogador[x].nota = Math.Round((jogador[x].nota * 78) / 51);
                    x++;
                }
            }
        }

        private void normaliza()
        {
            int x = 0;
            double media = 0, desvio = 0;
            int qtd = lst_peladeiros.SelectedIndices.Count;
            while (x != qtd)
            {
                media += jogador[x].nota;
                x++;
            }

            media /= qtd;
            x = 0;

            while (x != qtd)
            {
                desvio += Math.Pow((jogador[x].nota - media), 2);
                x++;
            }
            desvio /= qtd;
            desvio = Math.Sqrt(desvio);
            x = 0;

            while (x != qtd)
            {

                jogador[x].nota = Math.Round(((((jogador[x].nota - media) / desvio) + 2) * 100));
                x++;
            }
            x = 0;

            while (x != qtd)
            {
                media += jogador[x].nota;
                x++;
            }
            x = 0;

            while (x != qtd)
            {
                jogador[x].nota = Math.Round((jogador[x].nota * 50) / media);
                if (jogador[x].nota == 0)
                    jogador[x].nota = 1;
                else if (jogador[x].nota > 10)
                    jogador[x].nota = 10;
                x++;
            }
        }

        private void sortear_jogadores()
        {
            int times_equilibrados = 0, i = 0, tentativas = 0;
            int[] num_utilizados = new int[lst_peladeiros.SelectedIndices.Count];
            int num_sorteado = 0, repetido = 0, qtd_jogadores;
            double peso_time1 = 0, peso_time2 = 0;
            Random num = new Random();
            double equilibrio = 0;
            double d_offset = 0.2;

            for (int y = 0; y < lst_peladeiros.SelectedIndices.Count; y++)
                num_utilizados[y] = 255;

            qtd_jogadores = lst_peladeiros.SelectedIndices.Count;
            
            if (Convert.ToDouble(num_diferenca_times.Value) > 0)
                d_offset = Convert.ToDouble(num_diferenca_times.Value);

            txt_time1.Clear();
            txt_time2.Clear();
            txt_cpy.Clear();

            while ((times_equilibrados == 0) && (tentativas < 50))
            {
                this.Text = "Sorteando TIME1";
                txt_cpy.Text += "Time 1 \r\n";
                for (i = 0; i <= ((qtd_jogadores-1) / 2); i++)
                {
                    repetido = 0;
                    num_sorteado = num.Next(0, qtd_jogadores);
                    for (int x = 0; x <= qtd_jogadores-1; x++)
                    {
                        if (num_utilizados[x] == num_sorteado)
                            repetido = 1;
                    }

                    if (repetido == 0)
                    {
                        num_utilizados[i] = num_sorteado;
                        txt_time1.Text += jogador[num_sorteado].nome.ToString() + " (" + jogador[num_sorteado].nota.ToString() + ")" + "\r\n";
                        txt_cpy.Text += jogador[num_sorteado].nome.ToString() + "\r\n";
                        peso_time1 += jogador[num_sorteado].nota;
                        this.Refresh();
                    }
                    else
                        i--;
                }

                this.Text = "Sorteando TIME2";
                txt_cpy.Text += "\r\nTime 2 \r\n";
                for (i = i; i < qtd_jogadores; i++)
                {
                    repetido = 0;
                    num_sorteado = num.Next(0, qtd_jogadores);
                    for (int x = 0; x <= qtd_jogadores-1; x++)
                    {
                        if (num_utilizados[x] == num_sorteado)
                            repetido = 1;
                    }

                    if (repetido == 0)
                    {
                        num_utilizados[i] = num_sorteado;
                        txt_time2.Text += jogador[num_sorteado].nome.ToString() + " (" + jogador[num_sorteado].nota.ToString() + ")" + "\r\n";
                        txt_cpy.Text += jogador[num_sorteado].nome.ToString() + "\r\n";
                        peso_time2 += jogador[num_sorteado].nota;
                        this.Refresh();
                    }
                    else
                        i--;
                }
                equilibrio = Convert.ToDouble(peso_time1 / peso_time2);
                if ((equilibrio > (1 - d_offset)) && (equilibrio < (1 + d_offset)))
                {
                    times_equilibrados = 1;
                    txt_peso_time1.Text = peso_time1.ToString();
                    txt_peso_time2.Text = peso_time2.ToString();
                    txt_diferenca.Text = equilibrio.ToString();
                    this.Text = "Concluido";
                }
                else
                {
                    this.Text = "Re-Sorteando";
                    tentativas++;
                    for (int a = 0; a < lst_peladeiros.SelectedIndices.Count; a++)
                        num_utilizados[a] = 255;
                    txt_time1.Clear();
                    txt_time2.Clear();
                    txt_cpy.Clear();
                    txt_peso_time1.Text = peso_time1.ToString();
                    txt_peso_time2.Text = peso_time2.ToString();
                    peso_time1 = 0;
                    peso_time2 = 0;
                    this.Refresh();
                }
                if (tentativas >= 50)
                    MessageBox.Show("Não foi possível encontrar equilibrio com offset de (" + d_offset.ToString() + ")");
            }
        }
    }
}
