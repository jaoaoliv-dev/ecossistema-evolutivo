# Ecossistema Evolutivo

Uma simulação de seleção natural em C#, onde criaturas com genes comem, crescem, se reproduzem e evoluem.

## Status

Em desenvolvimento. Os primeiros protótipos rodam pelo console.

## Tecnologias

- C# e .NET 10
- Unity como interface gráfica, futuramente

## Como rodar

Requisito: o [.NET SDK 10](https://dotnet.microsoft.com/download) instalado.

Com a raiz do repositório aberta no terminal, rode:

```bash
dotnet run --project DayOfACreature
```

O programa pede:
1. um nome para a criatura;
2. uma seed (um número inteiro, ou deixe vazio para uma execução aleatória).

Em seguida, a simulação roda até a energia da criatura acabar, e você acompanha tudo pelos logs.

## Roteiro

- Criaturas como classe
- Genes e mutações
- Versão na Unity com interface gráfica