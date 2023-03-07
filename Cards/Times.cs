public class Times : Card
{
    private int times;
    public Times(int t, string st)
    {
        number = 0;
        skill = Skill.TIMES;
        state = st;
        times = t;
        isCalced = false;
    }
    public override int GetNumber()
    {
        return 0;
    }
    public override void SkillEffect(Card c)
    {
        Calc.SetCount(c.GetNumber() * times);
    }
    public override void UseCard()
    {
        Calc.BufferShift(this);
        Calc.State = state;
        Calc.Previous.SkillEffect(Calc.Now);
    }
}
