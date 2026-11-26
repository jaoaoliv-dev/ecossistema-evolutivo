# Ecossistema Evolutivo

Uma simulação de seleção natural em C#, onde criaturas com genes comem, crescem, se reproduzem e evoluem.

## Status

Em desenvolvimento. Os primeiros protótipos rodam pelo console.

### Módulo 1: DayOfACreature

Uma simulação simples de um dia na vida de uma criatura: ela anda, gasta energia e se alimenta.

### Módulo 2: CreatureLab

A criatura passa a ser uma classe (`Creature`) em arquivo próprio, com a energia protegida: só a própria criatura altera sua energia. Na prática, o programa funciona como o do Módulo 1.

## Tecnologias

- C# e .NET 10
- Unity como interface gráfica, futuramente

## Como rodar

Requisito: o [.NET SDK 10](https://dotnet.microsoft.com/download) instalado.

Com a raiz do repositório aberta no terminal, rode um dos projetos.

Módulo 1:

```bash
dotnet run --project DayOfACreature
```

Módulo 2:

```bash
dotnet run --project CreatureLab
```

O programa pede:

1. um nome para a criatura;
2. uma seed (um número inteiro, ou deixe vazio para uma execução aleatória).

Em seguida, a simulação roda até a energia da criatura acabar, e você acompanha tudo pelos logs.

## Roteiro

- [x] Criatura simples no console
- [x] Criaturas como classe
- [ ] Genes e mutações
- [ ] Versão na Unity