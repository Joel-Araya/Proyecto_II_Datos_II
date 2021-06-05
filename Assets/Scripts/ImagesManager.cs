using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ImagesManager : MonoBehaviour
{
    [SerializeField] int countParts;
    [SerializeField] GameObject padre;
    [SerializeField] Image auxChild;
    [SerializeField] Image original;
    [SerializeField] GridLayoutGroup gridImages;


    [SerializeField] string[] extensions = { "image files", "png,jpg,jpeg" };
    [SerializeField] GameObject buttonAddImages;


    void Start()
    {
        countParts = FindObjectOfType<GameData>().countParts;
        gridImages.constraintCount = countParts;
        float large = original.rectTransform.sizeDelta.x;
        gridImages.cellSize = new Vector2(large/countParts,large/countParts);

        

        for (int i = 0; i < countParts * countParts; i++)
        {
            Image objHijo = Instantiate(auxChild);
            objHijo.transform.SetParent(padre.transform);
            objHijo.rectTransform.localScale = new Vector2(1, 1);
        }


        for (int i= 0; i<countParts*countParts; i++)
        {
            if (i % 2 == 0)
            {
                ReadImage("Assets\\Imagenes\\xD.png", i);

            } else
            {
                ReadImage("Assets\\Imagenes\\Ball.png", i);
            }

        }


        //swapSprite(0, 1);

        for(int i = 0; i<countParts; i++)
        {
            //Debug.Log(gridImages.transform.GetChild(i).gameObject.GetInstanceID());

            //swapSprite(i, i+9);
        }

        ReadImage("src\\Genetic\\Images\\original.jpg");

        ReadAllImages();

    }

    public void ReadImage()
    {
        var path = EditorUtility.OpenFilePanelWithFilters("Selecciona una imagen", "", extensions);
        if (!File.Exists(path)) return;
        byte[] image = File.ReadAllBytes(path);
        Texture2D newTexture = new Texture2D(1,1);
        newTexture.LoadImage(image);
        Sprite sprite = Sprite.Create(newTexture, new Rect(0,0,newTexture.width, newTexture.height), new Vector2(0.5f,0.5f));
        original.sprite = sprite;

        buttonAddImages.SetActive(false);
    }    
    
    public void ReadImage(string path)
    {
        //path = EditorUtility.OpenFilePanelWithFilters("Selecciona una imagen", "", extensions);
        if (!File.Exists(path)) return;
        byte[] image = File.ReadAllBytes(path);
        Texture2D newTexture = new Texture2D(1,1);
        newTexture.LoadImage(image);
        Sprite sprite = Sprite.Create(newTexture, new Rect(0,0,newTexture.width, newTexture.height), new Vector2(0.5f,0.5f));
        original.sprite = sprite;
    }

    public void ReadAllImages()
    {
        int[] list = {5, 7, 8, 6, 4, 12, 3, 1, 9, 16, 14, 15, 11, 13, 2, 10};

        for (int i = 0; i<countParts*countParts; i++)
        {
            string path = "src\\Genetic\\Images\\" + list[i] + ".jpg" ;

            if (!File.Exists(path)) return;
            byte[] image = File.ReadAllBytes(path);
            Texture2D newTexture = new Texture2D(1, 1);
            newTexture.LoadImage(image);
            Sprite sprite = Sprite.Create(newTexture, new Rect(0, 0, newTexture.width, newTexture.height), new Vector2(0.5f, 0.5f));
            gridImages.transform.GetChild(i).gameObject.GetComponent<Image>().sprite = sprite;
        }
    }

    public void ReadImage(string path, int element)
    {
        //path = EditorUtility.OpenFilePanelWithFilters("Selecciona una imagen", "", extensions);


        if (!File.Exists(path)) return;
        byte[] image = File.ReadAllBytes(path);
        Texture2D newTexture = new Texture2D(1,1);
        newTexture.LoadImage(image);
        Sprite sprite = Sprite.Create(newTexture, new Rect(0,0,newTexture.width, newTexture.height), new Vector2(0.5f,0.5f));
        gridImages.transform.GetChild(element).gameObject.GetComponent<Image>().sprite = sprite;
    }

    public void swapSprite(int first, int last)
    {
        Sprite spriteAux = gridImages.transform.GetChild(first).gameObject.GetComponent<Image>().sprite;
        gridImages.transform.GetChild(first).gameObject.GetComponent<Image>().sprite = gridImages.transform.GetChild(last).gameObject.GetComponent<Image>().sprite;
        gridImages.transform.GetChild(last).gameObject.GetComponent<Image>().sprite = spriteAux;
    }

}
