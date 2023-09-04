using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAreaController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // 當玩家碰到死亡區域時
            PlayerFailed();
        }
    }

    private void PlayerFailed()
    {
        // 在這裡執行玩家失敗的相關操作
        Debug.Log("玩家失敗！重新開始關卡");

        // 重新載入當前場景
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
