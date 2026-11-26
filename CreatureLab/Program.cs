

// ------------------------------------------------- intro ---------------------------------------------------

Console.WriteLine("BEM VINDO!");
Console.WriteLine("Essa é uma simulacão de um ecossitema onde as criaturas evoluem");
Console.WriteLine("É bem simples, voce escolhe um nome para sua criatura e ela comeca a se mover em busca de alimento");
Console.WriteLine("Cada passo gasta energia, se a energia chegar a 0 ela morre");
Console.WriteLine("Mas a cada passo ela tem a chance de encontrar comida e isso lhe da mais energia!");
Console.WriteLine("Vamos comecar escolhendo o nome da sua criatura!");

// ------------------------------------------ nome da criatura -------------------------------------------------------

Console.Write("Digite aqui: ");
string? name = Console.ReadLine();

// ------------------------------------------------ seed -----------------------------------------------------------

Console.WriteLine("Agora vamos escolher uma Seed, com ela voce pode obter uma simulacao exatamente identica todas as vezes");
Console.Write("Digite aqui: ");
string? seedString = Console.ReadLine();

Random random;

if (int.TryParse(seedString, out int seed)) //converte a string da entrada para um inteiro e salva na seed, se vier vazio ou for invalido gera uma seed aleatoria
{
    random = new Random(seed);
}
else
{
    random = new Random();
}

// -------------------------------------------- Loop ----------------------------------------------

Creature creature = new Creature();

while (creature.Energy > 0)
{
    creature.Walk();

    if (FindsFood(random))
    {
        creature.Eat();
        Console.WriteLine("Voce achou comida");
    }
    Console.WriteLine($"Passo {creature.Steps}, a energia agora é: {creature.Energy}");


}




// --------------------------------------- Achar comida -----------------------------------

bool FindsFood (Random random)
{
    int roll = random.Next(0,100);
    return roll < 30;
}