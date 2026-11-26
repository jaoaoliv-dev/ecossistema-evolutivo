
public class Creature
{
    public int Energy {get; private set;} = 20;
    public int Steps {get; private set;} = 0;

    public void Walk()
    {
        Energy -=2;
        Steps +=1;
        if (Energy < 0)
        {
            Energy = 0;
        }
    }
    public void Eat()
    {
        Energy +=5;
    }
}



