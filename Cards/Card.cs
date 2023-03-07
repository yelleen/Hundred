using UnityEngine;

public abstract class Card : MonoBehaviour
{
    protected int number;
    protected Skill skill;
    protected string state;
    protected bool isCalced;
    public abstract int GetNumber();
    public abstract void SkillEffect(Card c);
    public abstract void UseCard();
}
