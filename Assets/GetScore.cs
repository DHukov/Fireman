using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class GetScore : MonoBehaviour
{
    [SerializeField]
    Temperature_Changer tempo;
    [SerializeField]
    private TextMeshProUGUI localText;

    void Update()
    {
        localText.text = tempo.current_termometr_temperature.ToString();

    }
}
 