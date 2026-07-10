abstract class Character
{
    private string type = "None";
    public int DamagePoint = 0;
    public bool IsVulnerable = false;
    protected Character(string characterType)
    {
        this.type = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return IsVulnerable;
    }

    public override string ToString()
    {
        return String.Format("Character is a {0}", type);
    }
}

class Warrior : Character
{

    public Warrior() : base("Warrior")
    {
        this.DamagePoint = 6;
    }

    public override int DamagePoints(Character target)
    {
        if (target.IsVulnerable)
        {
            this.DamagePoint = 10;
        }
        int AtackedDamagePoint = DamagePoint;
        return AtackedDamagePoint;
    }
}

class Wizard : Character
{
    private bool isSpellPrepared = false;
    public Wizard() : base("Wizard")
    {
        this.IsVulnerable = true;
        this.DamagePoint = 3;
    }

    public override int DamagePoints(Character target)
    {
        int AtackedDamagePoint = DamagePoint;
        if (this.isSpellPrepared)
        {
            this.isSpellPrepared = false;
            this.IsVulnerable = true;
            this.DamagePoint = 3;
        }
        return AtackedDamagePoint;
    }

    public void PrepareSpell()
    {
        this.isSpellPrepared = true;
        this.IsVulnerable = false;
        this.DamagePoint = 12;
    }
}
