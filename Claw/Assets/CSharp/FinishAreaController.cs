using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishAreaController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 當玩家進入觸發區域時
            PlayerPassedLevel();
        }
    }

    private void PlayerPassedLevel()
    {
        // 在這裡執行玩家通過關卡的相關操作
        Debug.Log("玩家通過了關卡！");
    }
}
