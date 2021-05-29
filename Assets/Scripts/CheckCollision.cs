using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Top") || collision.CompareTag("Down"))
        {
            GetComponentInParent<Rigidbody2D>().velocity = new Vector2(GetComponentInParent<Rigidbody2D>().velocity.x, -GetComponentInParent<Rigidbody2D>().velocity.y);
        }

        if (collision.CompareTag("Right") || collision.CompareTag("Left"))
        {
            
            GetComponentInParent<Rigidbody2D>().velocity = new Vector2(-GetComponentInParent<Rigidbody2D>().velocity.x, GetComponentInParent<Rigidbody2D>().velocity.y);

        }

        if (collision.CompareTag("Right Goal"))
        {

            FindObjectOfType<BPGameManager>().SendMessage("UpdateScore", "GoalPlayer");
            GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponentInParent<RectTransform>().SetPositionAndRotation( new Vector2(0, 0), GetComponentInParent<RectTransform>().rotation);
        }

        if (collision.CompareTag("Left Goal"))
        {

            FindObjectOfType<BPGameManager>().SendMessage("UpdateScore", "GoalPc");
            GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponentInParent<RectTransform>().SetPositionAndRotation(new Vector2(0, 0), GetComponentInParent<RectTransform>().rotation);
        }
    }
}
