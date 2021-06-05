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
    }

    public void BotonPuzzle()
    {
        SceneManager.LoadScene("GeneticPuzzle");
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


