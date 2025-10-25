abstract class Character
{
    protected string characterType;
    protected bool vulnerability = false;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => this.vulnerability;

    public override string ToString() => $"Character is a {this.characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        int points;
        if (target.Vulnerable()){
            points = 10;
        } else{
            points = 6;
        }
        
        return points;
    }
}

class Wizard : Character
{
    private bool spellPrepared = false;
    
    public Wizard() : base("Wizard")
    {
        base.vulnerability = true;
    }

    public override int DamagePoints(Character target)
    {
        int points;
        if (this.spellPrepared){
            points = 12;
        } else{
            points = 3;
        }
        this.spellPrepared = false;
        
        return points;
    }

    public void PrepareSpell()
    {
        this.spellPrepared = true;
        this.vulnerability = false;
    }
}
