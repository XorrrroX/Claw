using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText; // TextMeshPro 元件的參考

    private float timer = 0f; // 計時器變數，初始化為 0

    private void Start()
    {
        // 重置計時器並開始計時
        timer = 0f;
    }

    private void Update()
    {
        // 更新計時器
        timer += Time.deltaTime;

        // 將計時器的值顯示在 TextMeshPro 文字框上
        DisplayTimer();
    }

    private void DisplayTimer()
    {
        // 使用 string.Format 格式化文字內容，只取到小數點後兩位
        timerText.text = string.Format("Time: {0:F2}", timer);
    }
}

