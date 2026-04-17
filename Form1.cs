using System;
using System.Collections.Generic; // Necessário para usar a lista dinâmica List<>
using System.Drawing;           // Necessário para manipular cores como Color.Red e Color.White
using System.Windows.Forms;      // Biblioteca base para criação de interfaces Windows Forms

namespace EstoqueSimples
{
    public partial class dvgEstoque : Form
    {
        // Criamos uma lista global para guardar nossos produtos na memória RAM enquanto o sistema estiver aberto
        // Esta lista armazena objetos do tipo 'Produto'
        List<Produto> listaDeProdutos = new List<Produto>();

        public dvgEstoque()
        {
            // Inicializa os componentes visuais criados no Designer (botões, caixas de texto, etc)
            InitializeComponent();

            // IMPORTANTE: Impede o Grid de criar colunas automaticamente ao receber os dados.
            // Isso evita que o nome "Quantidade" apareça duplicado na sua tela.
            dgvEstoque.AutoGenerateColumns = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Criamos uma nova instância (uma "ficha" em branco) baseada na classe Produto
            Produto novoProduto = new Produto();

            // Atribuímos o que o usuário digitou nas caixas de texto para as propriedades do objeto
            novoProduto.Nome = Nometxt.Text;
            novoProduto.Quantidade = (int)numQuantidade.Value;

            // Adicionamos esse produto preenchido dentro da nossa lista global
            listaDeProdutos.Add(novoProduto);

            // Chamamos a função para atualizar os dados que aparecem na tela do usuário
            AtualizarInterface();
        }

        // Função responsável por sincronizar a Lista de memória com a Grade (Grid) da tela
        private void AtualizarInterface()
        {
            // Resetamos a fonte de dados para "nulo" para forçar o Grid a se redesenhar
            dgvEstoque.DataSource = null;

            // Vinculamos nossa lista de produtos novamente ao Grid
            dgvEstoque.DataSource = listaDeProdutos;

            // Após atualizar os dados, verificamos se algum item precisa de alerta visual
            VerificarAlertasDeEstoque();

            // Limpamos o campo de texto de nome para o próximo cadastro
            Nometxt.Clear();

            // Colocamos o foco do cursor no campo Nome para agilizar a digitação
            Nometxt.Focus();
        }

        private void VerificarAlertasDeEstoque()
        {
            // O loop 'foreach' percorre cada linha (Row) que existe dentro do DataGridView
            foreach (DataGridViewRow linha in dgvEstoque.Rows)
            {
                        
             
                    // Convertemos o valor da célula para um número inteiro
                    int qtd = (int)linha.Cells["Quantidade"].Value;

                    // Regra de negócio: Se a quantidade for menor que 5, pintamos de vermelho
                    if (qtd < 5)
                    {
                        // Define a cor de fundo da linha inteira
                        linha.DefaultCellStyle.BackColor = Color.Red;

                        // Define a cor da fonte (letra) para branco para facilitar a leitura
                        linha.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Caso o estoque esteja normal (5 ou mais), voltamos para as cores padrão
                        linha.DefaultCellStyle.BackColor = Color.White;
                        linha.DefaultCellStyle.ForeColor = Color.Black;
                    }
             
            }
        }
    }
    }