using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCountManager : MonoBehaviour
{
    [SerializeField] int playerCount;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    public void SetPlayerCount(int players)
    {
        playerCount = players;
    }

    public int GetPlayerCount()
    {
        return playerCount;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
