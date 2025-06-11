# 🏥 Sistema de Gestão de Consultas Médicas

O presente sistema foi concebido com foco na gestão centralizada de múltiplas clínicas médicas, oferecendo uma plataforma unificada e escalável para o administrador geral. A aplicação, desenvolvida em C# com ASP.NET e interface baseada em HTML e Bootstrap, está preparada para atender às demandas de diferentes unidades clínicas, mantendo organização, segurança e eficiência no gerenciamento de dados e agendas médicas.

Finalidade do Sistema

- O sistema tem como principal objetivo possibilitar ao administrador da plataforma o controle total sobre os recursos das clínicas vinculadas, permitindo:
Cadastro e gerenciamento de clínicas e suas respectivas unidades.


- Controle centralizado de médicos, pacientes e agendamentos.


- Acompanhamento de agendas e históricos de atendimentos por clínica.


- Monitoramento de conflitos de horários e disponibilidade por unidade.


- Visão geral de dados operacionais das clínicas em tempo real.

## 📌 Objetivo

- Desenvolver um sistema que permita:
  - Cadastro e controle de médicos e pacientes;
  - Agendamento e cancelamento de consultas;
  - Validação de horários (sem conflitos);
  - Consulta ao histórico de atendimentos.

---

## ✅ Requisitos Funcionais

- Cadastro de **médicos** (nome, CRM, especialidade);
- Cadastro de **pacientes** (nome, CPF, data de nascimento);
- Agendamento e cancelamento de **consultas**;
- Validação de **conflitos de horário**;
- Listagem de **consultas por médico**;
- Histórico de **consultas por paciente**.

---

## 📋 Regras de Negócio

- Um paciente pode agendar **uma consulta por vez com o mesmo médico no mesmo dia**;
- Um médico pode realizar no máximo **10 consultas por dia**;
- A data da consulta **não pode estar no passado**.

---

## 🧩 Entidades Principais

- `Pessoa` (classe base):
  - `Médico`
  - `Paciente`
- `Consulta` (associação entre Médico e Paciente com data/hora)

---

## 🔧 Tecnologias Utilizadas

- Linguagem: `C#` `HTML` `CSS``JS`(.NET)
- Banco de Dados: `MySQL`
- IDE:`Visual Studio Code`
- Ferramentas: `MySQL Workbench`, `Entity Framework`,`Minimal API`

---

## 🚀 Extensões Futuras

- Filtro de busca por **especialidade médica**;
- Listagem de **consultas do dia**;
- Inclusão de **prontuário, diagnóstico e prescrições**.

---

## ▶️ Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/clinica-medica.git
