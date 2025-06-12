document.getElementById('loginForm').addEventListener('submit', async (e) => {
    e.preventDefault();

    const usuario = document.getElementById('usuario').value;
    const senha = document.getElementById('senha').value;

    const response = await fetch('http://localhost:5000/api/login', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ usuario, senha })
    });

    const data = await response.json();

    if (response.ok) {
        console.log("Login feito com sucesso", data);
        // Você pode salvar o token em localStorage, por exemplo:
        localStorage.setItem("token", data.token);
        localStorage.setItem("user", JSON.stringify(data.userLogado));
        window.location.href = "dashboard.html"; // redireciona
    } else {
        alert(data.message || "Falha no login");
    }
});
