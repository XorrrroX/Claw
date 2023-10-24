using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class FinishManager : MonoBehaviour
{
    public TextMeshProUGUI finishTimeText;
    public TextMeshProUGUI timerText;
    public GameObject finishUI;

    private void Start()
    {
        finishUI.SetActive(false);
    }

    public void ShowFinishUI()
    {
        Time.timeScale = 0;
        finishUI.SetActive(true);
        finishTimeText.text = timerText.text;
    }

    public void RestartLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        Time.timeScale = 1;
        SceneManager.LoadScene(scene.name);
    }

    public void ReturnToLevelSelection()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelSelection");
    }
}
