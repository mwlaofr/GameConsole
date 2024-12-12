# Jogo Batalha de Monstros 🕹

## O que foi feito
Foi desenvolvido um jogo de batalha de monstros em console utilizando a linguagem C#. O projeto é organizado em três principais módulos:

- **Combate:** Contém as ações de combate, como atacar e defender.
- **Jogo:** Gerencia o fluxo principal do jogo, incluindo o controle de jogo, gameplay, e sistema de pontuação.
- **Monstros:** Define os diferentes tipos de monstros que podem ser enfrentados no jogo, utilizando uma fábrica de monstros para facilitar a criação de novos inimigos.

O jogo apresenta um menu inicial com opções para iniciar um novo jogo ou sair. Durante o jogo, o jogador enfrenta monstros controlados pela lógica do programa e pode escolher ações como atacar, defender ou utilizar a habilidade especial.

## Como executar

### Requisitos
- .NET SDK instalado na máquina.

### Passos para executar
1. Clone o repositório do projeto para sua máquina local:
   ```bash
   git clone https://github.com/mwlaofr/GameConsole.git
   ```
2. Navegue até a pasta do projeto:
   ```bash
   cd BatalhaDeMonstros
   ```
3. Compile o projeto:
   ```bash
   dotnet build
   ```
4. Execute o projeto:
   ```bash
   dotnet run
   ```
5. No menu inicial, escolha a opção desejada digitando o número correspondente.

## Padrões de Projetos Utilizados

### 1. Factory Method 🏗
O padrão **Factory Method** foi implementado na classe `MonstroFactory.cs` para criar diferentes tipos de monstros (​`Dragao`, `Zumbi`, `Robo`). Isso permite expandir o jogo com novos tipos de monstros sem alterar o código existente.

### 2. Strategy 🎯
O padrão **Strategy** foi aplicado no módulo **Combate** para definir diferentes ações de combate (`Atacar`, `Defender`), implementando a interface `IAcaoDeCombate`. Isso possibilita a troca de estratégias de combate dinamicamente durante o jogo.

### 3. Observer 🔎
O padrão **Observer** foi utilizado para atualizar o estado do jogo, como pontuação e status dos jogadores, através da classe `ScoreManager.cs`. Isso mantém a lógica desacoplada e o sistema facilmente expansível.
   
### 4. Command ⌨️
O padrão **Command** é utilizado para encapsular as ações do jogador (como atacar ou defender), facilitando a organização e modularidade das ações.

### 5. Singleton 🕹
O padrão **Singleton** foi implementado na classe `GameController.cs` para garantir que apenas uma instância do controlador de jogo seja usada durante a execução do programa, centralizando a lógica de controle do jogo.

## Estrutura do Projeto

```
BatalhaDeMonstros/
├── Combate/
│   ├── Atacar.cs
│   ├── Defender.cs
│   └── IAcaoDeCombate.cs
├── Jogo/
│   ├── GameController.cs
│   ├── GamePlay.cs
│   └── ScoreManager.cs
├── Monstros/
│   ├── Dragao.cs
│   ├── MonstroFactory.cs
│   ├── Monstro.cs
│   ├── Robo.cs
│   └── Zumbi.cs
├── Program.cs
└── BatalhaDeMonstros.sln
```

## Autoras
- **Millena França**
- **Melina Nogueira**

