using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaze_Fire : MonoBehaviour
{
    [SerializeField]
    Fire_Extinguishing RayCastHitData;
    [SerializeField]
    ParticleSystem FireEffect;
    [SerializeField]
    ParticleSystem SmokeEffect;

    public float timeToLiquidateFire = 5;
    public bool putOutTheFire;
    bool fireHasDone;

    private void Update()
    {
        Debug.Log(timeToLiquidateFire);
        if (RayCastHitData.hitInFire && !fireHasDone)
        {
            timeToLiquidateFire -= Time.deltaTime;
            if(timeToLiquidateFire <= 0)
            {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                timeToLiquidateFire = 0;
                fireHasDone = true;

            }
        }
        else if (!RayCastHitData.hitInFire && !fireHasDone)
        {
            timeToLiquidateFire += Time.deltaTime;
            if (timeToLiquidateFire >= 5)
                timeToLiquidateFire = 5;
        }

        FireEffect.startLifetime = Mathf.Lerp(0, 2.8f, timeToLiquidateFire * 0.2f);
        SmokeEffect.startLifetime = Mathf.Lerp(0, 7f, timeToLiquidateFire * 0.2f);



    }

}
