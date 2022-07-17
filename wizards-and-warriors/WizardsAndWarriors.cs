using System;

abstract class Character
{
    private static string CHARACTER_TYPE;
    protected bool vulnerable;
    protected Character(string characterType)
    {
        CHARACTER_TYPE = characterType;
        vulnerable = false;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return vulnerable;
    }

    public override string ToString()
    {
        return "Character is a " + CHARACTER_TYPE;
    }
}

class Warrior : Character
{
    
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if(target.Vulnerable())
        {
            return 10;
        }
        else
        {
            return 6;
        }
    }

    public override bool Vulnerable()
    {
        return base.Vulnerable();  
    }
}

class Wizard : Character
{
    private bool prepareSpell;
    public Wizard() : base("Wizard")
    {
        prepareSpell = false;
    }

    public override int DamagePoints(Character target)
    {
        if (prepareSpell)
        {
            return 12;
        }
        else
        {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        prepareSpell = true;
    }

    public override bool Vulnerable()
    {
        return prepareSpell? false : true;
    }
}
