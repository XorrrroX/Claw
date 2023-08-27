using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LevelUIController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTime(float timer)
    {
        time.text = timer.ToString();
    }
}
