using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfaVendas.LP2DataSetTableAdapters;

namespace WfaVendas
{
    public partial class FrmVendas : Form
    {

        bool incluir = false;
        bool editar = false;
        bool editarItem = false;
        bool incluirItem = false;
        double precoTemp = 0;

        public FrmVendas()
        {
            InitializeComponent();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_clientesTableAdapter.Fill(this.lP2DataSet.pc_clientes);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter.Fill(this.lP2DataSet.pc_produto);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_itemvenda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_itemvendaTableAdapter.Fill(this.lP2DataSet.pc_itemvenda);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_vendaTableAdapter.Fill(this.lP2DataSet.pc_venda);
            // TODO: esta linha de código carrega dados na tabela 'vendaDataSet.pc_venda'. Você pode movê-la ou removê-la conforme necessário.


        }

        private void habilitaCampos(bool hab)
        {
            txtNumVenda.Enabled = hab;
            cmbCliente.Enabled = hab;
            dtpDataVenda.Enabled = hab;
            dtpDataEntrega.Enabled = hab;
            txtObs.Enabled = hab;
        }
        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }

        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }

        private void habilitaBotoesItem(bool hab)
        {
            btnIncluirItem.Enabled = hab;
            btnExcluirItem.Enabled = hab;
            btnAlterarItem.Enabled = hab;
            btnPesquisarItem.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravarItem.Enabled = !hab;
            btnCancelarItem.Enabled = !hab;
        }

        private void limpaCampos(Control local)
        {
            foreach (Control item in local.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    if (((TextBox)item).Name == "txtPrecoUnit"
                        || ((TextBox)item).Name == "txtSubTotal"
                        || ((TextBox)item).Name == "txtTotal")
                    {
                        ((TextBox)item).Text = "R$ 0,00";
                    }
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluir = true;
            habilitaBotoes(false);
            habilitaCampos(true);
            txtNumVenda.Enabled = false;

        }
        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.RowCount > 0)
                {
                    this.pc_itemvendaTableAdapter.FillByNumvenda(this.lP2DataSet.pc_itemvenda, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));

                    if (dgvItens.RowCount > 0)
                    {
                        double total = (Double)pc_itemvendaTableAdapter.TotalVenda(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        txtTotal.Text = total.ToString("R$ #,###,##0.00");
                    }
                }
                else
                {
                    txtTotal.Text = "R$ 0,00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro ao acessar os Items da VENDA:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {

                    
                    pc_vendaTableAdapter.Insert(dtpDataVenda.Value, dtpDataEntrega.Value, txtObs.Text, (Int32)(cmbCliente.SelectedValue)
                      );
                    MessageBox.Show(null, "Incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vendas_Load(null, null);


                }
                if (editar)
                {
                    
                    pc_vendaTableAdapter.Update(dtpDataVenda.Value,
                    dtpDataEntrega.Value, txtObs.Text, (Int32)cmbCliente.SelectedValue, Convert.ToInt32(txtNumVenda.Text));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vendas_Load(null, null);

                }
                Vendas_Load(null, null);
                btnCancelar_Click(null, null);
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir a VENDA selecionada?"
                        , "atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemvendaTableAdapter.DeleteTodos(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        pc_vendaTableAdapter.Delete(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        Vendas_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(null, "Selecione uma venda primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(this); // TODO mostrar
            limpaCampos(grpItem);
            habilitaCampos(false);
            habilitaBotoes(true);
            editar = false;
            incluir = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.SelectedRows.Count > 0)
            {
                editar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtNumVenda.Enabled = false;
                txtNumVenda.Text = dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.Text = dgvVendas[2, dgvVendas.CurrentRow.Index].Value.ToString();
                dtpDataVenda.Value = Convert.ToDateTime(dgvVendas[3, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataEntrega.Value = Convert.ToDateTime(dgvVendas[4, dgvVendas.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvVendas[5, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione uma VENDA primeiro!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.Enabled == false)
            {
                cmbCliente.Enabled = true;
                cmbCliente.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome do cliente desejado ou" + "\nparte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                pc_vendaTableAdapter.FillByNome(this.lP2DataSet.pc_venda,
                    "%" + cmbCliente.Text + "%");
                btnCancelar_Click(null, null);
            }

        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            incluirItem = true;
            habilitaCamposItem(true);
            habilitaBotoesItem(false);
            cmbProduto_SelectedIndexChanged(null, null);
            cmbProduto.Focus();
            
        }
        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable produto = pc_produtoTableAdapter.GetDataBy(cmbProduto.Text);
                precoTemp = 0; // Zerar precoTemp para garantir o cálculo

                foreach (DataRow row in produto.Rows) // Loop "nas linhas".
                {
                    precoTemp = Convert.ToDouble(row["precounit"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            nudQuantidade.Value = 1;
            txtPrecoUnit.Text = precoTemp.ToString("R$ #,###,##0.00");
            txtSubTotal.Text = precoTemp.ToString("R$ #,###,##0.00");
        }


        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subTotal = (Int32)nudQuantidade.Value * precoTemp;
            txtSubTotal.Text = subTotal.ToString("R$ #,###,##0.00");
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItens.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o ITEM selecionado?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemvendaTableAdapter.Delete(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                            Convert.ToInt32(dgvItens[1, dgvItens.CurrentRow.Index].Value.ToString())
                        );
       
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvVendas_SelectionChanged(null, null);
                    }

                    else
                    {
                        MessageBox.Show(null, "Selecione um item primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count > 0)
            {
                editarItem = true;
                habilitaBotoesItem(false);
                habilitaCamposItem(true);
                cmbProduto.Text = dgvItens[4, dgvItens.CurrentRow.Index].Value.ToString(); // evitar erro de valor igual no cmbProduto
                cmbProduto_SelectedIndexChanged(null, null);
                nudQuantidade.Value = Convert.ToInt32(dgvItens[2, dgvItens.CurrentRow.Index].Value.ToString());
                cmbProduto.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um ITEM primeiro!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItens.RowCount > 0)
                {
                    // Alterar 'cmbCliente' ou 'cmbCodCli' p/ cmbProduto ou cmbCodPro
                    if (cmbProduto.Enabled == false)
                    {
                        cmbProduto.Enabled = true;
                        cmbProduto.Focus();
                        habilitaBotoesItem(false);
                        btnPesquisarItem.Enabled = true;
                        btnGravarItem.Enabled = false;
                        btnCancelarItem.Enabled = false;
                        MessageBox.Show(null, "Digite o nome do ITEM desejado ou" + "\nparte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        pc_itemvendaTableAdapter.FillByDescricao(this.lP2DataSet.pc_itemvenda,
                       "%" + cmbProduto.Text + "%", Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        btnCancelarItem_Click(null, null);

                    }
                }
                else
                {
                    MessageBox.Show(null, "Nenhum item encontrado", "Erro ao Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            limpaCampos(grpItem);
            habilitaCamposItem(false);
            habilitaBotoesItem(true);
            editarItem = false;
            incluirItem = false;
        }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluirItem)
                {
                    pc_itemvendaTableAdapter.Insert(
                        Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                        (Int32)cmbProduto.SelectedValue,
                        (Int32)nudQuantidade.Value,
                        precoTemp
                    );
                    dgvVendas_SelectionChanged(null, null);
                    MessageBox.Show(null, "Incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (editarItem)
                {
                    pc_itemvendaTableAdapter.Update(
                        (Int32)cmbProduto.SelectedValue, // CodPro
                        (Int32)nudQuantidade.Value,       // Quantidade
                        precoTemp,                        // PrecoUnit
                        Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()), // numvenda
                        Convert.ToInt32(dgvItens[1, dgvItens.CurrentRow.Index].Value.ToString())     // CodPro selecionado em dgvItens
                    );

                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvVendas_SelectionChanged(null, null);
                    
                    
                }
                habilitaBotoesItem(true);
                btnCancelarItem_Click(null, null);


            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: " + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Vendas_Load(null, null);
        }

        private void pc_vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpItem_Enter(object sender, EventArgs e)
        {

        }
    }
}
