using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BPGameManager : MonoBehaviour
{
    [SerializeField] int numPlayers;
    [SerializeField] int maxGoals;
    
    [SerializeField] int goalsPC = 0;
    [SerializeField] int goalsPlayer = 0;

    [SerializeField] Text[] labels;

    [SerializeField] GameObject losePanel;
    [SerializeField] GameObject winPanel;


    void Start()
    {
        maxGoals = FindObjectOfType<GameData>().maxGoals;
        numPlayers = FindObjectOfType<GameData>().numPlayers;


        labels[0].text = "Cantidad de jugadores\n" + numPlayers.ToString();
        labels[1].text = "Goles para ganar\n" + maxGoals.ToString();

    }

    public void UpdateScore(string aux)
    {
        if (aux=="GoalPc")
        {
            goalsPC += 1;

        } else if (aux=="GoalPlayer")
        {
            goalsPlayer += 1;
        }

        labels[2].text = goalsPlayer.ToString() + "   -   " + goalsPC.ToString();


        if (goalsPlayer>=maxGoals)
        {
            winPanel.SetActive(true);
        } 
        
        else if (goalsPC>=maxGoals)
        {
            losePanel.SetActive(true);
        }

    }
}
