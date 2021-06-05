using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GetFile : MonoBehaviour
{
    [SerializeField] Image img;
    [SerializeField] string[] extensions = { "image files", "png,jpg,jpeg" };

    [ContextMenu("ReadImage")]

    public void OnMouseDown()
    {
        Debug.Log("Imagen xD");
        ReadImage();
    }

    public void ReadImage()
    {
        var path = EditorUtility.OpenFilePanelWithFilters("Selecciona una imagen", "", extensions);
        if (!File.Exists(path)) return;
        byte[] image = File.ReadAllBytes(path);
        Texture2D newTexture = new Texture2D(1, 1);
        newTexture.LoadImage(image);
        Sprite sprite = Sprite.Create(newTexture, new Rect(0, 0, newTexture.width, newTexture.height), new Vector2(0.5f, 0.5f));
        img.sprite = sprite;
    }
}
