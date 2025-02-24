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
    public partial class FrmClientes : Form
    {
        bool incluir = false;
        bool alterar = false;

        public FrmClientes()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            incluir = true;
            txtCodigo.Focus();
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

        private void pc_clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
           // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_clientesTableAdapter.Fill(this.lP2DataSet.pc_clientes);
        }
        private void habilitaCampos(bool hab)
        {

            txtNome.Enabled = hab;
            txtEndereco.Enabled = hab;
            txtCidade.Enabled = hab;
            txtBairro.Enabled = hab;
            mskEstado.Enabled = hab;
            mskCep.Enabled = hab;
            mskTelefone.Enabled = hab;
            dtpDataNasc.Enabled = hab;
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
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtCodigo.Enabled = false;
                txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                mskCep.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                mskEstado.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                mskTelefone.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                dtpDataNasc.Value = Convert.ToDateTime(dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString());
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_clientesTableAdapter.Insert(txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text, mskEstado.Text, mskCep.Text, mskTelefone.Text, dtpDataNasc.Value);
                    MessageBox.Show("Incluído com sucesso!", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pc_clientesTableAdapter.Update(txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text, mskEstado.Text, mskCep.Text, mskTelefone.Text, dtpDataNasc.Value, Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmClientes_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_clientesTableAdapter.Delete(Convert.ToInt32(dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString()));
                        FrmClientes_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtNome.Enabled == false)
            {
                txtNome.Enabled = true;
                txtNome.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome desejado ou parte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              else
              {
                 pc_clientesTableAdapter.FillByNome(this.lP2DataSet.pc_clientes,
                   "%"+txtNome.Text + "%");
                  btnCancelar_Click(null, null);
              }
        }
            



        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "telefone" )//|| this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "Telefone2")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;

                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5) + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }
                }
            }
            else if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "cep")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;

                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 5) + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }
                }
            }
        }









    }
     
}
