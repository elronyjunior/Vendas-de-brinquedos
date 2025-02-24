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
    public partial class FrmProduto : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void pc_produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter.Fill(this.lP2DataSet.pc_produto);

        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            incluir = true;
            txtDescricao.Focus();
        }
        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }
        private void habilitaCampos(bool hab)
        {
            txtDescricao.Enabled = hab;
            NudQuantidade.Enabled = hab;
            txtPrecoUnit.Enabled = hab;
        }
        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            NudQuantidade.Value = 0;
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {
                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                
                txtCodpro.Text = dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString();
                txtDescricao.Text = dgvProduto[1, dgvProduto.CurrentRow.Index].Value.ToString();
                NudQuantidade.Value = Convert.ToInt32(dgvProduto[2,dgvProduto.CurrentRow.Index].Value.ToString());
                txtPrecoUnit.Text = dgvProduto[3, dgvProduto.CurrentRow.Index].Value.ToString();
                txtDescricao.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um Produto primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_produtoTableAdapter.Insert(txtDescricao.Text, int.Parse(NudQuantidade.Text), double.Parse(txtPrecoUnit.Text));
                    MessageBox.Show("Incluído com sucesso!", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pc_produtoTableAdapter.Update(txtDescricao.Text, int.Parse(NudQuantidade.Text), double.Parse(txtPrecoUnit.Text),int.Parse(txtCodpro.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmProduto_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduto.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_produtoTableAdapter.Delete(Convert.ToInt32(dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString()));
                        FrmProduto_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um Produto primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Restante do código...
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Enabled == false)
            {
                habilitaCampos(false);
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome do cliente desejado ou" + "\nparte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                pc_produtoTableAdapter.FillByDescricao(this.lP2DataSet.pc_produto,
                    "%" + txtDescricao.Text + "%");
                btnCancelar_Click(null, null);
            }

        }
    }
}
