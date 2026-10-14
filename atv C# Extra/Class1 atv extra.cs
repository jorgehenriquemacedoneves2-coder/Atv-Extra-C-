```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao = -1;

        while (opcao != 0)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("     DESAFIOS DE PROGRAMACAO C#");
            Console.WriteLine("======================================");
            Console.WriteLine("1 - Cadastro de Aluno");
            Console.WriteLine("2 - Cadastro Profissional");
            Console.WriteLine("3 - Cadastro de Produto");
            Console.WriteLine("4 - Cadastro de Veiculo");
            Console.WriteLine("5 - Perfil do Estudante");
            Console.WriteLine("6 - Sistema de Matricula");
            Console.WriteLine("7 - Cadastro de Equipamento");
            Console.WriteLine("8 - Cadastro de Livro");
            Console.WriteLine("9 - Cadastro de Cliente");
            Console.WriteLine("10 - Inscricao em Curso");
            Console.WriteLine("11 - Sistema de Atendimento");
            Console.WriteLine("12 - Cadastro de Evento");
            Console.WriteLine("13 - Sistema de Pedido");
            Console.WriteLine("14 - Sistema de Locacao");
            Console.WriteLine("15 - Cadastro Organizado");
            Console.WriteLine("16 - Cadastro de Funcionario");
            Console.WriteLine("17 - Cadastro Profissional Completo");
            Console.WriteLine("18 - Situacao do Cotidiano");
            Console.WriteLine("19 - Sistema de Cadastro");
            Console.WriteLine("20 - Cadastro de Alunos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("======================================");
            Console.Write("Escolha uma opcao: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1;
            }

            Console.Clear();

            // Exercicio 01 - Cadastro de aluno
            if (opcao == 1)
            {
                string nome, cidade;
                int idade;
                double altura;
                char inicial;
                bool matriculado;

                Console.Write("Nome completo: ");
                nome = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Altura: ");
                double.TryParse(Console.ReadLine(), out altura);

                Console.Write("Inicial do nome: ");
                char.TryParse(Console.ReadLine(), out inicial);

                Console.Write("Matriculado (true/false): ");
                bool.TryParse(Console.ReadLine(), out matriculado);

                Console.WriteLine("\n===== FICHA DO ALUNO =====");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Altura: " + altura);
                Console.WriteLine("Inicial: " + inicial);
                Console.WriteLine("Matriculado: " + matriculado);
            }

            // Exercicio 02 - Ficha profissional
            else if (opcao == 2)
            {
                string nome, cidade, cargo;
                int idade;
                double salario;
                char inicial;
                bool ativo;

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Cargo: ");
                cargo = Console.ReadLine();

                Console.Write("Salario: ");
                double.TryParse(Console.ReadLine(), out salario);

                Console.Write("Inicial: ");
                char.TryParse(Console.ReadLine(), out inicial);

                Console.Write("Ativo na empresa (true/false): ");
                bool.TryParse(Console.ReadLine(), out ativo);

                Console.WriteLine("\n===== FICHA PROFISSIONAL =====");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Cargo: " + cargo);
                Console.WriteLine("Salario: R$ " + salario);
                Console.WriteLine("Inicial: " + inicial);
                Console.WriteLine("Ativo: " + ativo);
            }

            // Exercicio 03 - Cadastro de produto
            else if (opcao == 3)
            {
                string nome, categoria;
                int codigo, quantidade;
                double preco;
                char inicial;
                bool disponivel;

                Console.Write("Nome do produto: ");
                nome = Console.ReadLine();

                Console.Write("Codigo: ");
                int.TryParse(Console.ReadLine(), out codigo);

                Console.Write("Categoria: ");
                categoria = Console.ReadLine();

                Console.Write("Preco: ");
                double.TryParse(Console.ReadLine(), out preco);

                Console.Write("Quantidade: ");
                int.TryParse(Console.ReadLine(), out quantidade);

                Console.Write("Inicial da categoria: ");
                char.TryParse(Console.ReadLine(), out inicial);

                Console.Write("Disponivel para venda (true/false): ");
                bool.TryParse(Console.ReadLine(), out disponivel);

                Console.WriteLine("\n===== PRODUTO CADASTRADO =====");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Categoria: " + categoria);
                Console.WriteLine("Preco: R$ " + preco);
                Console.WriteLine("Quantidade: " + quantidade);
                Console.WriteLine("Inicial: " + inicial);
                Console.WriteLine("Disponivel: " + disponivel);
            }

            // Exercicio 04 - Cadastro de veiculo
            else if (opcao == 4)
            {
                string marca, modelo, categoria;
                int ano;
                double preco;
                char inicial;
                bool disponivel;

                Console.Write("Marca: ");
                marca = Console.ReadLine();

                Console.Write("Modelo: ");
                modelo = Console.ReadLine();

                Console.Write("Ano: ");
                int.TryParse(Console.ReadLine(), out ano);

                Console.Write("Preco: ");
                double.TryParse(Console.ReadLine(), out preco);

                Console.Write("Categoria: ");
                categoria = Console.ReadLine();

                Console.Write("Inicial da marca: ");
                char.TryParse(Console.ReadLine(), out inicial);

                Console.Write("Disponivel para venda (true/false): ");
                bool.TryParse(Console.ReadLine(), out disponivel);

                Console.WriteLine("\n===== VEICULO CADASTRADO =====");
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Modelo: " + modelo);
                Console.WriteLine("Ano: " + ano);
                Console.WriteLine("Preco: R$ " + preco);
                Console.WriteLine("Categoria: " + categoria);
                Console.WriteLine("Inicial: " + inicial);
                Console.WriteLine("Disponivel: " + disponivel);
            }

            // Exercicio 05 - Perfil do estudante
            else if (opcao == 5)
            {
                string nome, cidade, curso;
                int idade;
                double altura;
                char inicial;
                bool trabalha, estuda;

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Curso: ");
                curso = Console.ReadLine();

                Console.Write("Altura: ");
                double.TryParse(Console.ReadLine(), out altura);

                Console.Write("Inicial: ");
                char.TryParse(Console.ReadLine(), out inicial);

                Console.Write("Trabalha (true/false): ");
                bool.TryParse(Console.ReadLine(), out trabalha);

                Console.Write("Estuda (true/false): ");
                bool.TryParse(Console.ReadLine(), out estuda);

                Console.WriteLine("\n===== PERFIL DO ESTUDANTE =====");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Curso: " + curso);
                Console.WriteLine("Altura: " + altura);
                Console.WriteLine("Inicial: " + inicial);
                Console.WriteLine("Trabalha: " + trabalha);
                Console.WriteLine("Estuda: " + estuda);
            }

            // Exercicio 06 - Sistema de matricula
            else if (opcao == 6)
            {
                string nome, curso, cidade, turno;
                int idade, matricula;
                bool ativo;

                Console.Write("Nome do aluno: ");
                nome = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Curso: ");
                curso = Console.ReadLine();

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Numero de matricula: ");
                int.TryParse(Console.ReadLine(), out matricula);

                Console.Write("Turno: ");
                turno = Console.ReadLine();

                Console.Write("Estudante ativo (true/false): ");
                bool.TryParse(Console.ReadLine(), out ativo);

                Console.WriteLine("\n===== MATRICULA =====");
                Console.WriteLine("Aluno: " + nome);
                Console.WriteLine("Matricula: " + matricula);
                Console.WriteLine("Curso: " + curso);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Turno: " + turno);
                Console.WriteLine("Ativo: " + ativo);
                Console.WriteLine("MATRICULA REGISTRADA COM SUCESSO!");
            }

            // Exercicio 07 - Cadastro de equipamento
            else if (opcao == 7)
            {
                string equipamento, marca, modelo, patrimonio;
                int ano;
                double valor;
                bool funcionando;

                Console.Write("Equipamento: ");
                equipamento = Console.ReadLine();

                Console.Write("Marca: ");
                marca = Console.ReadLine();

                Console.Write("Modelo: ");
                modelo = Console.ReadLine();

                Console.Write("Ano de aquisicao: ");
                int.TryParse(Console.ReadLine(), out ano);

                Console.Write("Valor: ");
                double.TryParse(Console.ReadLine(), out valor);

                Console.Write("Numero de patrimonio: ");
                patrimonio = Console.ReadLine();

                Console.Write("Esta funcionando (true/false): ");
                bool.TryParse(Console.ReadLine(), out funcionando);

                Console.WriteLine("\n===== ETIQUETA DE PATRIMONIO =====");
                Console.WriteLine("Equipamento: " + equipamento);
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Modelo: " + modelo);
                Console.WriteLine("Ano: " + ano);
                Console.WriteLine("Valor: R$ " + valor);
                Console.WriteLine("Patrimonio: " + patrimonio);
                Console.WriteLine("Funcionando: " + funcionando);
            }

            // Exercicio 08 - Cadastro de livro
            else if (opcao == 8)
            {
                string titulo, autor, categoria;
                int ano, codigo;
                double preco;
                bool disponivel;

                Console.Write("Titulo: ");
                titulo = Console.ReadLine();

                Console.Write("Autor: ");
                autor = Console.ReadLine();

                Console.Write("Ano: ");
                int.TryParse(Console.ReadLine(), out ano);

                Console.Write("Codigo: ");
                int.TryParse(Console.ReadLine(), out codigo);

                Console.Write("Preco: ");
                double.TryParse(Console.ReadLine(), out preco);

                Console.Write("Categoria: ");
                categoria = Console.ReadLine();

                Console.Write("Disponivel para emprestimo (true/false): ");
                bool.TryParse(Console.ReadLine(), out disponivel);

                Console.WriteLine("\n===== LIVRO CADASTRADO =====");
                Console.WriteLine("Titulo: " + titulo);
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Ano: " + ano);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Preco: R$ " + preco);
                Console.WriteLine("Categoria: " + categoria);
                Console.WriteLine("Disponivel: " + disponivel);
            }

            // Exercicio 09 - Cadastro de cliente
            else if (opcao == 9)
            {
                string nome, cidade, situacao;
                int idade, codigo;

                Console.Write("Nome do cliente: ");
                nome = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Codigo do cliente: ");
                int.TryParse(Console.ReadLine(), out codigo);

                Console.Write("Situacao do cliente: ");
                situacao = Console.ReadLine();

                Console.WriteLine("\n===== FICHA DO CLIENTE =====");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Situacao: " + situacao);
            }

            // Exercicio 10 - Inscricao em curso
            else if (opcao == 10)
            {
                string nome, curso, cidade, email;
                int idade, inscricao;
                bool confirmada;

                Console.Write("Nome do candidato: ");
                nome = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Curso: ");
                curso = Console.ReadLine();

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Numero da inscricao: ");
                int.TryParse(Console.ReadLine(), out inscricao);

                Console.Write("Inscricao confirmada (true/false): ");
                bool.TryParse(Console.ReadLine(), out confirmada);

                Console.WriteLine("\n===== INSCRICAO REALIZADA =====");
                Console.WriteLine("Candidato: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Curso: " + curso);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Email: " + email);
                Console.WriteLine("Inscricao: " + inscricao);
                Console.WriteLine("Confirmada: " + confirmada);
            }

            // Exercicio 11 - Sistema de atendimento
            else if (opcao == 11)
            {
                string identificacao, nome, cidade, motivo;
                int idade, codigo;
                bool concluido;

                Console.Write("Identificacao do cliente: ");
                identificacao = Console.ReadLine();

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Motivo do atendimento: ");
                motivo = Console.ReadLine();

                Console.Write("Codigo do atendimento: ");
                int.TryParse(Console.ReadLine(), out codigo);

                Console.Write("Atendimento concluido (true/false): ");
                bool.TryParse(Console.ReadLine(), out concluido);

                Console.WriteLine("\n===== ATENDIMENTO =====");
                Console.WriteLine("Identificacao: " + identificacao);
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Motivo: " + motivo);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Concluido: " + concluido);
            }

            // Exercicio 12 - Cadastro de evento
            else if (opcao == 12)
            {
                string participante, evento, local, data;
                int idade, codigo;
                bool confirmado;

                Console.Write("Nome do participante: ");
                participante = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Nome do evento: ");
                evento = Console.ReadLine();

                Console.Write("Local: ");
                local = Console.ReadLine();

                Console.Write("Data: ");
                data = Console.ReadLine();

                Console.Write("Codigo do participante: ");
                int.TryParse(Console.ReadLine(), out codigo);

                Console.Write("Participacao confirmada (true/false): ");
                bool.TryParse(Console.ReadLine(), out confirmado);

                Console.WriteLine("\n===== CADASTRO DE EVENTO =====");
                Console.WriteLine("Participante: " + participante);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Evento: " + evento);
                Console.WriteLine("Local: " + local);
                Console.WriteLine("Data: " + data);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Confirmado: " + confirmado);
            }

            // Exercicio 13 - Sistema de pedido
            else if (opcao == 13)
            {
                string cliente, produto, tipo;
                int quantidade;
                double valor;
                bool ativo;

                Console.Write("Cliente: ");
                cliente = Console.ReadLine();

                Console.Write("Produto: ");
                produto = Console.ReadLine();

                Console.Write("Quantidade: ");
                int.TryParse(Console.ReadLine(), out quantidade);

                Console.Write("Valor unitario: ");
                double.TryParse(Console.ReadLine(), out valor);

                Console.Write("Tipo do pedido: ");
                tipo = Console.ReadLine();

                Console.Write("Pedido ativo (true/false): ");
                bool.TryParse(Console.ReadLine(), out ativo);

                Console.WriteLine("\n===== RESUMO DO PEDIDO =====");
                Console.WriteLine("Cliente: " + cliente);
                Console.WriteLine("Produto: " + produto);
                Console.WriteLine("Quantidade: " + quantidade);
                Console.WriteLine("Valor unitario: R$ " + valor);
                Console.WriteLine("Tipo: " + tipo);
                Console.WriteLine("Ativo: " + ativo);
            }

            // Exercicio 14 - Sistema de locacao
            else if (opcao == 14)
            {
                string cliente, equipamento, codigo;
                int dias;
                double valor;
                bool disponivel;

                Console.Write("Cliente: ");
                cliente = Console.ReadLine();

                Console.Write("Equipamento: ");
                equipamento = Console.ReadLine();

                Console.Write("Codigo: ");
                codigo = Console.ReadLine();

                Console.Write("Quantidade de dias: ");
                int.TryParse(Console.ReadLine(), out dias);

                Console.Write("Valor da locacao: ");
                double.TryParse(Console.ReadLine(), out valor);

                Console.Write("Equipamento disponivel (true/false): ");
                bool.TryParse(Console.ReadLine(), out disponivel);

                Console.WriteLine("\n===== LOCACAO =====");
                Console.WriteLine("Cliente: " + cliente);
                Console.WriteLine("Equipamento: " + equipamento);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Dias: " + dias);
                Console.WriteLine("Valor: R$ " + valor);
                Console.WriteLine("Disponivel: " + disponivel);
            }

            // Exercicio 15 - Melhorando a organizacao
            else if (opcao == 15)
            {
                string nomeAluno, cidadeAluno;
                int idadeAluno;
                double alturaAluno;

                Console.WriteLine("CADASTRO ORGANIZADO");
                Console.Write("Nome: ");
                nomeAluno = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idadeAluno);

                Console.Write("Cidade: ");
                cidadeAluno = Console.ReadLine();

                Console.Write("Altura: ");
                double.TryParse(Console.ReadLine(), out alturaAluno);

                Console.WriteLine("\n================================");
                Console.WriteLine("         FICHA DO ALUNO");
                Console.WriteLine("================================");
                Console.WriteLine("Nome: " + nomeAluno);
                Console.WriteLine("Idade: " + idadeAluno);
                Console.WriteLine("Cidade: " + cidadeAluno);
                Console.WriteLine("Altura: " + alturaAluno);
                Console.WriteLine("================================");
            }

            // Exercicio 16 - Cadastro com verificacao de dados
            else if (opcao == 16)
            {
                string nome, cargo, setor;
                int idade;
                double salario;
                bool ativo;

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Cargo: ");
                cargo = Console.ReadLine();

                Console.Write("Setor: ");
                setor = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Salario: ");
                double.TryParse(Console.ReadLine(), out salario);

                Console.Write("Ativo (true/false): ");
                bool.TryParse(Console.ReadLine(), out ativo);

                Console.WriteLine("\n===== FUNCIONARIO =====");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Cargo: " + cargo);
                Console.WriteLine("Setor: " + setor);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Salario: R$ " + salario);
                Console.WriteLine("Ativo: " + ativo);
            }

            // Exercicio 17 - Desenvolvedor
            else if (opcao == 17)
            {
                string nome, cargo, empresa, cidade, email;
                int idade, codigo;
                double salario;
                bool ativo;

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Cargo: ");
                cargo = Console.ReadLine();

                Console.Write("Empresa: ");
                empresa = Console.ReadLine();

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Codigo do funcionario: ");
                int.TryParse(Console.ReadLine(), out codigo);

                Console.Write("Salario: ");
                double.TryParse(Console.ReadLine(), out salario);

                Console.Write("Ativo (true/false): ");
                bool.TryParse(Console.ReadLine(), out ativo);

                Console.WriteLine("\n===== FICHA PROFISSIONAL =====");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Cargo: " + cargo);
                Console.WriteLine("Empresa: " + empresa);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Email: " + email);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Salario: R$ " + salario);
                Console.WriteLine("Ativo: " + ativo);
            }

            // Exercicio 18 - Situacao do cotidiano: oficina
            else if (opcao == 18)
            {
                string cliente, veiculo, servico, data;
                int codigo;
                double valor;
                bool concluido;

                Console.Write("Nome do cliente: ");
                cliente = Console.ReadLine();

                Console.Write("Veiculo: ");
                veiculo = Console.ReadLine();

                Console.Write("Servico: ");
                servico = Console.ReadLine();

                Console.Write("Data: ");
                data = Console.ReadLine();

                Console.Write("Codigo do servico: ");
                int.TryParse(Console.ReadLine(), out codigo);

                Console.Write("Valor: ");
                double.TryParse(Console.ReadLine(), out valor);

                Console.Write("Servico concluido (true/false): ");
                bool.TryParse(Console.ReadLine(), out concluido);

                Console.WriteLine("\n===== ORDEM DE SERVICO =====");
                Console.WriteLine("Cliente: " + cliente);
                Console.WriteLine("Veiculo: " + veiculo);
                Console.WriteLine("Servico: " + servico);
                Console.WriteLine("Data: " + data);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Valor: R$ " + valor);
                Console.WriteLine("Concluido: " + concluido);
            }

            // Exercicio 19 - Sistema profissional de cadastro
            else if (opcao == 19)
            {
                string nome, categoria, marca, codigo, cidade;
                int quantidade, ano;
                double preco;
                bool disponivel;

                Console.Write("Nome do produto: ");
                nome = Console.ReadLine();

                Console.Write("Categoria: ");
                categoria = Console.ReadLine();

                Console.Write("Marca: ");
                marca = Console.ReadLine();

                Console.Write("Codigo: ");
                codigo = Console.ReadLine();

                Console.Write("Cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Quantidade: ");
                int.TryParse(Console.ReadLine(), out quantidade);

                Console.Write("Ano de fabricacao: ");
                int.TryParse(Console.ReadLine(), out ano);

                Console.Write("Preco: ");
                double.TryParse(Console.ReadLine(), out preco);

                Console.Write("Disponivel (true/false): ");
                bool.TryParse(Console.ReadLine(), out disponivel);

                Console.WriteLine("\n===== SISTEMA DE CADASTRO =====");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Categoria: " + categoria);
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Codigo: " + codigo);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Quantidade: " + quantidade);
                Console.WriteLine("Ano: " + ano);
                Console.WriteLine("Preco: R$ " + preco);
                Console.WriteLine("Disponivel: " + disponivel);
            }

            // Exercicio 20 - Cadastro de alunos
            else if (opcao == 20)
            {
                string nome1, cidade1, curso1;
                int idade1;
                double altura1;
                bool ativo1;

                Console.WriteLine("CADASTRO DE ALUNO");
                Console.Write("Nome: ");
                nome1 = Console.ReadLine();

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade1);

                Console.Write("Cidade: ");
                cidade1 = Console.ReadLine();

                Console.Write("Altura: ");
                double.TryParse(Console.ReadLine(), out altura1);

                Console.Write("Curso: ");
                curso1 = Console.ReadLine();

                Console.Write("Estudante ativo (true/false): ");
                bool.TryParse(Console.ReadLine(), out ativo1);

                Console.WriteLine("\n===== ALUNO CADASTRADO =====");
                Console.WriteLine("Nome: " + nome1);
                Console.WriteLine("Idade: " + idade1);
                Console.WriteLine("Cidade: " + cidade1);
                Console.WriteLine("Altura: " + altura1);
                Console.WriteLine("Curso: " + curso1);
                Console.WriteLine("Ativo: " + ativo1);
            }

            else if (opcao == 0)
            {
                Console.WriteLine("Programa encerrado.");
            }
            else
            {
                Console.WriteLine("Opcao invalida!");
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Pressione uma tecla para finalizar.");
        Console.ReadKey();
    }
}
```