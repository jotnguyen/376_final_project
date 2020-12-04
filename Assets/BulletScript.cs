using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Vector3 screenPos;
    private GameController gameController;

    void Start() 
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void Update()
    {
        screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.y < 0 || screenPos.x > Screen.width
            || screenPos.y > Screen.height)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(Collision.gameObject);
            gameController.ScorePoint();
        }

        else if (Collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        
    }
}
