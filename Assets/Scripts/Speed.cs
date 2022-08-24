using UnityEngine;
using TMPro;

public class Speed : MonoBehaviour
{
    public TextMeshProUGUI speedText;
    public Rigidbody rb;

    void Update()
    {
        var kph = (rb.velocity.magnitude * 3.6).ToString("0");
        speedText.text = kph;
    }
}
