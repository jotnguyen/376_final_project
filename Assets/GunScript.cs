using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    private Vector3 zAngle;
    private float angle = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        mousePos.z = 0f;

        // Gun following mouse
        // Set ray length to 1
        Vector3 aimDirection = (mousePos - transform.position).normalized;
        // How much of an angle between positive x axis and ray to point x y
        angle = (Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg) - 90;
        zAngle = new Vector3(0, 0, angle);
        // 3 angles that describe orientation of rigid body
        transform.eulerAngles = zAngle;
    }
}
