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
    public partial class FrmRptBrinquedo : Form
    {
        public FrmRptBrinquedo()
        {
            InitializeComponent();
        }

        private void FrmRptBrinquedo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'LP2DataSet.pc_brinquedos'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_brinquedosTableAdapter.Fill(this.LP2DataSet.pc_brinquedos);

            this.reportViewer1.RefreshReport();
        }
    }
}
