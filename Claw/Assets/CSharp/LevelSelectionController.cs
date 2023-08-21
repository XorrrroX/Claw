using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionController : MonoBehaviour
{
    public void SelectLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
