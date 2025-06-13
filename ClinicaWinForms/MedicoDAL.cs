using Clínica_Médica;
using System.Collections.Generic;
using System.Data.SqlClient; 

public class MedicoDAL
{
    private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davif\Source\Repos\ClinicaWinForms\ClinicaWinForms\ClinicaDB.mdf;Integrated Security=True";

    // Método para listar todos os médicos do banco
    public List<Medico> ListarMedicos()
    {
        var listaMedicos = new List<Medico>();
        // O 'using' garante que a conexão será fechada ao final
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open(); // Abre a conexão com o banco
            var cmd = new SqlCommand("SELECT Id, Nome, CRM, Especialidade FROM Medicos ORDER BY Nome", conn);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read()) // Lê linha por linha do resultado
                {
                    var medico = new Medico
                    {
                        // Aqui você precisa garantir que sua classe Medico tenha um 'Id'
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        CRM = reader.GetString(2),
                        Especialidade = reader.GetString(3)
                    };
                    listaMedicos.Add(medico);
                }
            }
        }
        return listaMedicos;
    }

    // Método para cadastrar um novo médico
    public void CadastrarMedico(Medico medico)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new SqlCommand("INSERT INTO Medicos (Nome, CRM, Especialidade) VALUES (@Nome, @CRM, @Especialidade)", conn);

            // Usar parâmetros previne SQL Injection
            cmd.Parameters.AddWithValue("@Nome", medico.Nome);
            cmd.Parameters.AddWithValue("@CRM", medico.CRM);
            cmd.Parameters.AddWithValue("@Especialidade", medico.Especialidade);

            cmd.ExecuteNonQuery(); // Executa o comando sem retornar dados
        }
    }
}

