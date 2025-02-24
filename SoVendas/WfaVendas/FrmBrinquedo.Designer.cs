
namespace WfaVendas
{
    partial class FrmBrinquedo
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
            System.Windows.Forms.Label lblId;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label faixa_etariaLabel;
            System.Windows.Forms.Label datacadLabel;
            this.txtId_Brinquedo = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.dtpData_Cad = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.NudFaixa_Etaria = new System.Windows.Forms.NumericUpDown();
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.pc_brinquedosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_brinquedosTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_brinquedosTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSetTableAdapters.TableAdapterManager();
            this.dgvBrinquedo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblId = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            faixa_etariaLabel = new System.Windows.Forms.Label();
            datacadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudFaixa_Etaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_brinquedosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrinquedo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(172, 81);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(24, 13);
            lblId.TabIndex = 1;
            lblId.Text = "ID :";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(172, 107);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 3;
            modeloLabel.Text = "Modelo:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(172, 133);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 5;
            marcaLabel.Text = "Marca:";
            // 
            // faixa_etariaLabel
            // 
            faixa_etariaLabel.AutoSize = true;
            faixa_etariaLabel.Location = new System.Drawing.Point(172, 159);
            faixa_etariaLabel.Name = "faixa_etariaLabel";
            faixa_etariaLabel.Size = new System.Drawing.Size(64, 13);
            faixa_etariaLabel.TabIndex = 7;
            faixa_etariaLabel.Text = "Faixa etaria:";
            // 
            // datacadLabel
            // 
            datacadLabel.AutoSize = true;
            datacadLabel.Location = new System.Drawing.Point(172, 185);
            datacadLabel.Name = "datacadLabel";
            datacadLabel.Size = new System.Drawing.Size(58, 13);
            datacadLabel.TabIndex = 9;
            datacadLabel.Text = "Data Cad :";
            // 
            // txtId_Brinquedo
            // 
            this.txtId_Brinquedo.Enabled = false;
            this.txtId_Brinquedo.Location = new System.Drawing.Point(236, 78);
            this.txtId_Brinquedo.Name = "txtId_Brinquedo";
            this.txtId_Brinquedo.Size = new System.Drawing.Size(50, 20);
            this.txtId_Brinquedo.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(236, 104);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(200, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(236, 130);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // dtpData_Cad
            // 
            this.dtpData_Cad.Enabled = false;
            this.dtpData_Cad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData_Cad.Location = new System.Drawing.Point(236, 182);
            this.dtpData_Cad.Name = "dtpData_Cad";
            this.dtpData_Cad.Size = new System.Drawing.Size(95, 20);
            this.dtpData_Cad.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(520, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 23);
            this.btnSair.TabIndex = 98;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(435, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 96;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(10, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(64, 23);
            this.btnIncluir.TabIndex = 92;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(95, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 23);
            this.btnExcluir.TabIndex = 93;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(265, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(64, 23);
            this.btnPesquisar.TabIndex = 94;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(350, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(64, 23);
            this.btnGravar.TabIndex = 95;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(180, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(64, 23);
            this.btnAlterar.TabIndex = 97;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // NudFaixa_Etaria
            // 
            this.NudFaixa_Etaria.Enabled = false;
            this.NudFaixa_Etaria.Location = new System.Drawing.Point(236, 156);
            this.NudFaixa_Etaria.Name = "NudFaixa_Etaria";
            this.NudFaixa_Etaria.Size = new System.Drawing.Size(58, 20);
            this.NudFaixa_Etaria.TabIndex = 99;
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_brinquedosBindingSource
            // 
            this.pc_brinquedosBindingSource.DataMember = "pc_brinquedos";
            this.pc_brinquedosBindingSource.DataSource = this.lP2DataSet;
            // 
            // pc_brinquedosTableAdapter
            // 
            this.pc_brinquedosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_brinquedosTableAdapter = this.pc_brinquedosTableAdapter;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_itemvendaTableAdapter = null;
            this.tableAdapterManager.pc_produtoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaVendas.LP2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvBrinquedo
            // 
            this.dgvBrinquedo.AllowUserToAddRows = false;
            this.dgvBrinquedo.AllowUserToDeleteRows = false;
            this.dgvBrinquedo.AutoGenerateColumns = false;
            this.dgvBrinquedo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrinquedo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvBrinquedo.DataSource = this.pc_brinquedosBindingSource;
            this.dgvBrinquedo.Location = new System.Drawing.Point(34, 218);
            this.dgvBrinquedo.Name = "dgvBrinquedo";
            this.dgvBrinquedo.ReadOnly = true;
            this.dgvBrinquedo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrinquedo.Size = new System.Drawing.Size(550, 220);
            this.dgvBrinquedo.TabIndex = 100;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_brinquedos";
            this.dataGridViewTextBoxColumn1.HeaderText = "Brinquedo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "faixa_etaria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Faixa etária";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Datacad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data de cadastro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FrmBrinquedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 589);
            this.Controls.Add(this.dgvBrinquedo);
            this.Controls.Add(this.NudFaixa_Etaria);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(lblId);
            this.Controls.Add(this.txtId_Brinquedo);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(faixa_etariaLabel);
            this.Controls.Add(datacadLabel);
            this.Controls.Add(this.dtpData_Cad);
            this.Name = "FrmBrinquedo";
            this.Text = "Brinquedos";
            this.Load += new System.EventHandler(this.FrmBrinquedo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudFaixa_Etaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_brinquedosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrinquedo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId_Brinquedo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.DateTimePicker dtpData_Cad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.NumericUpDown NudFaixa_Etaria;
        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource pc_brinquedosBindingSource;
        private LP2DataSetTableAdapters.pc_brinquedosTableAdapter pc_brinquedosTableAdapter;
        private LP2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvBrinquedo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}