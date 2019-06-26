using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    float rotSpeed = 20;

    private void OnMouseDrag()
    {
        //float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        //float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        //transform.Rotate(new Vector3(rotY, -rotX, 0), Space.World);
        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0)*rotSpeed, Space.World);

    }
}
