using Clínica_Médica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaWinForms
{
    public class ConsultaDAL
    {
        // COLE A SUA CONNECTION STRING AQUI
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davif\Source\Repos\ClinicaWinForms\ClinicaWinForms\ClinicaDB.mdf;Integrated Security = True";

        public void AgendarConsulta(Consulta consulta)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Note que só inserimos os IDs e a data.
                var cmd = new SqlCommand("INSERT INTO Consultas (DataHora, MedicoId, PacienteId) VALUES (@DataHora, @MedicoId, @PacienteId)", conn);

                cmd.Parameters.AddWithValue("@DataHora", consulta.DataHora);
                cmd.Parameters.AddWithValue("@MedicoId", consulta.MedicoId);
                cmd.Parameters.AddWithValue("@PacienteId", consulta.PacienteId);

                cmd.ExecuteNonQuery();
            }
        }

        // A função principal do seu formulário!
        public List<Consulta> ListarConsultasPorMedico(int medicoId)
        {
            var listaConsultas = new List<Consulta>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Este SQL é mais avançado:
                // 1. "AS NomePaciente" renomeia a coluna 'Nome' da tabela Pacientes para evitar confusão.
                // 2. "JOIN" une as tabelas Consultas e Pacientes usando o PacienteId.
                // 3. "WHERE" filtra as consultas para um médico específico.
                string sql = @"
                SELECT 
                    c.Id, 
                    c.DataHora, 
                    p.Nome AS NomePaciente,
                    c.PacienteId
                FROM Consultas c
                JOIN Pacientes p ON c.PacienteId = p.Id
                WHERE c.MedicoId = @MedicoId
                ORDER BY c.DataHora";

                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MedicoId", medicoId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var consulta = new Consulta
                        {
                            Id = (int)reader["Id"],
                            DataHora = (DateTime)reader["DataHora"],
                            PacienteId = (int)reader["PacienteId"],
                            // Criamos um objeto Paciente só com o nome para exibir na grade
                            Paciente = new Paciente { Nome = (string)reader["NomePaciente"] }
                        };
                        listaConsultas.Add(consulta);
                    }
                }
            }
            return listaConsultas;
        }

        public List<Consulta> ListarConsultasPorPaciente(int pacienteId)
        {
            var listaConsultas = new List<Consulta>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // A lógica do SQL é a mesma, mas invertida:
                // 1. Buscamos na tabela Consultas.
                // 2. Juntamos com a tabela Medicos para obter o nome do médico.
                // 3. Filtramos pelo ID do Paciente.
                // 4. Ordenamos pela data mais recente primeiro (DESC), o que faz sentido para um histórico.
                string sql = @"
            SELECT 
                c.Id, 
                c.DataHora, 
                m.Nome AS NomeMedico,
                m.Especialidade,
                c.MedicoId
            FROM Consultas c
            JOIN Medicos m ON c.MedicoId = m.Id
            WHERE c.PacienteId = @PacienteId
            ORDER BY c.DataHora DESC";

                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PacienteId", pacienteId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var consulta = new Consulta
                        {
                            Id = (int)reader["Id"],
                            DataHora = (DateTime)reader["DataHora"],
                            MedicoId = (int)reader["MedicoId"],
                            // Agora, criamos um objeto Medico só com o nome para exibir
                            Medico = new Medico 
                            {
                                Nome = (string)reader["NomeMedico"],
                                 Especialidade = reader.IsDBNull(reader.GetOrdinal("Especialidade")) ? "" :reader.GetString(reader.GetOrdinal("Especialidade"))
                            }
                        };
                        listaConsultas.Add(consulta);
                    }
                }
            }
            return listaConsultas;
        }
    }
}
