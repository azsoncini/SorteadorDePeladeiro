namespace SorteadorDePeladeiro
{
    partial class Main_Form
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
			this.lst_peladeiros = new System.Windows.Forms.ListView();
			this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_posicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_desarme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_cobertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_passe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_lancamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_drible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_fominha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_chute_longo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_finalizacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_velocidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_forca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_dominio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_folego = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_adicionar = new System.Windows.Forms.Button();
			this.btn_editar = new System.Windows.Forms.Button();
			this.btn_deletar = new System.Windows.Forms.Button();
			this.txt_time1 = new System.Windows.Forms.TextBox();
			this.txt_time2 = new System.Windows.Forms.TextBox();
			this.lb_time1 = new System.Windows.Forms.Label();
			this.lb_time2 = new System.Windows.Forms.Label();
			this.txt_qtd_jogadores = new System.Windows.Forms.TextBox();
			this.lb_qtd_jogadores = new System.Windows.Forms.Label();
			this.btn_sortear = new System.Windows.Forms.Button();
			this.lb_diferenca_times = new System.Windows.Forms.Label();
			this.num_diferenca_times = new System.Windows.Forms.NumericUpDown();
			this.lb_peso_time1 = new System.Windows.Forms.Label();
			this.txt_peso_time1 = new System.Windows.Forms.TextBox();
			this.lb_peso_time2 = new System.Windows.Forms.Label();
			this.txt_peso_time2 = new System.Windows.Forms.TextBox();
			this.lb_diferenca = new System.Windows.Forms.Label();
			this.txt_diferenca = new System.Windows.Forms.TextBox();
			this.txt_cpy = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.num_diferenca_times)).BeginInit();
			this.SuspendLayout();
			// 
			// lst_peladeiros
			// 
			this.lst_peladeiros.AllowColumnReorder = true;
			this.lst_peladeiros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lst_peladeiros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_nome,
            this.col_posicao,
            this.col_desarme,
            this.col_cobertura,
            this.col_passe,
            this.col_lancamento,
            this.col_drible,
            this.col_fominha,
            this.col_chute_longo,
            this.col_finalizacao,
            this.col_velocidade,
            this.col_forca,
            this.col_dominio,
            this.col_folego});
			this.lst_peladeiros.FullRowSelect = true;
			this.lst_peladeiros.GridLines = true;
			this.lst_peladeiros.HideSelection = false;
			this.lst_peladeiros.Location = new System.Drawing.Point(12, 50);
			this.lst_peladeiros.Name = "lst_peladeiros";
			this.lst_peladeiros.Size = new System.Drawing.Size(756, 473);
			this.lst_peladeiros.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lst_peladeiros.TabIndex = 0;
			this.lst_peladeiros.UseCompatibleStateImageBehavior = false;
			this.lst_peladeiros.View = System.Windows.Forms.View.Details;
			this.lst_peladeiros.SelectedIndexChanged += new System.EventHandler(this.lst_peladeiros_SelectedIndexChanged);
			// 
			// col_nome
			// 
			this.col_nome.Text = "Nome";
			// 
			// col_posicao
			// 
			this.col_posicao.Text = "Posição";
			// 
			// col_desarme
			// 
			this.col_desarme.Text = "Desarme";
			this.col_desarme.Width = 54;
			// 
			// col_cobertura
			// 
			this.col_cobertura.Text = "Cobertura";
			// 
			// col_passe
			// 
			this.col_passe.Text = "Passe";
			this.col_passe.Width = 43;
			// 
			// col_lancamento
			// 
			this.col_lancamento.Text = "Lançam.";
			this.col_lancamento.Width = 56;
			// 
			// col_drible
			// 
			this.col_drible.Text = "Drible";
			this.col_drible.Width = 39;
			// 
			// col_fominha
			// 
			this.col_fominha.Text = "Fominha";
			this.col_fominha.Width = 55;
			// 
			// col_chute_longo
			// 
			this.col_chute_longo.Text = "Chute L.";
			// 
			// col_finalizacao
			// 
			this.col_finalizacao.Text = "Finaliz.";
			this.col_finalizacao.Width = 46;
			// 
			// col_velocidade
			// 
			this.col_velocidade.Text = "Veloc.";
			this.col_velocidade.Width = 49;
			// 
			// col_forca
			// 
			this.col_forca.Text = "Força";
			this.col_forca.Width = 45;
			// 
			// col_dominio
			// 
			this.col_dominio.Text = "Domínio";
			this.col_dominio.Width = 52;
			// 
			// col_folego
			// 
			this.col_folego.Text = "Fôlego";
			this.col_folego.Width = 51;
			// 
			// btn_adicionar
			// 
			this.btn_adicionar.Location = new System.Drawing.Point(12, 12);
			this.btn_adicionar.Name = "btn_adicionar";
			this.btn_adicionar.Size = new System.Drawing.Size(82, 32);
			this.btn_adicionar.TabIndex = 1;
			this.btn_adicionar.Text = "Adicionar";
			this.btn_adicionar.UseVisualStyleBackColor = true;
			this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
			// 
			// btn_editar
			// 
			this.btn_editar.Location = new System.Drawing.Point(100, 12);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(82, 32);
			this.btn_editar.TabIndex = 2;
			this.btn_editar.Text = "Editar";
			this.btn_editar.UseVisualStyleBackColor = true;
			this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
			// 
			// btn_deletar
			// 
			this.btn_deletar.Location = new System.Drawing.Point(188, 12);
			this.btn_deletar.Name = "btn_deletar";
			this.btn_deletar.Size = new System.Drawing.Size(82, 32);
			this.btn_deletar.TabIndex = 3;
			this.btn_deletar.Text = "Deletar";
			this.btn_deletar.UseVisualStyleBackColor = true;
			this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
			// 
			// txt_time1
			// 
			this.txt_time1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_time1.Location = new System.Drawing.Point(12, 546);
			this.txt_time1.Multiline = true;
			this.txt_time1.Name = "txt_time1";
			this.txt_time1.Size = new System.Drawing.Size(198, 115);
			this.txt_time1.TabIndex = 4;
			// 
			// txt_time2
			// 
			this.txt_time2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_time2.Location = new System.Drawing.Point(228, 546);
			this.txt_time2.Multiline = true;
			this.txt_time2.Name = "txt_time2";
			this.txt_time2.Size = new System.Drawing.Size(198, 115);
			this.txt_time2.TabIndex = 5;
			// 
			// lb_time1
			// 
			this.lb_time1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_time1.AutoSize = true;
			this.lb_time1.Location = new System.Drawing.Point(9, 526);
			this.lb_time1.Name = "lb_time1";
			this.lb_time1.Size = new System.Drawing.Size(39, 13);
			this.lb_time1.TabIndex = 6;
			this.lb_time1.Text = "Time 1";
			// 
			// lb_time2
			// 
			this.lb_time2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_time2.AutoSize = true;
			this.lb_time2.Location = new System.Drawing.Point(231, 526);
			this.lb_time2.Name = "lb_time2";
			this.lb_time2.Size = new System.Drawing.Size(39, 13);
			this.lb_time2.TabIndex = 7;
			this.lb_time2.Text = "Time 2";
			// 
			// txt_qtd_jogadores
			// 
			this.txt_qtd_jogadores.Location = new System.Drawing.Point(423, 19);
			this.txt_qtd_jogadores.Name = "txt_qtd_jogadores";
			this.txt_qtd_jogadores.Size = new System.Drawing.Size(88, 20);
			this.txt_qtd_jogadores.TabIndex = 8;
			// 
			// lb_qtd_jogadores
			// 
			this.lb_qtd_jogadores.AutoSize = true;
			this.lb_qtd_jogadores.Location = new System.Drawing.Point(346, 14);
			this.lb_qtd_jogadores.Name = "lb_qtd_jogadores";
			this.lb_qtd_jogadores.Size = new System.Drawing.Size(71, 26);
			this.lb_qtd_jogadores.TabIndex = 9;
			this.lb_qtd_jogadores.Text = "Jogadores \r\nSelecionados";
			this.lb_qtd_jogadores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btn_sortear
			// 
			this.btn_sortear.Location = new System.Drawing.Point(517, 12);
			this.btn_sortear.Name = "btn_sortear";
			this.btn_sortear.Size = new System.Drawing.Size(82, 32);
			this.btn_sortear.TabIndex = 10;
			this.btn_sortear.Text = "Sortear";
			this.btn_sortear.UseVisualStyleBackColor = true;
			this.btn_sortear.Click += new System.EventHandler(this.btn_sortear_Click);
			// 
			// lb_diferenca_times
			// 
			this.lb_diferenca_times.AutoSize = true;
			this.lb_diferenca_times.Location = new System.Drawing.Point(605, 22);
			this.lb_diferenca_times.Name = "lb_diferenca_times";
			this.lb_diferenca_times.Size = new System.Drawing.Size(112, 13);
			this.lb_diferenca_times.TabIndex = 11;
			this.lb_diferenca_times.Text = "Diferença Entre Times";
			this.lb_diferenca_times.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// num_diferenca_times
			// 
			this.num_diferenca_times.DecimalPlaces = 2;
			this.num_diferenca_times.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.num_diferenca_times.Location = new System.Drawing.Point(723, 20);
			this.num_diferenca_times.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.num_diferenca_times.Name = "num_diferenca_times";
			this.num_diferenca_times.Size = new System.Drawing.Size(45, 20);
			this.num_diferenca_times.TabIndex = 12;
			this.num_diferenca_times.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			// 
			// lb_peso_time1
			// 
			this.lb_peso_time1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_peso_time1.AutoSize = true;
			this.lb_peso_time1.Location = new System.Drawing.Point(444, 546);
			this.lb_peso_time1.Name = "lb_peso_time1";
			this.lb_peso_time1.Size = new System.Drawing.Size(63, 13);
			this.lb_peso_time1.TabIndex = 14;
			this.lb_peso_time1.Text = "Peso Time1";
			this.lb_peso_time1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_peso_time1
			// 
			this.txt_peso_time1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_peso_time1.Location = new System.Drawing.Point(432, 562);
			this.txt_peso_time1.Name = "txt_peso_time1";
			this.txt_peso_time1.Size = new System.Drawing.Size(88, 20);
			this.txt_peso_time1.TabIndex = 13;
			// 
			// lb_peso_time2
			// 
			this.lb_peso_time2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_peso_time2.AutoSize = true;
			this.lb_peso_time2.Location = new System.Drawing.Point(444, 585);
			this.lb_peso_time2.Name = "lb_peso_time2";
			this.lb_peso_time2.Size = new System.Drawing.Size(63, 13);
			this.lb_peso_time2.TabIndex = 16;
			this.lb_peso_time2.Text = "Peso Time2";
			this.lb_peso_time2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_peso_time2
			// 
			this.txt_peso_time2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_peso_time2.Location = new System.Drawing.Point(432, 601);
			this.txt_peso_time2.Name = "txt_peso_time2";
			this.txt_peso_time2.Size = new System.Drawing.Size(88, 20);
			this.txt_peso_time2.TabIndex = 15;
			// 
			// lb_diferenca
			// 
			this.lb_diferenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_diferenca.AutoSize = true;
			this.lb_diferenca.Location = new System.Drawing.Point(444, 625);
			this.lb_diferenca.Name = "lb_diferenca";
			this.lb_diferenca.Size = new System.Drawing.Size(53, 13);
			this.lb_diferenca.TabIndex = 18;
			this.lb_diferenca.Text = "Diferença";
			this.lb_diferenca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_diferenca
			// 
			this.txt_diferenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_diferenca.Location = new System.Drawing.Point(432, 641);
			this.txt_diferenca.Name = "txt_diferenca";
			this.txt_diferenca.Size = new System.Drawing.Size(88, 20);
			this.txt_diferenca.TabIndex = 17;
			// 
			// txt_cpy
			// 
			this.txt_cpy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_cpy.Location = new System.Drawing.Point(526, 543);
			this.txt_cpy.Multiline = true;
			this.txt_cpy.Name = "txt_cpy";
			this.txt_cpy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_cpy.Size = new System.Drawing.Size(242, 115);
			this.txt_cpy.TabIndex = 19;
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 673);
			this.Controls.Add(this.txt_cpy);
			this.Controls.Add(this.lb_diferenca);
			this.Controls.Add(this.txt_diferenca);
			this.Controls.Add(this.lb_peso_time2);
			this.Controls.Add(this.txt_peso_time2);
			this.Controls.Add(this.lb_peso_time1);
			this.Controls.Add(this.txt_peso_time1);
			this.Controls.Add(this.num_diferenca_times);
			this.Controls.Add(this.lb_diferenca_times);
			this.Controls.Add(this.btn_sortear);
			this.Controls.Add(this.lb_qtd_jogadores);
			this.Controls.Add(this.txt_qtd_jogadores);
			this.Controls.Add(this.lb_time2);
			this.Controls.Add(this.lb_time1);
			this.Controls.Add(this.txt_time2);
			this.Controls.Add(this.txt_time1);
			this.Controls.Add(this.btn_deletar);
			this.Controls.Add(this.btn_editar);
			this.Controls.Add(this.btn_adicionar);
			this.Controls.Add(this.lst_peladeiros);
			this.Name = "Main_Form";
			this.Text = "Sorteador de Peladeiro";
			((System.ComponentModel.ISupportInitialize)(this.num_diferenca_times)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_peladeiros;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_posicao;
        private System.Windows.Forms.ColumnHeader col_desarme;
        private System.Windows.Forms.ColumnHeader col_cobertura;
        private System.Windows.Forms.ColumnHeader col_passe;
        private System.Windows.Forms.ColumnHeader col_lancamento;
        private System.Windows.Forms.ColumnHeader col_drible;
        private System.Windows.Forms.ColumnHeader col_fominha;
        private System.Windows.Forms.ColumnHeader col_chute_longo;
        private System.Windows.Forms.ColumnHeader col_finalizacao;
        private System.Windows.Forms.ColumnHeader col_velocidade;
        private System.Windows.Forms.ColumnHeader col_forca;
        private System.Windows.Forms.ColumnHeader col_dominio;
        private System.Windows.Forms.ColumnHeader col_folego;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.TextBox txt_time1;
        private System.Windows.Forms.TextBox txt_time2;
        private System.Windows.Forms.Label lb_time1;
        private System.Windows.Forms.Label lb_time2;
        private System.Windows.Forms.TextBox txt_qtd_jogadores;
        private System.Windows.Forms.Label lb_qtd_jogadores;
        private System.Windows.Forms.Button btn_sortear;
        private System.Windows.Forms.Label lb_diferenca_times;
        private System.Windows.Forms.NumericUpDown num_diferenca_times;
        private System.Windows.Forms.Label lb_peso_time1;
        private System.Windows.Forms.TextBox txt_peso_time1;
        private System.Windows.Forms.Label lb_peso_time2;
        private System.Windows.Forms.TextBox txt_peso_time2;
        private System.Windows.Forms.Label lb_diferenca;
        private System.Windows.Forms.TextBox txt_diferenca;
        private System.Windows.Forms.TextBox txt_cpy;
    }
}

