using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{

    public GameObject cursor;
    private Vector3 mouseVector;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseVector = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
        // wherever the mouse is at set it up
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(mouseVector);
        cursor.transform.position = new Vector2(target.x, target.y); 
    }
}
