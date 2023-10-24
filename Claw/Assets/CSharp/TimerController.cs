using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float timer = 0f;

    private void Start()
    {
        timer = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        DisplayTimer();
    }

    private void DisplayTimer()
    {
        timerText.text = string.Format("Time: {0:F2}", timer);
    }
}

