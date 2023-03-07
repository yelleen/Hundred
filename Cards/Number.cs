public class Number : Card
{
    public Number(int num)
    {
        number = num;
        skill = Skill.NORMAL;
        state = "Normal";
        isCalced = true;
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
        Calc.Previous.SkillEffect(Calc.Now);
    }
}
