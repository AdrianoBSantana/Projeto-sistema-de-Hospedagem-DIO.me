# 🏨 Sistema de Hospedagem em C#

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

## 💻 Sobre o Projeto

Este projeto é a solução para o desafio de modelar e implementar um sistema de reservas de hotel em C#, utilizando conceitos de Programação Orientada a Objetos.

Ele foi desenvolvido como parte do bootcamp **Avanade - Back-end com .NET e IA**, oferecido pela [Digital Innovation One (DIO)](https://dio.me/), com o objetivo de solidificar os conhecimentos na linguagem C# e na plataforma .NET.

## ✨ Funcionalidades

O sistema é capaz de:

✔️ Cadastrar suítes com informações de tipo, capacidade e valor da diária.
✔️ Cadastrar hóspedes.
✔️ Criar uma reserva, associando uma suíte e uma lista de hóspedes a um período de dias.
✔️ Calcular o valor total da reserva, aplicando um **desconto de 10%** para estadias de 10 dias ou mais.
✔️ Validar a capacidade da suíte, lançando uma exceção caso o número de hóspedes exceda o limite.

## 🏛️ Modelo de Classes

A estrutura do projeto é baseada em três classes principais que se relacionam para formar o sistema:

-   **`Pessoa.cs`**: Representa o hóspede, com propriedades para nome e sobrenome.
-   **`Suite.cs`**: Representa a suíte do hotel, contendo tipo, capacidade e valor da diária.
-   **`Reserva.cs`**: Classe central que orquestra a reserva, ligando os hóspedes e a suíte, além de conter a lógica de negócio para cálculo e validações.

## 🛠️ Tecnologias Utilizadas

-   [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
-   [.NET](https://dotnet.microsoft.com/)

## 🚀 Como Executar

Para testar a aplicação, siga os passos abaixo:

1.  Clone o seu repositório:
    ```bash
    git clone [URL-DO-SEU-REPOSITORIO-AQUI]
    ```
2.  Navegue até o diretório do projeto:
    ```bash
    cd nome-do-seu-projeto
    ```
3.  Execute a aplicação através do terminal:
    ```bash
    dotnet run
    ```
O programa poderá ser executado em modo de teste (com dados pré-definidos) ou em modo interativo, onde o usuário informa os dados da reserva.

## 📄 Desafio Original

Este projeto foi desenvolvido com base no desafio proposto no repositório da DIO. Você pode encontrar o enunciado original aqui:

➡️ **[digitalinnovationone/trilha-net-explorando-desafio](https://github.com/digitalinnovationone/trilha-net-explorando-desafio.git)**
