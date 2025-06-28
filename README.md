# 💰 Sistema de Banco - Projeto em C#

Este é um projeto simples de um sistema bancário feito em C#, desenvolvido como exercício para praticar conceitos de programação orientada a objetos, estrutura condicional, entrada de dados, validação e encapsulamento.

## 🔐 Novidades Recentes

- Adição de **sistema de autenticação com senha de 4 dígitos**
- **Tela de login** com verificação de número da conta e senha
- Bloqueio temporário após 4 tentativas de senha incorreta
- Uso de `Thread.Sleep()` para pausas e `Console.Clear()` para experiência mais fluida
- Melhorias gerais no layout das mensagens no console

## 🔧 Funcionalidades

- Cadastro de cliente com nome e número de conta aleatório
- Escolha de senha numérica de 4 dígitos
- Depósito inicial (opcional)
- Depósito e saque com taxa fixa
- Validações de entrada (números, valores, senha)
- Exibição formatada dos dados da conta
- Login com autenticação (senha + número da conta)

## 📁 Estrutura do Projeto

- `Program.cs`: Lógica principal de execução, cadastro, login e interações com o usuário
- `Deposito.cs`: Classe que representa a conta bancária (nome, saldo, número, senha)

## ▶️ Como Executar

1. Abra o projeto no **Visual Studio**, **VS Code** ou outro ambiente que suporte `.NET 8`
2. Compile e execute
3. Siga o fluxo no terminal

## 📌 Requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download) ou superior
- IDE como **Visual Studio**, **VS Code** ou **JetBrains Rider**

## 💡 Aprendizados

Este projeto aborda:

- Uso de `TryParse` para validação robusta de entrada
- Encapsulamento com `get` e `private set`
- Construtores sobrecarregados
- Uso de `CultureInfo.InvariantCulture` para lidar com valores monetários
- Organização de código com métodos auxiliares
- Implementação de autenticação simples e controle de tentativas
- Simulação de fluxo bancário por linha de comando

## 📷 Exemplo de Uso

Bem-vindo ao banco Unisul! Vamos começar pelo processo de cadastro.
Digite o seu nome: Rodrigo

Olá Sr(a) Rodrigo é um prazer tê-lo conosco! O número da sua conta é: 3928, por favor, não esqueça!

Por favor, escolha uma senha de 4 dígitos para acessar sua conta: ****

Seja bem-vindo à tela de login, digite suas credenciais para acessar o aplicativo de banco Unisul!
Número da conta: 3928
Digite sua senha: ****

Dados corretos! Seja bem-vindo Rodrigo.

Deseja fazer um depósito inicial? Digite 1 para SIM ou 2 para NÃO: 1
Quanto deseja depositar em sua conta? Digite: R$ 100

===== Dados da Conta =====
Nome: Rodrigo

Número da conta: 3928

Saldo: R$ 100.00


## 👤 Autor

Desenvolvido por **Rodrigo da Costa**

---
