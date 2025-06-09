using System;

class Program
{
    static void Main()
    {
        Clinica clinica = new();

        Medico medico = new()
        {
            Nome = "Dr. Carlos",
            CRM = "123456",
            Especialidade = "Cardiologia"
        };
        clinica.CadastrarMedico(medico);

        Paciente paciente = new()
        {
            Nome = "João da Silva",
            CPF = "123.456.789-00",
            DataNascimento = new DateTime(1990, 5, 10)
        };
        clinica.CadastrarPaciente(paciente);

        DateTime dataConsulta = DateTime.Now.AddDays(1).AddHours(10);
        if (clinica.AgendarConsulta(medico, paciente, dataConsulta))
            Console.WriteLine("Consulta agendada com sucesso!");
        else
            Console.WriteLine("Falha ao agendar consulta.");

        Console.WriteLine($" Consultas para o médico {medico.Nome}:");

        foreach (var consulta in clinica.ConsultasPorMedico(medico))
        {
            Console.WriteLine($"Paciente: {consulta.Paciente.Nome}, Data: {consulta.DataHora}");
        }

        Console.WriteLine($" Histórico do paciente {paciente.Nome}:");
        
        foreach (var consulta in clinica.HistoricoPorPaciente(paciente))
        {
            Console.WriteLine($"Médico: {consulta.Medico.Nome}, Data: {consulta.DataHora}");
        }
    }
}
