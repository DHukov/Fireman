using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature_Zone : MonoBehaviour
{
    public static Temperature_Zone temp_zone { get; private set; }
    public float local_temperature;

    private void Update()
    {
        if(local_temperature >= 0)
        {
            gameObject.tag = "Above 0";
        }
        if (local_temperature <= 0)
        {
            gameObject.tag = "Below 0";
        }
    }
}
