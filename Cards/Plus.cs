class Plus : Card
{
    private int plus;
    public Plus(int p, string st)
    {
        number = 0;
        skill = Skill.PLUS;
        state = st;
        plus = p;
        isCalced = false;
    }
    public override int GetNumber()
    {
        return 0;
    }
    public override void SkillEffect(Card c)
    {
        Calc.SetCount(c.GetNumber() + plus);
    }
    public override void UseCard()
    {
        Calc.BufferShift(this);
        Calc.State = state;
        Calc.Previous.SkillEffect(Calc.Now);
    }
}
