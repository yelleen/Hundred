public static class Calc
{
    private static Card previous;
    private static Card now;
    private static int count = 0;
    private static string state;
    public static Card Previous
    {
        get { return previous; }
        set { ; }
    }
    public static Card Now
    {
        get { return now; }
        set { ; }
    }
    public static int Count
    {
        get { return count; }
        set { ; }
    }
    public static string State
    {
        get { return ""; }
        set { state = value; }
    }
    public static void BufferShift(Card card)
    {
        previous = now;
        now = card;
    }
    public static void SetCount(int num)
    {
        count += num;
    }
    public static bool CheckCount(bool isCalced)
    {
        return count % 5 == 0 && isCalced;
    }
}
