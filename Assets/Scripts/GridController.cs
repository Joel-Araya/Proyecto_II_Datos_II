using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GridController : MonoBehaviour
{
    [SerializeField] float xStart, yStart;
    [SerializeField] int colunmLenght, rowLenght;
    [SerializeField] float xSpace, ySpace;

    [SerializeField] GameObject prefabRed;
    [SerializeField] GameObject prefabBlue;
    [SerializeField] GameObject prefabMark;

    [SerializeField] GameObject padre;
    [SerializeField] GameObject padreCampo;


    [SerializeField] Vector3[,] positions;
    [SerializeField] int[,] positionsAux;
    [SerializeField] GameObject[,] positionsMarks;

    [SerializeField] int numPlayer;

    RectTransform rectTransform;

    [SerializeField] BallMovement ball;
    [SerializeField] int ballPositionX, ballPositionY;

    [SerializeField] List<Vector2> vectoresPosition = new List<Vector2>();
    [SerializeField] List<int> integers = new List<int>();

    [SerializeField] string textToSend = "";

    [SerializeField] string pathTxtBp = "Bp.txt"; 

    void Start()
    {

        positions = new Vector3[colunmLenght, rowLenght];
        positionsAux = new int[colunmLenght, rowLenght];
        positionsMarks = new GameObject[colunmLenght, rowLenght];

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

        setMarks();


        UpdateTextToSend();


        vectoresPosition.Add(new Vector2(3,3));
        vectoresPosition.Add(new Vector2(3,4));
        vectoresPosition.Add(new Vector2(3,5));
        vectoresPosition.Add(new Vector2(4,5));
        vectoresPosition.Add(new Vector2(5,5));

        //showPath(vectoresPosition);

        integers.Add(3);
        integers.Add(3);
        integers.Add(3);
        integers.Add(4);
        integers.Add(3);
        integers.Add(5);
        integers.Add(4);
        integers.Add(5);
        integers.Add(5);
        integers.Add(5);

        showPath(integers);
    }

    public void setMarks()
    {
        for (int x = 0; x < colunmLenght; x++)
        {
            for (int y = 0; y < rowLenght; y++)
            {
                GameObject objHijo = Instantiate(prefabMark) as GameObject;
                objHijo.transform.SetParent(padreCampo.transform);
                objHijo.transform.position = positions[x, y];
                objHijo.SetActive(false);
                positionsMarks[x, y] = objHijo;
            }
        }
    }

    public void hideMarks()
    {
        for (int x = 0; x < colunmLenght; x++)
        {
            for (int y = 0; y < rowLenght; y++)
            {
                positionsMarks[x, y].SetActive(false);

            }
        }
    }
    
    public void showPath(List<Vector2> posiciones)
    {
        for (int i = 0; i < posiciones.Count; i++)
        {
            positionsMarks[(int)posiciones[i].x, (int)posiciones[i].y].SetActive(true);
        }
    }



    public void showPath(List<int> integers)
    {
        for (int i = 0; i < integers.Count-1; i+=2)
        {
            positionsMarks[integers[i], integers[i+1]].SetActive(true);
        }
    }

    public  void UpdateTextToSend() {
        UpdateBallPosition();
        textToSend = "-" + ballPositionX.ToString() + "," + ballPositionY.ToString() + "-";
        textToSend += "{";

        for (int i = 0; i < colunmLenght; i++)
        {
            textToSend += "{";

            for(int j = 0; j<rowLenght; j++)
            {
                if(j == 0)
                {
                    textToSend += positionsAux[i,j].ToString();
                }

                textToSend += "," + positionsAux[i,j].ToString();
            
            }
            
            textToSend += "}";
            
            if(i < colunmLenght - 1)
            {
                textToSend += ",";
            }

        }
        textToSend += "}";
        Debug.Log("SE ESTA ENVIANDO TEXTO");

        //StreamWriter doc = File.AppendAllLines(pathTxtBp);


        //File.WriteAllLines(pathTxtBp, textToSend);
        //FindObjectOfType<GameData>().enviar(textToSend);
    }

    public void updateFile(){
        UpdateTextToSend();
        StreamWriter fileTxt = new StreamWriter(pathTxtBp, true);
        fileTxt.WriteLine(textToSend);
        fileTxt.Close();
        createTxt();
    }
    public void createTxt(){
        StreamWriter fileTxt;
        fileTxt = File.CreateText(pathTxtBp);
        fileTxt.WriteLine(textToSend);
        fileTxt.Close();
    }

    public void UpdateBallPosition(){
                
        for (int i = 0; i < colunmLenght-1; i++)
        {
            for (int j = 0; j < rowLenght-1; j++)
            {
                if(positions[i,j].x < ball.GetComponent<Rigidbody2D>().position.x && ball.GetComponent<Rigidbody2D>().position.x < positions[i+1, j].x)
                {
                    ballPositionX = i;
                }

                if(positions[i,j].y < ball.GetComponent<Rigidbody2D>().position.y && ball.GetComponent<Rigidbody2D>().position.y < positions[i, j+1].y)
                {
                    ballPositionY = j;
                }
            }
        }

        
    }
    

    public void Update()
    {

        UpdateBallPosition();
    }
}
