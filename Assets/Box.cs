using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private int health = 3;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            switch (health)
            {
                case 3:
                    health--;
                    GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0f, 1f);
                    Destroy(coll.gameObject);
                    break;
                case 2:
                    health--;
                    GetComponent<SpriteRenderer>().color = Color.red;
                    Destroy(coll.gameObject);
                    break;
                default:
                    health--;
                    Destroy(coll.gameObject);
                    Destroy(gameObject);
                    GameObject.Find("GameController").GetComponent<GameController>().BoxDestroyed();
                    break;
            }
        }
    }
}
