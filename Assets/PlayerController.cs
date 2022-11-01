using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalSpeed = 2.0f;

    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        float z = horizontalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, 0, -z);
    }
}
