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
    public partial class FrmBrinquedo : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmBrinquedo()
        {
            InitializeComponent();
        }

        private void pc_brinquedosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_brinquedosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void FrmBrinquedo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lP2DataSet.pc_brinquedos' table. You can move, or remove it, as needed.
            this.pc_brinquedosTableAdapter.Fill(this.lP2DataSet.pc_brinquedos);

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            txtId_Brinquedo.Enabled = false;
            incluir = true;
            txtModelo.Focus();
            NudFaixa_Etaria.Value = 1;
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
           
            NudFaixa_Etaria.Enabled = hab;
            txtModelo.Enabled = hab;
            txtMarca.Enabled = hab;
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            NudFaixa_Etaria.Value = 0;
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_brinquedosTableAdapter.Insert(txtMarca.Text, txtModelo.Text, int.Parse(NudFaixa_Etaria.Text),dtpData_Cad.Value);
                    MessageBox.Show("Incluído com sucesso!", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pc_brinquedosTableAdapter.Update(txtModelo.Text,txtMarca.Text,int.Parse(NudFaixa_Etaria.Text),dtpData_Cad.Value,int.Parse(txtId_Brinquedo.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmBrinquedo_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvBrinquedo.SelectedRows.Count > 0)
            {
                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);

                txtId_Brinquedo.Text = dgvBrinquedo[0, dgvBrinquedo.CurrentRow.Index].Value.ToString();
                txtModelo.Text = dgvBrinquedo[1, dgvBrinquedo.CurrentRow.Index].Value.ToString();
                txtMarca.Text = dgvBrinquedo[2, dgvBrinquedo.CurrentRow.Index].Value.ToString();
                NudFaixa_Etaria.Value = Convert.ToInt32(dgvBrinquedo[3, dgvBrinquedo.CurrentRow.Index].Value.ToString());
                txtModelo.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um Brinquedo primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBrinquedo.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_brinquedosTableAdapter.Delete(Convert.ToInt32(dgvBrinquedo[0, dgvBrinquedo.CurrentRow.Index].Value.ToString()));
                        FrmBrinquedo_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um Brinquedo primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtModelo.Enabled == false)
            {
                habilitaCampos(false);
                txtModelo.Enabled = true;
                txtModelo.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome do Brinquedo desejado ou" + "\nparte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                pc_brinquedosTableAdapter.FillByModelo(this.lP2DataSet.pc_brinquedos,
                    "%" + txtModelo.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void pc_brinquedosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_brinquedosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void pc_brinquedosBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_brinquedosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void pc_brinquedosBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_brinquedosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void pc_brinquedosBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_brinquedosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }
    }
}
