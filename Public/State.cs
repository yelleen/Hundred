public enum Skill { NORMAL, TIMES, MOD, PLUS, CHANGE, REVERSE }
public class State
{
    private static Skill state;
    public static void SetState(Skill sk)
    {
        state = sk;
    }
}
