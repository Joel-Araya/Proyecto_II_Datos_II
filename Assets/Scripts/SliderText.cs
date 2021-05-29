using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderText : MonoBehaviour
{

    [SerializeField] Slider slider;
    [SerializeField] Text text;
    [SerializeField] string typeOfValue;

    [SerializeField] int maxGoals = 5;
    [SerializeField] int numPlayers = 10;
    [SerializeField] int countParts = 9;

    [SerializeField] GameData aux;

    public void Start()
    {
        aux = FindObjectOfType<GameData>();
    }


    public void setValueOnText()
    {
        int value = (int)slider.value;


        if (typeOfValue == "numPlayers" && value % 2 == 1)
        {
            value--;
        }


        if(typeOfValue == "numPlayers")
        {
            aux.numPlayers = value;            

        } else if (typeOfValue == "maxGoals")
        {
            aux.maxGoals = value;

        } else if (typeOfValue == "countParts") 
        {
            aux.countParts = value;

        }

        text.text = value.ToString();
    }
}
