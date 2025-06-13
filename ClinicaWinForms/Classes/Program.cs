using Clínica_Médica;
using System;

class Program
{
    static Clinica clinica = new Clinica();

    static void Menu()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("==== SISTEMA CLÍNICO ====");
            Console.WriteLine("1 - Cadastrar Médico");
            Console.WriteLine("2 - Cadastrar Paciente");
            Console.WriteLine("3 - Agendar Consulta");
            Console.WriteLine("4 - Cancelar Consulta");
            Console.WriteLine("5 - Consultas por Médico");
            Console.WriteLine("6 - Histórico por Paciente");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: CadastrarMedico(); break;
                case 2: CadastrarPaciente(); break;
                case 3: AgendarConsulta(); break;
                case 4: CancelarConsulta(); break;
                case 5: MostrarConsultasPorMedico(); break;
                case 6: MostrarHistoricoPorPaciente(); break;
                case 0: break;
                default: Console.WriteLine("Opção inválida!"); break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (opcao != 0);
    }

    static void CadastrarMedico()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("CRM: ");
        string crm = Console.ReadLine();
        Console.Write("Especialidade: ");
        string especialidade = Console.ReadLine();

        var medico = new Medico { Nome = nome, CRM = crm, Especialidade = especialidade };
        clinica.CadastrarMedico(medico);
        Console.WriteLine("Médico cadastrado com sucesso!");
    }

    static void CadastrarPaciente()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Data de Nascimento (dd/mm/aaaa): ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine());

        var paciente = new Paciente { Nome = nome, CPF = cpf, DataNascimento = nascimento };
        clinica.CadastrarPaciente(paciente);
        Console.WriteLine("Paciente cadastrado com sucesso!");
    }

    static void AgendarConsulta()
    {
        // Aqui simplificamos. Na versão real, seria melhor selecionar por CPF/CRM ou nome
        Console.WriteLine("Agendamento de consulta: (simulação)");
        // Adicione lógica de busca e validação se desejar
    }

    static void CancelarConsulta()
    {
        Console.WriteLine("Cancelamento de consulta: (simulação)");
        // Simulação simples por enquanto
    }

    static void MostrarConsultasPorMedico()
    {
        Console.WriteLine("Listar consultas: (simulação)");
    }

    static void MostrarHistoricoPorPaciente()
    {
        Console.WriteLine("Histórico do paciente: (simulação)");
    }
}
