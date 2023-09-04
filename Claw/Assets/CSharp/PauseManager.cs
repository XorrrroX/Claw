using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseManager : MonoBehaviour
{
    public GameObject pauseUI; // 暫停UI的參考
    private bool isPaused = false;

    private void Start()
    {
        pauseUI.SetActive(false);
        //Invoke("SetPauseUI", 0.00000001f);
    }
    private void SetPauseUI()
    {
        pauseUI.SetActive(false);
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // 暫停遊戲
            pauseUI.SetActive(true); // 顯示暫停UI
        }
        else
        {
            Time.timeScale = 1; // 恢復遊戲時間流逝
            pauseUI.SetActive(false); // 隱藏暫停UI
        }
    }

    public void RestartLevel()
    {
        // 重新載入當前場景
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }

    public void ReturnToLevelSelection()
    {
        // 切換到選擇關卡場景
        SceneManager.LoadScene("LevelSelection");
        Time.timeScale = 1;
    }
}
