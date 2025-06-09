using System;
using System.Collections.Generic;
using System.Linq;

public class Clinica
{
    private List<Medico> medicos = new();
    private List<Paciente> pacientes = new();
    private List<Consulta> consultas = new();

    public void CadastrarMedico(Medico medico) => medicos.Add(medico);
    public void CadastrarPaciente(Paciente paciente) => pacientes.Add(paciente);

    public bool AgendarConsulta(Medico medico, Paciente paciente, DateTime dataHora)
    {
        if (dataHora < DateTime.Now) return false;

        if (consultas.Any(c => c.Medico == medico && c.DataHora == dataHora)) return false;

        if (consultas.Count(c => c.Medico == medico && c.DataHora.Date == dataHora.Date) >= 10) return false;

        if (consultas.Any(c => c.Paciente == paciente && c.Medico == medico && c.DataHora.Date == dataHora.Date)) return false;

        consultas.Add(new Consulta { Medico = medico, Paciente = paciente, DataHora = dataHora });
        return true;
    }

    public bool CancelarConsulta(Medico medico, Paciente paciente, DateTime dataHora)
    {
        var consulta = consultas.FirstOrDefault(c => c.Medico == medico && c.Paciente == paciente && c.DataHora == dataHora);
        if (consulta != null)
        {
            consultas.Remove(consulta);
            return true;
        }
        return false;
    }

    public List<Consulta> ConsultasPorMedico(Medico medico) =>
        consultas.Where(c => c.Medico == medico).OrderBy(c => c.DataHora).ToList();

    public List<Consulta> HistoricoPorPaciente(Paciente paciente) =>
        consultas.Where(c => c.Paciente == paciente).OrderByDescending(c => c.DataHora).ToList();
}
