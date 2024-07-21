using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Pedido_De_Coleta
{
    public partial class Form1 : Form
    {
        private List<Pedido> pedidos = new List<Pedido>();
        private List<Pedido> pedidosImpressos = new List<Pedido>(); // Lista para armazenar os pedidos impressos
        private List<string> historicoImpressao = new List<string>(); // Lista para armazenar o histórico de impressões

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carregar dados fictícios ou reais
            pedidos.Add(new Pedido { Numero = 1, Cliente = "Rubens", LocalColeta = "Recife", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-1), DataLimite = DateTime.Now.AddDays(2), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Pendente" });
            pedidos.Add(new Pedido { Numero = 2, Cliente = "Ana", LocalColeta = "Curitiba", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Alocado" });
            pedidos.Add(new Pedido { Numero = 3, Cliente = "Lucio", LocalColeta = "São Paulo", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Alocado" });
            pedidos.Add(new Pedido { Numero = 5, Cliente = "Julia", LocalColeta = "Cabo Frio", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Cancelado" });
            pedidos.Add(new Pedido { Numero = 6, Cliente = "Paulo", LocalColeta = "Recife", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Coletado" });
            pedidos.Add(new Pedido { Numero = 7, Cliente = "Thais", LocalColeta = "Anta Gorda", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Alocado" });
            pedidos.Add(new Pedido { Numero = 8, Cliente = "Gustavo", LocalColeta = "Salvador", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Liberado" });
            pedidos.Add(new Pedido { Numero = 9, Cliente = "Lindomar", LocalColeta = "Camaçari", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Liberado" });
            pedidos.Add(new Pedido { Numero = 10, Cliente = "Fernanda", LocalColeta = "Passa e Fica", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Alocado" });
            pedidos.Add(new Pedido { Numero = 11, Cliente = "Oliver", LocalColeta = "Arroio dos Ratos", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Cancelado" });
            pedidos.Add(new Pedido { Numero = 12, Cliente = "Jaqueline", LocalColeta = "Solidão", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Pendente" });
            pedidos.Add(new Pedido { Numero = 13, Cliente = "Fernando", LocalColeta = "Sem-Peixe", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Cancelado" });
            pedidos.Add(new Pedido { Numero = 14, Cliente = "Gustavo", LocalColeta = "Chorrochó", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Alocado" });
            pedidos.Add(new Pedido { Numero = 15, Cliente = "Aline", LocalColeta = "Barrolândia", DataImpressao = DateTime.Now, DataSolicitacao = DateTime.Now.AddDays(-2), DataLimite = DateTime.Now.AddDays(3), HoraSolicitacao = DateTime.Now.TimeOfDay, Status = "Liberado" });

            // Vincular ao DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = pedidos;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            var filteredPedidos = pedidos.Where(p =>
                (string.IsNullOrEmpty(txtNumero.Text) || p.Numero.ToString().Contains(txtNumero.Text)) &&
                (string.IsNullOrEmpty(txtCliente.Text) || p.Cliente.Contains(txtCliente.Text)) &&
                (string.IsNullOrEmpty(txtLocalColeta.Text) || p.LocalColeta.Contains(txtLocalColeta.Text)) &&
                (string.IsNullOrEmpty(txtDataImpressao.Text) || p.DataImpressao.ToString("dd/MM/yyyy").Contains(txtDataImpressao.Text)) &&
                (string.IsNullOrEmpty(txtSolicitacao.Text) || p.DataSolicitacao.ToString("dd/MM/yyyy").Contains(txtSolicitacao.Text)) &&
                (string.IsNullOrEmpty(txtDataLimite.Text) || p.DataLimite.ToString("dd/MM/yyyy").Contains(txtDataLimite.Text)) &&
                (string.IsNullOrEmpty(txtHoraSolicitacao.Text) || p.HoraSolicitacao.ToString(@"hh\:mm").Contains(txtHoraSolicitacao.Text)) &&
                (rbTodos.Checked ||
                 (rbPendente.Checked && p.Status == "Pendente") ||
                 (rbAlocado.Checked && p.Status == "Alocado") ||
                 (rbLiberado.Checked && p.Status == "Liberado") ||
                 (rbColetado.Checked && p.Status == "Coletado") ||
                 (rbCancelado.Checked && p.Status == "Cancelado"))
            ).ToList();

            dataGridView1.DataSource = filteredPedidos;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var selectedDate = dateTimePicker1.Value.Date;
            var filteredPedidos = pedidos.Where(p => p.DataSolicitacao.Date == selectedDate).ToList();
            dataGridView1.DataSource = filteredPedidos;
        }

        // Implementação dos eventos de TextBox
        private void txtNumero_TextChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void txtCliente_TextChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void txtLocalColeta_TextChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void txtDataImpressao_TextChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void txtSolicitacao_TextChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void txtDataLimite_TextChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void txtHoraSolicitacao_TextChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }

        // Implementação dos eventos de RadioButton
        private void rbTodos_CheckedChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void rbPendente_CheckedChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void rbAlocado_CheckedChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void rbLiberado_CheckedChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void rbColetado_CheckedChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }
        private void rbCancelado_CheckedChanged(object sender, EventArgs e) { btPesquisar_Click(sender, e); }

        private void button9_Click(object sender, EventArgs e) { Close(); }

        private void btnOpenForm2_Click_Click(object sender, EventArgs e)
        {
            listHitorico historicoForm = new listHitorico(historicoImpressao); // Passa o histórico para o formulário
            historicoForm.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria uma nova aplicação do Excel
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets[1];
                worksheet.Name = "Dados";

                // Adiciona cabeçalhos da tabela
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                // Adiciona dados da tabela
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // Ajusta a largura das colunas
                worksheet.Columns.AutoFit();

                // Abre o Excel para edição
                excelApp.Visible = true;

                // Adiciona os pedidos impressos à lista de pedidos impressos
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.DataBoundItem is Pedido pedido)
                    {
                        pedidosImpressos.Add(pedido);
                    }
                }

                // Adiciona a data e hora da impressão ao histórico
                historicoImpressao.Add("Impressão realizada em: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar documento Excel: " + ex.Message);
            }
        }

        private void rdSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSim.Checked)
            {
                dataGridView1.DataSource = pedidosImpressos;
            }
            else
            {
                dataGridView1.DataSource = pedidos;
            }
        }

        private void rdNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNao.Checked)
            {
                var pedidosNaoImpressos = pedidos.Except(pedidosImpressos).ToList();
                dataGridView1.DataSource = pedidosNaoImpressos;
            }
            else
            {
                dataGridView1.DataSource = pedidos;
            }
        }
    }

    public class Pedido
    {
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public string LocalColeta { get; set; }
        public DateTime DataImpressao { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataLimite { get; set; }
        public TimeSpan HoraSolicitacao { get; set; }
        public string Status { get; set; }
    }
}
