using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature_Changer : MonoBehaviour
{    
    [SerializeField] private GameObject[] zones;

    public float current_termometr_temperature; 
    bool no_touch;
    int i;
    public void Temp(float newtemp)
    {
        current_termometr_temperature = newtemp;
    }

    public void Update()
    {
        if (!no_touch)
        {
            if (current_termometr_temperature > 0)
                current_termometr_temperature--;
            else if (current_termometr_temperature == 0)
                current_termometr_temperature = 0;

            if (current_termometr_temperature < 0)
                current_termometr_temperature++;
            else if (current_termometr_temperature == 0)
                current_termometr_temperature = 0;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        no_touch = true;
        for (i = 0; i <= zones.Length - 1; i++)
        {
            if (other.gameObject == zones[i])
            {
                Debug.Log("zone" + zones[i]);

                if (other.tag == "Below 0")
                {
                    current_termometr_temperature--;
                    if (current_termometr_temperature <= zones[i].GetComponent<Temperature_Zone>().local_temperature)
                        current_termometr_temperature = zones[i].GetComponent<Temperature_Zone>().local_temperature;
                }

                if (other.tag == "Above 0")
                {
                    current_termometr_temperature++;
                     if (current_termometr_temperature >= zones[i].GetComponent<Temperature_Zone>().local_temperature)
                       current_termometr_temperature = zones[i].GetComponent<Temperature_Zone>().local_temperature;

                }
            }
        }
    }

    private void OnTriggerExit(Collider other) => no_touch = false;
}
