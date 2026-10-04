# GamerProfile

Projeto desenvolvido para a disciplina de Garantia da Qualidade de Software.

## Objetivo

Criar uma solução .NET 10 para gerenciamento de perfil de jogadores,
utilizando testes unitários com xUnit.

## Funcionalidades

O projeto possui três métodos principais:

- `GerarTagUsuario` — gera a tag do jogador utilizando nickname e código.
- `CalcularXPTotal` — calcula o XP total das fases adicionando um bônus de 100 pontos.
- `EEligivelParaRanked` — verifica se o jogador possui nível suficiente para partidas ranqueadas.

## Testes Unitários

Foram implementados testes utilizando xUnit:

1. Teste do método `GerarTagUsuario` utilizando `Assert.Equal`.
2. Teste do método `CalcularXPTotal` utilizando `Assert.Equal`.
3. Teste do método `EEligivelParaRanked` utilizando `Assert.True` e `Assert.False`.

## Como executar os testes

No terminal, dentro da pasta do projeto, execute:

```bash
dotnet test