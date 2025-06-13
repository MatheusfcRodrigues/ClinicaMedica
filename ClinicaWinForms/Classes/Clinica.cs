using Clínica_Médica;
using System;
using System.Collections.Generic;
using System.Linq;

public class Clinica
{
    public List<Medico> Medicos { get; private set; } = new();
    public List<Paciente> Pacientes { get; private set; } = new();
    public List<Consulta> Consultas { get; private set; } = new();

    public void CadastrarMedico(Medico medico)
    {
        if (medico == null)
            throw new ArgumentNullException(nameof(medico), "Médico não pode ser nulo.");

        if (string.IsNullOrWhiteSpace(medico.CRM))
            throw new ArgumentException("CRM é obrigatório.");

        if (Medicos.Any(m => m.CRM == medico.CRM))
            throw new InvalidOperationException("Médico com esse CRM já está cadastrado.");

        Medicos.Add(medico);
    }

    public void CadastrarPaciente(Paciente paciente)
    {
        if (paciente == null)
            throw new ArgumentNullException(nameof(paciente), "Paciente não pode ser nulo.");

        if (string.IsNullOrWhiteSpace(paciente.CPF))
            throw new ArgumentException("CPF é obrigatório.");

        if (Pacientes.Any(p => p.CPF == paciente.CPF))
            throw new InvalidOperationException("Paciente com esse CPF já está cadastrado.");

        Pacientes.Add(paciente);
    }

    public bool AgendarConsulta(Medico medico, Paciente paciente, DateTime dataHora)
    {
        if (medico == null || paciente == null)
            throw new ArgumentNullException("Médico e paciente são obrigatórios.");

        if (dataHora < DateTime.Now)
            throw new ArgumentException("Não é possível agendar uma consulta no passado.");

        if (!Medicos.Contains(medico))
            throw new InvalidOperationException("Médico não cadastrado.");

        if (!Pacientes.Contains(paciente))
            throw new InvalidOperationException("Paciente não cadastrado.");

        if (Consultas.Any(c => c.Medico == medico && c.DataHora == dataHora))
            throw new InvalidOperationException("Já existe uma consulta para esse médico neste horário.");

        if (Consultas.Count(c => c.Medico == medico && c.DataHora.Date == dataHora.Date) >= 10)
            throw new InvalidOperationException("Limite diário de consultas para esse médico atingido.");

        if (Consultas.Any(c => c.Paciente == paciente && c.Medico == medico && c.DataHora.Date == dataHora.Date))
            throw new InvalidOperationException("Paciente já tem uma consulta com esse médico nesse dia.");

        Consultas.Add(new Consulta { Medico = medico, Paciente = paciente, DataHora = dataHora });
        return true;
    }

    public bool CancelarConsulta(Medico medico, Paciente paciente, DateTime dataHora)
    {
        if (medico == null || paciente == null)
            throw new ArgumentNullException("Médico e paciente são obrigatórios.");

        var consulta = Consultas.FirstOrDefault(c => c.Medico == medico && c.Paciente == paciente && c.DataHora == dataHora);

        if (consulta == null)
            throw new InvalidOperationException("Consulta não encontrada para cancelamento.");

        Consultas.Remove(consulta);
        return true;
    }

    public List<Consulta> ConsultasPorMedico(Medico medico)
    {
        if (medico == null)
            throw new ArgumentNullException(nameof(medico));

        return Consultas.Where(c => c.Medico == medico)
                        .OrderBy(c => c.DataHora)
                        .ToList();
    }

    public List<Consulta> HistoricoPorPaciente(Paciente paciente)
    {
        if (paciente == null)
            throw new ArgumentNullException(nameof(paciente));

        return Consultas.Where(c => c.Paciente == paciente)
                        .OrderByDescending(c => c.DataHora)
                        .ToList();
    }

    public void SalvarDados()
    {
        Persistencia.Salvar("medicos.json", Medicos);
        Persistencia.Salvar("pacientes.json", Pacientes);
        Persistencia.Salvar("consultas.json", Consultas);
    }

    public void CarregarDados()
    {
        Medicos = Persistencia.Carregar<Medico>("medicos.json");
        Pacientes = Persistencia.Carregar<Paciente>("pacientes.json");
        Consultas = Persistencia.Carregar<Consulta>("consultas.json");
    }

}