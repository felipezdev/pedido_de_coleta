using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pedido_De_Coleta
{
    public partial class listHitorico : Form
    {
        public listHitorico(List<string> historico)
        {
            InitializeComponent();
            // Adiciona o histórico ao ListBox
            listBoxHistorico.Items.AddRange(historico.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
