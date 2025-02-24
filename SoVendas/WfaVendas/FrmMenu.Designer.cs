
namespace WfaVendas
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroDoSeuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosDeSeuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoAladoNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsFerramentas = new System.Windows.Forms.ToolStrip();
            this.btnCadClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mnsMenu.SuspendLayout();
            this.tlsFerramentas.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(800, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeVendasToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.toolStripSeparator3,
            this.cadastroDoSeuTemaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.pasta;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.do_utilizador;
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de &Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // cadastroDeVendasToolStripMenuItem
            // 
            this.cadastroDeVendasToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.crescimento;
            this.cadastroDeVendasToolStripMenuItem.Name = "cadastroDeVendasToolStripMenuItem";
            this.cadastroDeVendasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeVendasToolStripMenuItem.Text = "Cadastro de &Vendas";
            this.cadastroDeVendasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeVendasToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.adicionar_produto;
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de &Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // cadastroDoSeuTemaToolStripMenuItem
            // 
            this.cadastroDoSeuTemaToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.pipa;
            this.cadastroDoSeuTemaToolStripMenuItem.Name = "cadastroDoSeuTemaToolStripMenuItem";
            this.cadastroDoSeuTemaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDoSeuTemaToolStripMenuItem.Text = "Cadastro Brinquedos";
            this.cadastroDoSeuTemaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDoSeuTemaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosDeClientesToolStripMenuItem,
            this.relatóriosDeVendasToolStripMenuItem,
            this.relatóriosDeProdutosToolStripMenuItem,
            this.relatóriosDeSeuTemaToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatoriosToolStripMenuItem.Image")));
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatoriosToolStripMenuItem.Text = "&Relatórios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // relatóriosDeClientesToolStripMenuItem
            // 
            this.relatóriosDeClientesToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.do_utilizador;
            this.relatóriosDeClientesToolStripMenuItem.Name = "relatóriosDeClientesToolStripMenuItem";
            this.relatóriosDeClientesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.relatóriosDeClientesToolStripMenuItem.Text = "Relatórios de &Clientes";
            this.relatóriosDeClientesToolStripMenuItem.Click += new System.EventHandler(this.relatóriosDeClientesToolStripMenuItem_Click);
            // 
            // relatóriosDeVendasToolStripMenuItem
            // 
            this.relatóriosDeVendasToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.crescimento;
            this.relatóriosDeVendasToolStripMenuItem.Name = "relatóriosDeVendasToolStripMenuItem";
            this.relatóriosDeVendasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.relatóriosDeVendasToolStripMenuItem.Text = "Relatórios de &Vendas";
            this.relatóriosDeVendasToolStripMenuItem.Click += new System.EventHandler(this.relatóriosDeVendasToolStripMenuItem_Click);
            // 
            // relatóriosDeProdutosToolStripMenuItem
            // 
            this.relatóriosDeProdutosToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.adicionar_produto;
            this.relatóriosDeProdutosToolStripMenuItem.Name = "relatóriosDeProdutosToolStripMenuItem";
            this.relatóriosDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.relatóriosDeProdutosToolStripMenuItem.Text = "Relatórios de &Produtos";
            this.relatóriosDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosDeProdutosToolStripMenuItem_Click);
            // 
            // relatóriosDeSeuTemaToolStripMenuItem
            // 
            this.relatóriosDeSeuTemaToolStripMenuItem.Image = global::WfaVendas.Properties.Resources.pipa;
            this.relatóriosDeSeuTemaToolStripMenuItem.Name = "relatóriosDeSeuTemaToolStripMenuItem";
            this.relatóriosDeSeuTemaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.relatóriosDeSeuTemaToolStripMenuItem.Text = "Relatório Brinquedo";
            this.relatóriosDeSeuTemaToolStripMenuItem.Click += new System.EventHandler(this.relatóriosDeSeuTemaToolStripMenuItem_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladoALadoNaVerticalToolStripMenuItem,
            this.ladoAladoNaHorizontalToolStripMenuItem,
            this.cascataToolStripMenuItem});
            this.janelasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("janelasToolStripMenuItem.Image")));
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.janelasToolStripMenuItem.Text = "&Janelas";
            // 
            // ladoALadoNaVerticalToolStripMenuItem
            // 
            this.ladoALadoNaVerticalToolStripMenuItem.Name = "ladoALadoNaVerticalToolStripMenuItem";
            this.ladoALadoNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ladoALadoNaVerticalToolStripMenuItem.Text = "Lado a lado na &Vertical";
            this.ladoALadoNaVerticalToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // ladoAladoNaHorizontalToolStripMenuItem
            // 
            this.ladoAladoNaHorizontalToolStripMenuItem.Name = "ladoAladoNaHorizontalToolStripMenuItem";
            this.ladoAladoNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ladoAladoNaHorizontalToolStripMenuItem.Text = "Lado alado na &Horizontal";
            this.ladoAladoNaHorizontalToolStripMenuItem.Click += new System.EventHandler(this.O);
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cascataToolStripMenuItem.Text = "&Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem.Image")));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem1.Image")));
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem1.Text = "&Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // tlsFerramentas
            // 
            this.tlsFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadClientes,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripButton5});
            this.tlsFerramentas.Location = new System.Drawing.Point(0, 24);
            this.tlsFerramentas.Name = "tlsFerramentas";
            this.tlsFerramentas.Size = new System.Drawing.Size(800, 35);
            this.tlsFerramentas.TabIndex = 1;
            this.tlsFerramentas.Text = "toolStrip1";
            // 
            // btnCadClientes
            // 
            this.btnCadClientes.AutoSize = false;
            this.btnCadClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadClientes.Image")));
            this.btnCadClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadClientes.Name = "btnCadClientes";
            this.btnCadClientes.Size = new System.Drawing.Size(32, 32);
            this.btnCadClientes.Text = "Cadastro de Clientes";
            this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WfaVendas.Properties.Resources.crescimento;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton2.Text = "Cadastro de Vendas";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WfaVendas.Properties.Resources.adicionar_produto;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton3.Text = "Cadastro de Produtos";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::WfaVendas.Properties.Resources.pipa;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton4.Text = "Cadastro de Brinquedos";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripDropDownButton1.Text = "Relatorios";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::WfaVendas.Properties.Resources.do_utilizador;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem1.Text = "Relatorio de Clientes";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::WfaVendas.Properties.Resources.crescimento;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem2.Text = "Relatorio de Vendas";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::WfaVendas.Properties.Resources.adicionar_produto;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem3.Text = "Relatorio de Produtos";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::WfaVendas.Properties.Resources.pipa;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem4.Text = "Relatorio de Brinquedos";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton5.Text = "Sair";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTexto,
            this.sslHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // sslTexto
            // 
            this.sslTexto.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslTexto.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sslTexto.Name = "sslTexto";
            this.sslTexto.Size = new System.Drawing.Size(605, 17);
            this.sslTexto.Spring = true;
            this.sslTexto.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // sslHora
            // 
            this.sslHora.AutoSize = false;
            this.sslHora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslHora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sslHora.Name = "sslHora";
            this.sslHora.Size = new System.Drawing.Size(180, 17);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tlsFerramentas);
            this.Controls.Add(this.mnsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.tlsFerramentas.ResumeLayout(false);
            this.tlsFerramentas.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlsFerramentas;
        private System.Windows.Forms.ToolStripButton btnCadClientes;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cadastroDoSeuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel sslTexto;
        private System.Windows.Forms.ToolStripStatusLabel sslHora;
        private System.Windows.Forms.ToolStripMenuItem relatóriosDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosDeSeuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoAladoNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}