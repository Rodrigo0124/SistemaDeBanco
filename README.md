# 💰 Sistema de Banco - Projeto em C#

Este é um projeto simples de um sistema bancário feito em C#, desenvolvido como exercício para praticar conceitos básicos de programação orientada a objetos, estrutura condicional, entrada de dados e encapsulamento.

## 🔧 Funcionalidades

- Cadastro de cliente com nome e geração aleatória de número da conta
- Depósito inicial opcional
- Depósito de novos valores na conta
- Saque com aplicação de taxa fixa
- Exibição dos dados da conta formatados

## 📁 Estrutura do Projeto

- `Program.cs`: Responsável pela interação com o usuário e fluxo principal do programa
- `Deposito.cs`: Classe que representa a conta bancária, contendo os métodos de saque, depósito e exibição de dados

## ▶️ Como Executar

1. Abra o projeto no **Visual Studio** ou outro ambiente C# que suporte `.NET 8`
2. Compile e execute o projeto
3. Siga as instruções no terminal

## 📌 Requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download) ou superior
- IDE como Visual Studio, VS Code ou Rider

## 💡 Aprendizados

Este projeto aborda:

- Uso de `TryParse` para validação de entrada
- Encapsulamento com propriedades `get` e `set`
- Construtores sobrecarregados
- Cultura Invariant para valores monetários
- Estrutura básica de um sistema orientado a objetos

## 📷 Exemplo de Uso

```bash
Bem-vindo ao banco Unisul! Vamos começar pelo processo de cadastro.
Digite o seu nome: Rodrigo

Olá Sr(a) Rodrigo é um prazer tê-lo conosco! O número da sua conta é: 3928, por favor, não esqueça!

Deseja fazer um depósito inicial? Digite 1 para SIM ou 2 para NÃO: 1
Quanto deseja depositar em sua conta? Digite: 100

Os dados da sua conta são:
Nome: Rodrigo
Número da conta: 3928
Valor em conta = R$ 100.00

Desenvolvido por Rodrigo da Costa
