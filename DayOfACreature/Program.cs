
// --------------- Nomeia a criatura ----------------------------
Console.Write("Digite um nome para sua criatura: ");
string? name = Console.ReadLine(); 

// --------------------- Define uma seed -------------------------
Console.Write("Digite uma seed: ");
string? seedString = Console.ReadLine();

Random random;

if (int.TryParse(seedString, out int seed))
{
    random = new Random(seed);
}
else
{
    random = new Random();
}

// ------------------ Variaveis da criatura ---------------------
int energy = 20;
int step = 0;

// --------------------- Loop principal ------------------------
while (energy > 0)
{
    step +=1;
    energy -=2;
    if (FindsFood(random))
    {
        energy +=5;
        Console.WriteLine("Achou comida!");
    }
    else
    {
        Console.WriteLine("Nada por aqui");

    }
    
    Console.WriteLine($"Passo {step}, energia agora é {energy}");
}

// ----------------------- Metodo que diz se achou comida ---------------------
bool FindsFood(Random random)
{
    int roll = random.Next(0,100);
    return roll < 30;
}

Console.WriteLine($"{name} parou depois de {step} passos");