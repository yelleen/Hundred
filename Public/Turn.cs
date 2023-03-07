using UnityEngine;
using System.Collections.Generic;

public class Turn : MonoBehaviour
{
    #region TurnFields
    private int turn;
    public List<GameObject> players = new List<GameObject>(); //TODO public -> private
    private int randomPlus;
    public Pack main; //TODO public -> private
    public Pack used; //TODO public -> private
    #endregion
    #region Debug
    public int n; //TODO delete this
    #endregion
    [ContextMenu("SetPlayer")]
    public void SetPlayers()
    {
        for (int i = 1; i <= n; i++)
        {
            GameObject obj = new GameObject("Player" + i);
            //Player tmp = new Player(i);
            players.Add(obj);
            obj.AddComponent<Player>();
        }
    }
    [ContextMenu("SetOrder")]
    public void SetOrder()
    {
        for (int i = 0; i < players.Count; i++)
        {
            players[i].GetComponent<Player>().Order = i + 1;
        }
    }
    void Start()
    {
        for (int i = 1; i < 30; i++)
        {
            if (i % 5 != 0)
            {
                if (i < 10)
                    for (int j = 0; j < 3; j++)
                        main.AddCard(new Number(i));
                else if (i < 30 && (i % 11 != 0))
                    for(int j = 0; j < 2; j++)
                        main.AddCard(new Number(i));
                else
                    main.AddCard(new Number(i));
            }
        }

    }
}
