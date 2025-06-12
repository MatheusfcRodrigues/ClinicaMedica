var builder = WebApplication.CreateBuilder(args);

// Passo 1: Configurar CORS para permitir que seu front-end acesse a API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

// Passo 2: Registrar sua classe Clinica como um "Singleton".
builder.Services.AddSingleton<Clinica>();

var app = builder.Build();

app.UseCors("AllowAnyOrigin");

// --- ENDPOINTS DA API ---

// Endpoint para Cadastro
app.MapPost("/api/cadastro", (Paciente novoPaciente, Clinica clinica) =>
{
    clinica.CadastrarPaciente(novoPaciente);
    Console.WriteLine($"Novo paciente cadastrado: {novoPaciente.Usuario}");
    return Results.Ok(new { message = "Usuário cadastrado com sucesso!" });
});

// Endpoint para Login
app.MapPost("/api/login", (LoginRequest loginRequest, Clinica clinica) =>
{
    var paciente = clinica.Pacientes.FirstOrDefault(p =>
        p.Usuario.Equals(loginRequest.Usuario, StringComparison.OrdinalIgnoreCase) &&
        p.Senha == loginRequest.Senha);

    if (paciente == null)
    {
        return Results.Json(
            new { message = "Usuário ou senha inválidos" },
            statusCode: StatusCodes.Status401Unauthorized
        );
    }

    var token = Guid.NewGuid().ToString(); // Token simples para o exemplo
    var userLogado = new
    {
        nome = paciente.Nome,
        user = paciente.Usuario,
        telefone = paciente.Telefone,
        nomepaciente = paciente.NomePaciente,
        idade = paciente.Idade,
        // outros campos, se necessário
    };

    Console.WriteLine($"Paciente {paciente.Usuario} logado com sucesso.");
    return Results.Ok(new { token, userLogado });
});

app.Run();

// Classe auxiliar para receber os dados de login
public record LoginRequest(string Usuario, string Senha);
