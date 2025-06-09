let btn = document.querySelector('#verSenha')
let btnConfirm = document.querySelector('#verConfirmSenha')


let nome = document.querySelector('#nome')
let labelNome = document.querySelector('#labelNome')
let validNome = false

let usuario = document.querySelector('#usuario')
let labelUsuario = document.querySelector('#labelUsuario')
let validUsuario = false

let telefone = document.querySelector('#telefone')
let labeltelefone = document.querySelector("#labeltelefone")
let validtelefone = false

let idade = document.querySelector('#idade')
let labelidade = document.querySelector("#labelidade")
let valididade = false 

let nomepet = document.querySelector('#nomepet')
let labelnomepet= document.querySelector("#labelnomepet")
let validnomepet = false 

let raça = document.querySelector('#raça')
let labelraça= document.querySelector("#labelraça")
let validraça = false 


let senha = document.querySelector('#senha')
let labelSenha = document.querySelector('#labelSenha')
let validSenha = false

let confirmSenha = document.querySelector('#confirmSenha')
let labelConfirmSenha = document.querySelector('#labelConfirmSenha')
let validConfirmSenha = false

let msgError = document.querySelector('#msgError')
let msgSuccess = document.querySelector('#msgSuccess')

nome.addEventListener('keyup', () => {
  if(nome.value.length <= 2){
    labelNome.setAttribute('style', 'color: red')
    labelNome.innerHTML = 'Nome *Insira no minimo 3 caracteres'
    nome.setAttribute('style', 'border-color: red')
    validNome = false
  } else {
    labelNome.setAttribute('style', 'color: green')
    labelNome.innerHTML = 'Nome'
    nome.setAttribute('style', 'border-color: green')
    validNome = true
  }
})

usuario.addEventListener('keyup', () => {
  if(usuario.value.length <= 4){
    labelUsuario.setAttribute('style', 'color: red')
    labelUsuario.innerHTML = 'Usuário *Insira no minimo 5 caracteres'
    usuario.setAttribute('style', 'border-color: red')
    validUsuario = false
  } else {
    labelUsuario.setAttribute('style', 'color: green')
    labelUsuario.innerHTML = 'Usuário'
    usuario.setAttribute('style', 'border-color: green')
    validUsuario = true
  }
})

telefone.addEventListener('keyup', () => {
  if(telefone.value.length <= 8){
    labeltelefone.setAttribute('style', 'color: red')
    labeltelefone.innerHTML = 'Telefone *Insira no minimo 8 caracteres'
    telefone.setAttribute('style', 'border-color: red')
    validtelefone = false
  } else {
    labeltelefone.setAttribute('style', 'color: green')
    labeltelefone.innerHTML = 'Telefone'
    telefone.setAttribute('style', 'border-color: green')
    validtelefone = true
  }
})

idade.addEventListener('keyup', () => {
  if(idade.value.length > 2){
    labelidade.setAttribute('style', 'color: red')
    labelidade.innerHTML = 'Idade *Insira no minimo 2 caracteres'
    idade.setAttribute('style', 'border-color: red')
    valididade = false
  } else {
    labelidade.setAttribute('style', 'color: green')
    labelidade.innerHTML = 'Idade'
    idade.setAttribute('style', 'border-color: green')
    valididade = true
  }
})

nomepet.addEventListener('keyup', () => {
  labelnomepet.setAttribute('style', 'color: green')
    labelnomepet.innerHTML = 'NomePet'
    nomepet.setAttribute('style', 'border-color: green')
    valididade = true
    return
  if(nomepet.value.length < 5){
    labelnomepet.setAttribute('style', 'color: red')
    labelnomepet.innerHTML = 'NomePet *Insira no minimo 5 caracteres'
    nomepet.setAttribute('style', 'border-color: red')
    validnomepet = false
  } else {
    labelnomepet.setAttribute('style', 'color: green')
    labelnomepet.innerHTML = 'Idade'
    nomepet.setAttribute('style', 'border-color: green')
    valididade = true
  }
})

raça.addEventListener('keyup', () => {
  labelraça.setAttribute('style', 'color: green')
    labelraça.innerHTML = 'Raça'
    nomepet.setAttribute('style', 'border-color: green')
    validraça = true
    return
  if(raça.value.length < 5){
    labelraça.setAttribute('style', 'color: red')
    labelraça.innerHTML = 'Raça *Insira no minimo 5 caracteres'
    raça.setAttribute('style', 'border-color: red')
    validraça = false
  } else {
    labelraça.setAttribute('style', 'color: green')
    labelraça.innerHTML = 'Idade'
    raça.setAttribute('style', 'border-color: green')
    validraça = true
  }
})


senha.addEventListener('keyup', () => {
  if(senha.value.length <= 5){
    labelSenha.setAttribute('style', 'color: red')
    labelSenha.innerHTML = 'Senha *Insira no minimo 6 caracteres'
    senha.setAttribute('style', 'border-color: red')
    validSenha = false
  } else {
    labelSenha.setAttribute('style', 'color: green')
    labelSenha.innerHTML = 'Senha'
    senha.setAttribute('style', 'border-color: green')
    validSenha = true
  }
})

confirmSenha.addEventListener('keyup', () => {
  if(senha.value != confirmSenha.value){
    labelConfirmSenha.setAttribute('style', 'color: red')
    labelConfirmSenha.innerHTML = 'Confirmar Senha *As senhas não conferem'
    confirmSenha.setAttribute('style', 'border-color: red')
    validConfirmSenha = false
  } else {
    labelConfirmSenha.setAttribute('style', 'color: green')
    labelConfirmSenha.innerHTML = 'Confirmar Senha'
    confirmSenha.setAttribute('style', 'border-color: green')
    validConfirmSenha = true
  }
})



function cadastrar(){
  if(validNome && validUsuario && validSenha && validConfirmSenha){
    let listaUser = JSON.parse(localStorage.getItem('listaUser') || '[]')
    
    listaUser.push(
    {
      nomeCad: nome.value,
      userCad: usuario.value,
      senhaCad: senha.value,
      telefoneCad: telefone.value,
      idadeCad: idade.value,
      nomepet: nomepet.value,
      raça: raça.value,
    }
    )
    
    localStorage.setItem('listaUser', JSON.stringify(listaUser))
    
   
    msgSuccess.setAttribute('style', 'display: block')
    msgSuccess.innerHTML = '<strong>Cadastrando usuário...</strong>'
    msgError.setAttribute('style', 'display: none')
    msgError.innerHTML = ''
    
    setTimeout(()=>{
        window.location.href = '../html/signin.html'
    }, 3000)
  
    
  } else {
    msgError.setAttribute('style', 'display: block')
    msgError.innerHTML = '<strong>Preencha todos os campos corretamente antes de cadastrar</strong>'
    msgSuccess.innerHTML = ''
    msgSuccess.setAttribute('style', 'display: none')
  }
}

btn.addEventListener('click', ()=>{
  let inputSenha = document.querySelector('#senha')
  
  if(inputSenha.getAttribute('type') == 'password'){
    inputSenha.setAttribute('type', 'text')
  } else {
    inputSenha.setAttribute('type', 'password')
  }
})

btnConfirm.addEventListener('click', ()=>{
  let inputConfirmSenha = document.querySelector('#confirmSenha')
  
  if(inputConfirmSenha.getAttribute('type') == 'password'){
    inputConfirmSenha.setAttribute('type', 'text')
  } else {
    inputConfirmSenha.setAttribute('type', 'password')
  }
})



  
  
