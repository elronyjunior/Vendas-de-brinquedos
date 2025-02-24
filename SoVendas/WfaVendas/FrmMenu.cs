using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmClientes)
                {
                    item.Focus();
                    return;
                }

            }
            FrmClientes FrmClientes = new FrmClientes();
            FrmClientes.MdiParent = this;
            FrmClientes.Show();
            
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            cadastroDeClientesToolStripMenuItem_Click(null, null) ;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sslHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }
        }

        private void cadastroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmVendas)
                {
                    item.Focus();
                    return;
                }

            }
            FrmVendas FrmClientes = new FrmVendas();
            FrmClientes.MdiParent = this;
            FrmClientes.Show();


        }

        private void relatóriosDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           foreach (Form item in MdiChildren)
            {
                if (item is FrmRptProdutos)
                {
                    item.Focus();
                    return;
                }

            }
            FrmRptProdutos FrmRptProdutos = new FrmRptProdutos();
            FrmRptProdutos.MdiParent = this;
            FrmRptProdutos.Show();
           
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmProduto)
                {
                    item.Focus();
                    return;
                }

            }
            FrmProduto FrmProduto = new FrmProduto();
            FrmProduto.MdiParent = this;
            FrmProduto.Show();
        }

        private void cadastroDoSeuTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmBrinquedo)
                {
                    item.Focus();
                    return;
                }

            }
            FrmBrinquedo FrmBrinquedo = new FrmBrinquedo();
            FrmBrinquedo.MdiParent = this;
            FrmBrinquedo.Show();

        }

        private void relatóriosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRptCliente)
                {
                    item.Focus();
                    return;
                }

            }
            FrmRptCliente FrmRptCliente = new FrmRptCliente();
            FrmRptCliente.MdiParent = this;
            FrmRptCliente.Show();
        }

        private void relatóriosDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRptVendas)
                {
                    item.Focus();
                    return;
                }

            }
            FrmRptVendas FrmRptVendas = new FrmRptVendas();
            FrmRptVendas.MdiParent = this;
            FrmRptVendas.Show();
        }

        private void relatóriosDeSeuTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRptBrinquedo)
                {
                    item.Focus();
                    return;
                }

            }
            FrmRptBrinquedo FrmRptBrinquedo = new FrmRptBrinquedo();
            FrmRptBrinquedo.MdiParent = this;
            FrmRptBrinquedo.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmVendas)
                {
                    item.Focus();
                    return;
                }

            }
            FrmVendas FrmClientes = new FrmVendas();
            FrmClientes.MdiParent = this;
            FrmClientes.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmProduto)
                {
                    item.Focus();
                    return;
                }

            }
            FrmProduto FrmProduto = new FrmProduto();
            FrmProduto.MdiParent = this;
            FrmProduto.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmBrinquedo)
                {
                    item.Focus();
                    return;
                }

            }
            FrmBrinquedo FrmBrinquedo = new FrmBrinquedo();
            FrmBrinquedo.MdiParent = this;
            FrmBrinquedo.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRptCliente)
                {
                    item.Focus();
                    return;
                }

            }
            FrmRptCliente FrmRptCliente = new FrmRptCliente();
            FrmRptCliente.MdiParent = this;
            FrmRptCliente.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRptVendas)
                {
                    item.Focus();
                    return;
                }

            }
            FrmRptVendas FrmRptVendas = new FrmRptVendas();
            FrmRptVendas.MdiParent = this;
            FrmRptVendas.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRptProdutos)
                {
                    item.Focus();
                    return;
                }

            }
            FrmRptProdutos FrmRptProdutos = new FrmRptProdutos();
            FrmRptProdutos.MdiParent = this;
            FrmRptProdutos.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRptBrinquedo)
                {
                    item.Focus();
                    return;
                }

            }
            FrmRptBrinquedo FrmRptBrinquedo = new FrmRptBrinquedo();
            FrmRptBrinquedo.MdiParent = this;
            FrmRptBrinquedo.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
       

       

        private void O(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }
    }
    }

