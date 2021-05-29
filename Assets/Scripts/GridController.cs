using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [SerializeField] float xStart, yStart;
    [SerializeField] int colunmLenght, rowLenght;
    [SerializeField] float xSpace, ySpace;

    [SerializeField] GameObject prefabRed;
    [SerializeField] GameObject prefabBlue;
    [SerializeField] GameObject padre;


    [SerializeField] Vector3[,] positions;
    [SerializeField] int[,] positionsAux;

    [SerializeField] int numPlayer;

    RectTransform rectTransform;


    void Start()
    {

        positions = new Vector3[colunmLenght, rowLenght];
        positionsAux = new int[colunmLenght, rowLenght];
        numPlayer = FindObjectOfType<GameData>().numPlayers;

        for (int i = 0; i < colunmLenght; i++)
        {
            for(int j = 0; j<rowLenght; j++)
            {

                positions[i, j] =  new Vector3(xStart + (xSpace * (i % colunmLenght)), yStart + (ySpace * (j % colunmLenght)));
                positionsAux[i, j] = 0;
                //Debug.Log("Posicion [" + i + "," + j + "], Pos X = " + positions[i, j].x + ", Pos Y = " + positions[i, j].y);
            }
        }


        //for(int i = 0; i<colunmLenght*rowLenght; i++)


        for (int i = 0; i<numPlayer; i++)
        {
            int x,y;
            //Debug.Log("Iteración " + (i+1) + ":");

            if (i<numPlayer/2)
            {
                x = (int) Random.Range(1, colunmLenght / 2 - 1);
                y = (int) Random.Range(0, rowLenght);

                while (positionsAux[x, y] == 1)
                {
                    x = (int)Random.Range(1, colunmLenght / 2 - 1);
                    y = (int)Random.Range(0, rowLenght);
                }

                //Debug.Log("(" + x + ", " + y + ")");
                
                GameObject objHijo = Instantiate(prefabRed) as GameObject;
                objHijo.transform.SetParent(padre.transform);
                objHijo.transform.position = positions[x, y];
                positionsAux[x, y] = 1;

            }
            else
            {
                x = (int) Random.Range(colunmLenght / 2 + 1, colunmLenght - 1);
                y = (int) Random.Range(0, rowLenght);

                while (positionsAux[x, y] == 1)
                {
                    x = (int)Random.Range(colunmLenght / 2 + 1, colunmLenght - 1);
                    y = (int)Random.Range(0, rowLenght);
                }

                //Debug.Log("(" + x + ", " + y + ")");

                GameObject objHijo = Instantiate(prefabBlue) as GameObject;
                objHijo.transform.SetParent(padre.transform);
                objHijo.transform.position = positions[x, y];
                positionsAux[x, y] = 1;
            }



        }


        for(int i = 0; i<colunmLenght; i++)
        {
            for (int j = 0; j < rowLenght; j++)
            {
                //GameObject objHijo =  Instantiate(prefab, new Vector3(xStart + (xSpace * (i % colunmLenght)), yStart + (ySpace * (i / colunmLenght))), Quaternion.identity) as GameObject;

                //objHijo.transform.parent = padre.transform;
            }
        }
    }
}
