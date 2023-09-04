using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        // 切換到選擇關卡場景（Assuming "LevelSelection" is the scene name）
        SceneManager.LoadScene("LevelSelection");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
