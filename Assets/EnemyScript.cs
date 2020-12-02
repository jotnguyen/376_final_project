using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 5;
    int MinDist = 2;




    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.position, MoveSpeed * Time.deltaTime);

    }
}
