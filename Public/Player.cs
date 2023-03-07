using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public new string name; //TODO public -> private
    public int order; //TODO public -> private
    private int cardCount;
    private int life;
    private List<Card> cards = new List<Card>();
    public int Order
    {
        get { return order; }
        set { order = value > 0 ? value : 0; }
    }
    public int CardCount
    {
        get { return cardCount; }
        set
        {
            cardCount = value > 3 ? 3 : cardCount;
            cardCount = cardCount < 0 ? 0 : cardCount;
        }
    }
    public Player(string n)
    {
        name = n;
        order = 0;
        life = 3;
        cardCount = 3;
        cards.Clear();
        cards.Capacity = 3;
    }
    public Player(int n)
    {
        name = "test " + n.ToString();
        order = 0;
        life = 3;
        cardCount = 3;
        cards.Clear();
        cards.Capacity = 3;
    }
    public void LossLife()
    {
        life--;
    }
}
