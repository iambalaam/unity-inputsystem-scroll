using TMPro;
using UnityEngine;

public class ScrollReporter : MonoBehaviour
{
    private TextMeshProUGUI tmPro;
    void Start()
    {
        tmPro = GetComponent<TextMeshProUGUI>();
    }

    void LateUpdate()
    {
        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");
        if (scroll != 0)
        { 
            tmPro.text = scroll.ToString("n4");
        }

    }
}
