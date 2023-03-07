public class Reverse : Card
{
    public Reverse()
    {
        number = 0;
        skill = Skill.REVERSE;
        state = "Reverse";
        isCalced = false;
    }
    public override int GetNumber()
    {
        return number;
    }
    public override void SkillEffect(Card c)
    {
        Calc.SetCount(c.GetNumber());
    }
    public override void UseCard()
    {
        Calc.BufferShift(this);
        Calc.State = state;
    }
}
