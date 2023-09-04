using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LevelUIController : MonoBehaviour
{
    public Text time;
    public void SetTime(float timer)
    {
        time.text = timer.ToString();
    }
}
