using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
   public static Singleton Instance { get; private set; }
    public Temperature_Zone TemperatureZone { get; private set; }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        TemperatureZone = GetComponent<Temperature_Zone>();
    }
}
