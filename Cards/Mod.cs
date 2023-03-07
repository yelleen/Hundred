 class Mod : Card
{
    private int divisor;
    public Mod(int d, string st)
    {
        number = 0;
        skill = Skill.MOD;
        state = st;
        divisor = d;
        isCalced = false;
    }
    public override int GetNumber()
    {
        return 0;
    }
    public override void SkillEffect(Card c)
    {
        Calc.SetCount(c.GetNumber() % divisor);
    }
    public override void UseCard()
    {
        Calc.BufferShift(this);
        Calc.State = state;
        Calc.Previous.SkillEffect(Calc.Now);
    }
}
