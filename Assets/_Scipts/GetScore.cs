using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class GetPowder : MonoBehaviour
{
    [SerializeField]
    Fire_Extinguishing RemainingTime;
    [SerializeField]
    private TextMeshProUGUI localText;

    void Update()
    {
        localText.text = Mathf.Round(RemainingTime.secondsForUse).ToString();

    }
}
 