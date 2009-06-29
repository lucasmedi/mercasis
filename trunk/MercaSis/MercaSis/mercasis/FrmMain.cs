using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercaSis
{
    public partial class FrmMain : Form
    {
        #region Construtor

        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos Primários

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostra<FrmCadastroCliente>(new FrmCadastroCliente());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos Secundários

        private void Mostra<T>(T f)
        {
            (f as Form).MdiParent = this;
            (f as Form).Show();
        }

        #endregion
    }
}
