class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    public Human (string Name){

        this.Name = Name;
        this.Strength = 3;
        this.Intelligence = 3;
        this.Dexterity = 3;
        this.Health = 100;

    }
     
      public Human (string Name, int Strength, int Intelligence, int Dexterity, int Health ){

        this.Name = Name;
        this.Strength = Strength;
        this.Intelligence = Intelligence;
        this.Dexterity = Dexterity;
        this.Health = Health;
       

    }
    // Add a constructor to assign custom values to all fields
     
    // Build Attack method
    public int Attack(Human target)
    {
        target.Health = target.Health - (3 * Strength);
        return target.Health;
    }
}

