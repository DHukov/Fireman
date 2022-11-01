using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Extinguishing : MonoBehaviour
{
    [SerializeField]
    ParticleSystem particleControl;
    float distanceOfExtinguishing = 3;
    public bool isPressed;
    public float secondsForUse;
    public bool hitInFire;

    private void Awake()
    {
        particleControl.startLifetime = 0;
    }
    private void Update()
    {
        PressSpaceToRxtinguishing();   
    }

    private void RaycastFindFireMethode()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distanceOfExtinguishing))
        {
            Debug.Log("Hit that: " + hit.transform.tag);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            if (hit.transform.tag == "Bottom Fire")
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                hitInFire = true;
            }
            else
                hitInFire = false;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distanceOfExtinguishing, Color.white);
            hitInFire = false;
        }
    }

    private void PressSpaceToRxtinguishing()
    {
        if (Input.GetKeyDown(KeyCode.Space)) isPressed = true;
        else if (Input.GetKeyUp(KeyCode.Space)) isPressed = false;

        if (isPressed && secondsForUse >= 0)
        {
            RaycastFindFireMethode();
            secondsForUse -= Time.deltaTime;
            particleControl.startLifetime = 1;
        }
        else if (!isPressed || secondsForUse <= 0)
        {
            hitInFire = false;
            isPressed = false;
            particleControl.startLifetime = 0;
        }
    }
}
