using System;
using Clínica_Médica;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class PacienteDAL
{
    private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davif\Source\Repos\ClinicaWinForms\ClinicaWinForms\ClinicaDB.mdf;Integrated Security = True";

    public List<Paciente> ListarPacientes()
    {
        var listaPacientes = new List<Paciente>();
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new SqlCommand("SELECT Id, Nome, CPF, DataNascimento FROM Pacientes ORDER BY Nome", conn);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var paciente = new Paciente
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        CPF = reader.GetString(2),
                        DataNascimento = reader.GetDateTime(3)
                    };
                    listaPacientes.Add(paciente);
                }
            }
        }
        return listaPacientes;
    }

    public void CadastrarPaciente(Paciente paciente)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new SqlCommand("INSERT INTO Pacientes (Nome, CPF, DataNascimento) VALUES (@Nome, @CPF, @DataNascimento)", conn);

            cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
            cmd.Parameters.AddWithValue("@CPF", paciente.CPF);
            cmd.Parameters.AddWithValue("@DataNascimento", paciente.DataNascimento);

            cmd.ExecuteNonQuery();
        }
    }
}