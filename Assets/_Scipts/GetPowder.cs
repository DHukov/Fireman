using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class GetScore : MonoBehaviour
{
    [SerializeField]
    Temperature_Changer temp;
    [SerializeField]
    private TextMeshProUGUI localText;

    void Update()
    {
        localText.text = temp.current_termometr_temperature.ToString();

    }
}
 