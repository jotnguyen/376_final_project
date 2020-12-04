using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.position.x >= 8.4f) {}
            else
            {
                transform.position += new Vector3(0.03f, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.position.x <= -8.4f) {}
            else
            {
                transform.position -= new Vector3(0.03f, 0f, 0f);
            }
        }
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (transform.position.y >= 4.5f) {}
            else
            {
                transform.position += new Vector3(0f, 0.03f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (transform.position.y <= -4.5f) {}
            else
            {
                transform.position -= new Vector3(0f, 0.03f, 0f);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "Enemy")
        {
            var playerRenderer = this.gameObject.GetComponent<Renderer>();
            //playerRenderer.material.SetColor("_Color", Color.red);
            GameObject.Find("GameController").GetComponent<GameController>().HealthLoss();
        }
    }
}
