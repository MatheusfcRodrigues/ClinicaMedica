document.getElementById('cadastroForm').addEventListener('submit', async (e) => {
    e.preventDefault();

    const novoPaciente = {
        nome: document.getElementById('nome').value,
        usuario: document.getElementById('usuario').value,
        senha: document.getElementById('senha').value,
        telefone: document.getElementById('telefone').value,
        nomePaciente: document.getElementById('nomePaciente').value,
        idade: parseInt(document.getElementById('idade').value)
    };

    const response = await fetch('http://localhost:5000/api/cadastro', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(novoPaciente)
    });

    const data = await response.json();

    if (response.ok) {
        alert(data.message);
        window.location.href = "login.html";
    } else {
        alert(data.message || "Erro ao cadastrar");
    }
});
