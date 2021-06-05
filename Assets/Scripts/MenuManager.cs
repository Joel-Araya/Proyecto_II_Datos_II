using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{

    public void BotonBPGame()
    {
        SceneManager.LoadScene("BPGame");
        FindObjectOfType<GameData>().state=1;
        FindObjectOfType<GameData>().enviar("1");
    }

    public void BotonPuzzle()
    {
        SceneManager.LoadScene("GeneticPuzzle");
        FindObjectOfType<GameData>().state=2;
        FindObjectOfType<GameData>().enviar("2");
    }

    public void BotonMenu()
    {
        Debug.Log("Menu");
        SceneManager.LoadScene("Menu");
    }
    public void BotonQuit()
    {
        Debug.Log("Se ha cerrado la aplicación");
        Application.Quit();
    }


    
}


