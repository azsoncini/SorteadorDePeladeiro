namespace SorteadorDePeladeiro
{
    partial class Cadastro
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_posicao = new System.Windows.Forms.Label();
            this.cmb_posicao = new System.Windows.Forms.ComboBox();
            this.num_desarme = new System.Windows.Forms.NumericUpDown();
            this.lb_desarme = new System.Windows.Forms.Label();
            this.lb_cobertura = new System.Windows.Forms.Label();
            this.num_cobertura = new System.Windows.Forms.NumericUpDown();
            this.lb_lancamento = new System.Windows.Forms.Label();
            this.num_lancamento = new System.Windows.Forms.NumericUpDown();
            this.lb_passe = new System.Windows.Forms.Label();
            this.num_passe = new System.Windows.Forms.NumericUpDown();
            this.lb_fominha = new System.Windows.Forms.Label();
            this.num_fominha = new System.Windows.Forms.NumericUpDown();
            this.lb_drible = new System.Windows.Forms.Label();
            this.num_drible = new System.Windows.Forms.NumericUpDown();
            this.lb_finalizacao = new System.Windows.Forms.Label();
            this.num_finalizacao = new System.Windows.Forms.NumericUpDown();
            this.lb_chute_longo = new System.Windows.Forms.Label();
            this.num_chute_longo = new System.Windows.Forms.NumericUpDown();
            this.lb_forca = new System.Windows.Forms.Label();
            this.num_forca = new System.Windows.Forms.NumericUpDown();
            this.lb_velocidade = new System.Windows.Forms.Label();
            this.num_velocidade = new System.Windows.Forms.NumericUpDown();
            this.lb_folego = new System.Windows.Forms.Label();
            this.num_folego = new System.Windows.Forms.NumericUpDown();
            this.lb_dominio = new System.Windows.Forms.Label();
            this.num_dominio = new System.Windows.Forms.NumericUpDown();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_desarme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cobertura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lancamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_passe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fominha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_drible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_finalizacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_chute_longo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_forca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_velocidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_folego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dominio)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nome.Location = new System.Drawing.Point(12, 25);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(133, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(12, 9);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome";
            // 
            // lb_posicao
            // 
            this.lb_posicao.AutoSize = true;
            this.lb_posicao.Location = new System.Drawing.Point(12, 49);
            this.lb_posicao.Name = "lb_posicao";
            this.lb_posicao.Size = new System.Drawing.Size(45, 13);
            this.lb_posicao.TabIndex = 2;
            this.lb_posicao.Text = "Posição";
            // 
            // cmb_posicao
            // 
            this.cmb_posicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_posicao.FormattingEnabled = true;
            this.cmb_posicao.Items.AddRange(new object[] {
            "Zagueiro",
            "Volante",
            "Lateral",
            "Meio Campo",
            "Atacante",
            "Banheira"});
            this.cmb_posicao.Location = new System.Drawing.Point(12, 65);
            this.cmb_posicao.Name = "cmb_posicao";
            this.cmb_posicao.Size = new System.Drawing.Size(133, 21);
            this.cmb_posicao.TabIndex = 3;
            this.cmb_posicao.Text = "Zagueiro";
            this.cmb_posicao.Enter += new System.EventHandler(this.cmb_posicao_Enter);
            this.cmb_posicao.Leave += new System.EventHandler(this.cmb_posicao_Leave);
            // 
            // num_desarme
            // 
            this.num_desarme.Location = new System.Drawing.Point(12, 105);
            this.num_desarme.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_desarme.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_desarme.Name = "num_desarme";
            this.num_desarme.Size = new System.Drawing.Size(45, 20);
            this.num_desarme.TabIndex = 4;
            this.num_desarme.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_desarme
            // 
            this.lb_desarme.AutoSize = true;
            this.lb_desarme.Location = new System.Drawing.Point(10, 90);
            this.lb_desarme.Name = "lb_desarme";
            this.lb_desarme.Size = new System.Drawing.Size(49, 13);
            this.lb_desarme.TabIndex = 5;
            this.lb_desarme.Text = "Desarme";
            // 
            // lb_cobertura
            // 
            this.lb_cobertura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_cobertura.AutoSize = true;
            this.lb_cobertura.Location = new System.Drawing.Point(92, 90);
            this.lb_cobertura.Name = "lb_cobertura";
            this.lb_cobertura.Size = new System.Drawing.Size(53, 13);
            this.lb_cobertura.TabIndex = 7;
            this.lb_cobertura.Text = "Cobertura";
            this.lb_cobertura.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // num_cobertura
            // 
            this.num_cobertura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_cobertura.Location = new System.Drawing.Point(100, 105);
            this.num_cobertura.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_cobertura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_cobertura.Name = "num_cobertura";
            this.num_cobertura.Size = new System.Drawing.Size(45, 20);
            this.num_cobertura.TabIndex = 6;
            this.num_cobertura.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_lancamento
            // 
            this.lb_lancamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_lancamento.AutoSize = true;
            this.lb_lancamento.Location = new System.Drawing.Point(79, 130);
            this.lb_lancamento.Name = "lb_lancamento";
            this.lb_lancamento.Size = new System.Drawing.Size(66, 13);
            this.lb_lancamento.TabIndex = 11;
            this.lb_lancamento.Text = "Lançamento";
            this.lb_lancamento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // num_lancamento
            // 
            this.num_lancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_lancamento.Location = new System.Drawing.Point(100, 145);
            this.num_lancamento.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_lancamento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_lancamento.Name = "num_lancamento";
            this.num_lancamento.Size = new System.Drawing.Size(45, 20);
            this.num_lancamento.TabIndex = 10;
            this.num_lancamento.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_passe
            // 
            this.lb_passe.AutoSize = true;
            this.lb_passe.Location = new System.Drawing.Point(10, 130);
            this.lb_passe.Name = "lb_passe";
            this.lb_passe.Size = new System.Drawing.Size(36, 13);
            this.lb_passe.TabIndex = 9;
            this.lb_passe.Text = "Passe";
            // 
            // num_passe
            // 
            this.num_passe.Location = new System.Drawing.Point(12, 145);
            this.num_passe.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_passe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_passe.Name = "num_passe";
            this.num_passe.Size = new System.Drawing.Size(45, 20);
            this.num_passe.TabIndex = 8;
            this.num_passe.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_fominha
            // 
            this.lb_fominha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_fominha.AutoSize = true;
            this.lb_fominha.Location = new System.Drawing.Point(98, 170);
            this.lb_fominha.Name = "lb_fominha";
            this.lb_fominha.Size = new System.Drawing.Size(47, 13);
            this.lb_fominha.TabIndex = 15;
            this.lb_fominha.Text = "Fominha";
            this.lb_fominha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // num_fominha
            // 
            this.num_fominha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_fominha.Location = new System.Drawing.Point(100, 185);
            this.num_fominha.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_fominha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_fominha.Name = "num_fominha";
            this.num_fominha.Size = new System.Drawing.Size(45, 20);
            this.num_fominha.TabIndex = 14;
            this.num_fominha.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_drible
            // 
            this.lb_drible.AutoSize = true;
            this.lb_drible.Location = new System.Drawing.Point(10, 170);
            this.lb_drible.Name = "lb_drible";
            this.lb_drible.Size = new System.Drawing.Size(34, 13);
            this.lb_drible.TabIndex = 13;
            this.lb_drible.Text = "Drible";
            // 
            // num_drible
            // 
            this.num_drible.Location = new System.Drawing.Point(12, 185);
            this.num_drible.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_drible.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_drible.Name = "num_drible";
            this.num_drible.Size = new System.Drawing.Size(45, 20);
            this.num_drible.TabIndex = 12;
            this.num_drible.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_finalizacao
            // 
            this.lb_finalizacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_finalizacao.AutoSize = true;
            this.lb_finalizacao.Location = new System.Drawing.Point(85, 210);
            this.lb_finalizacao.Name = "lb_finalizacao";
            this.lb_finalizacao.Size = new System.Drawing.Size(60, 13);
            this.lb_finalizacao.TabIndex = 19;
            this.lb_finalizacao.Text = "Finalização";
            this.lb_finalizacao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // num_finalizacao
            // 
            this.num_finalizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_finalizacao.Location = new System.Drawing.Point(100, 225);
            this.num_finalizacao.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_finalizacao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_finalizacao.Name = "num_finalizacao";
            this.num_finalizacao.Size = new System.Drawing.Size(45, 20);
            this.num_finalizacao.TabIndex = 18;
            this.num_finalizacao.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_chute_longo
            // 
            this.lb_chute_longo.AutoSize = true;
            this.lb_chute_longo.Location = new System.Drawing.Point(10, 210);
            this.lb_chute_longo.Name = "lb_chute_longo";
            this.lb_chute_longo.Size = new System.Drawing.Size(68, 13);
            this.lb_chute_longo.TabIndex = 17;
            this.lb_chute_longo.Text = "Chute Longo";
            // 
            // num_chute_longo
            // 
            this.num_chute_longo.Location = new System.Drawing.Point(12, 225);
            this.num_chute_longo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_chute_longo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_chute_longo.Name = "num_chute_longo";
            this.num_chute_longo.Size = new System.Drawing.Size(45, 20);
            this.num_chute_longo.TabIndex = 16;
            this.num_chute_longo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_forca
            // 
            this.lb_forca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_forca.AutoSize = true;
            this.lb_forca.Location = new System.Drawing.Point(111, 250);
            this.lb_forca.Name = "lb_forca";
            this.lb_forca.Size = new System.Drawing.Size(34, 13);
            this.lb_forca.TabIndex = 23;
            this.lb_forca.Text = "Força";
            this.lb_forca.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // num_forca
            // 
            this.num_forca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_forca.Location = new System.Drawing.Point(100, 265);
            this.num_forca.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_forca.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_forca.Name = "num_forca";
            this.num_forca.Size = new System.Drawing.Size(45, 20);
            this.num_forca.TabIndex = 22;
            this.num_forca.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_velocidade
            // 
            this.lb_velocidade.AutoSize = true;
            this.lb_velocidade.Location = new System.Drawing.Point(10, 250);
            this.lb_velocidade.Name = "lb_velocidade";
            this.lb_velocidade.Size = new System.Drawing.Size(60, 13);
            this.lb_velocidade.TabIndex = 21;
            this.lb_velocidade.Text = "Velocidade";
            // 
            // num_velocidade
            // 
            this.num_velocidade.Location = new System.Drawing.Point(12, 265);
            this.num_velocidade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_velocidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_velocidade.Name = "num_velocidade";
            this.num_velocidade.Size = new System.Drawing.Size(45, 20);
            this.num_velocidade.TabIndex = 20;
            this.num_velocidade.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_folego
            // 
            this.lb_folego.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_folego.AutoSize = true;
            this.lb_folego.Location = new System.Drawing.Point(106, 290);
            this.lb_folego.Name = "lb_folego";
            this.lb_folego.Size = new System.Drawing.Size(39, 13);
            this.lb_folego.TabIndex = 27;
            this.lb_folego.Text = "Fôlego";
            this.lb_folego.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // num_folego
            // 
            this.num_folego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_folego.Location = new System.Drawing.Point(100, 305);
            this.num_folego.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_folego.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_folego.Name = "num_folego";
            this.num_folego.Size = new System.Drawing.Size(45, 20);
            this.num_folego.TabIndex = 26;
            this.num_folego.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_dominio
            // 
            this.lb_dominio.AutoSize = true;
            this.lb_dominio.Location = new System.Drawing.Point(10, 290);
            this.lb_dominio.Name = "lb_dominio";
            this.lb_dominio.Size = new System.Drawing.Size(47, 13);
            this.lb_dominio.TabIndex = 25;
            this.lb_dominio.Text = "Domínio";
            // 
            // num_dominio
            // 
            this.num_dominio.Location = new System.Drawing.Point(12, 305);
            this.num_dominio.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_dominio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_dominio.Name = "num_dominio";
            this.num_dominio.Size = new System.Drawing.Size(45, 20);
            this.num_dominio.TabIndex = 24;
            this.num_dominio.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 339);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(58, 36);
            this.btn_ok.TabIndex = 28;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(87, 339);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(58, 36);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 379);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lb_folego);
            this.Controls.Add(this.num_folego);
            this.Controls.Add(this.lb_dominio);
            this.Controls.Add(this.num_dominio);
            this.Controls.Add(this.lb_forca);
            this.Controls.Add(this.num_forca);
            this.Controls.Add(this.lb_velocidade);
            this.Controls.Add(this.num_velocidade);
            this.Controls.Add(this.lb_finalizacao);
            this.Controls.Add(this.num_finalizacao);
            this.Controls.Add(this.lb_chute_longo);
            this.Controls.Add(this.num_chute_longo);
            this.Controls.Add(this.lb_fominha);
            this.Controls.Add(this.num_fominha);
            this.Controls.Add(this.lb_drible);
            this.Controls.Add(this.num_drible);
            this.Controls.Add(this.lb_lancamento);
            this.Controls.Add(this.num_lancamento);
            this.Controls.Add(this.lb_passe);
            this.Controls.Add(this.num_passe);
            this.Controls.Add(this.lb_cobertura);
            this.Controls.Add(this.num_cobertura);
            this.Controls.Add(this.lb_desarme);
            this.Controls.Add(this.num_desarme);
            this.Controls.Add(this.cmb_posicao);
            this.Controls.Add(this.lb_posicao);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.txt_nome);
            this.Name = "Cadastro";
            this.Text = "Cadastro de Jogador";
            ((System.ComponentModel.ISupportInitialize)(this.num_desarme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cobertura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lancamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_passe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fominha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_drible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_finalizacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_chute_longo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_forca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_velocidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_folego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dominio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_posicao;
        private System.Windows.Forms.ComboBox cmb_posicao;
        private System.Windows.Forms.NumericUpDown num_desarme;
        private System.Windows.Forms.Label lb_desarme;
        private System.Windows.Forms.Label lb_cobertura;
        private System.Windows.Forms.NumericUpDown num_cobertura;
        private System.Windows.Forms.Label lb_lancamento;
        private System.Windows.Forms.NumericUpDown num_lancamento;
        private System.Windows.Forms.Label lb_passe;
        private System.Windows.Forms.NumericUpDown num_passe;
        private System.Windows.Forms.Label lb_fominha;
        private System.Windows.Forms.NumericUpDown num_fominha;
        private System.Windows.Forms.Label lb_drible;
        private System.Windows.Forms.NumericUpDown num_drible;
        private System.Windows.Forms.Label lb_finalizacao;
        private System.Windows.Forms.NumericUpDown num_finalizacao;
        private System.Windows.Forms.Label lb_chute_longo;
        private System.Windows.Forms.NumericUpDown num_chute_longo;
        private System.Windows.Forms.Label lb_forca;
        private System.Windows.Forms.NumericUpDown num_forca;
        private System.Windows.Forms.Label lb_velocidade;
        private System.Windows.Forms.NumericUpDown num_velocidade;
        private System.Windows.Forms.Label lb_folego;
        private System.Windows.Forms.NumericUpDown num_folego;
        private System.Windows.Forms.Label lb_dominio;
        private System.Windows.Forms.NumericUpDown num_dominio;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}