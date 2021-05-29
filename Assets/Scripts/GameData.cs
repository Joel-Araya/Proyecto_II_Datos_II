using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{

    public int maxGoals = 5;
    public int numPlayers = 10;
    public int countParts = 9;

    public static GameData gameData;

    public void Awake()
    {
        if (gameData == null)
        {
            gameData = this;
            DontDestroyOnLoad(gameObject);
        } 
        
        else if (gameData != this)
        {
            Destroy(gameObject);
        }
    }


    int getMaxGoals()
    {
        return maxGoals;
    }
    
    int getNumPlayers()
    {
        return numPlayers;
    }
    
    int getCountParts()
    {
        return countParts;
    }    

    void setCountParts(int value)
    {
        countParts = value;
    }    

    void setNumPlayers(int value)
    {
        numPlayers = value;
    }    

    void setMaxGoals(int value)
    {
        maxGoals = value;
    }


}
