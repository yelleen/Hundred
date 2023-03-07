using System.Collections.Generic;
using UnityEngine;

public class Pack : MonoBehaviour
{
    public List<Card> pack; //TODO public -> private
    public Pack()
    {
        pack = new List<Card>();
        pack.Clear();
    }
    public void AddCard(Card card)
    {
        pack.Add(card);
    }
    [ContextMenu("Shuffle")]
    public void Shuffle()
    {
        int j = pack.Count;
        List<Card> tmp = new List<Card>();
        for(int i = 0; i < j; i++)
        {
            int k = Random.Range(0, pack.Count);
            tmp.Add(pack[k]);
            pack.RemoveAt(k);
        }
        pack = tmp;
    }
}
