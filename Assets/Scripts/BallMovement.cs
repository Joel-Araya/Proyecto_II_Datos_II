using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class BallMovement : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private RectTransform rectTransform;

    [SerializeField] Slider strengh;
    [SerializeField] bool turn=false;
    public bool touch;

    [SerializeField] float time = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rectTransform = GetComponent<RectTransform>();
        rectTransform.SetPositionAndRotation(new Vector2(0,0), rectTransform.rotation);
        rb2d.velocity = new Vector2(0.05f,0.05f);
    }


    public void OnMouseDown()
    {
        //rb2d.velocity = new Vector2(10,2);

    }

    public void OnMouseDrag()
    {
        if ((rb2d.velocity.x == 0 && rb2d.velocity.x == 0) || true)
        {
            if (turn)
            {
                Vector2 MousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

                float xAux = (rectTransform.position.x - MousePosition.x);
                float yAux = (rectTransform.position.y - MousePosition.y);

                if (xAux < -10) { xAux = -10; }
                if (xAux > 10) { xAux = 10; }
                if (yAux < -10) { yAux = -10; }
                if (yAux > 10) { yAux = 10; }

                float magnitude = 3 * (new Vector2(xAux, yAux)).magnitude;
                strengh.value = magnitude;

            }
        }

    }

    public void turnComputer()
    {
        if (!turn)
        {
            //Debug.Log("Turn PC");
            rb2d.velocity = 1 * (new Vector2(-10, 0));

        }
    }


    public void nextTurn()
    {
        if(turn){
            turn=true;

        } else if(!turn){
            turnComputer();
            turn=true;
        }
    }

    public void OnMouseUp()
    {
        time = 0;

        if (turn)
        {
            Vector2 MousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //Debug.Log("Mouse X " + MousePosition.x + ", Mouse Y " + MousePosition.y);
            //Debug.Log("Bola X " + MousePosition.x + ", Bola Y " + MousePosition.y);

            float xAux = (rectTransform.position.x - MousePosition.x);
            float yAux = (rectTransform.position.y - MousePosition.y);

            if (xAux < -10) { xAux = -10; }
            if (xAux > 10) { xAux = 10; }
            if (yAux < -10) { yAux = -10; }
            if (yAux > 10) { yAux = 10; }

            rb2d.velocity = 3 * (new Vector2(xAux, yAux));
            strengh.value = 0;

            turn = false;
        }   
    }

    void Update()
    {

        rb2d.velocity = (new Vector2((float)0.99*rb2d.velocity.x, (float)0.99 * rb2d.velocity.y));
        time += Time.deltaTime;

    }
}
