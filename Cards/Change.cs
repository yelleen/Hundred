public class Change : Card
{
    public Change()
    {
        number = 0;
        skill = Skill.CHANGE;
        state = "Change";
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
