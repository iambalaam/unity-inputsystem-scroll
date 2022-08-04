using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScrollReporter : MonoBehaviour
{
    private TextMeshProUGUI tmPro;
    void Start()
    {
        tmPro = GetComponent<TextMeshProUGUI>();
    }

    void LateUpdate()
    {
        float scroll = Mouse.current.scroll.ReadUnprocessedValue().y;
        if (scroll != 0)
        { 
            tmPro.text = scroll.ToString("n4");
        }

    }
}
