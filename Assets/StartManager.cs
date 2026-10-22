using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{

    private void Awake()
    {
        // 초기화
        if (KeepCanvas.instance != null)
        {
            Destroy(KeepCanvas.instance.gameObject);
        }
        if (KeepCanvas.instance != null)
        {
            Destroy(KeepCamera.instance.gameObject);
        }
        if (KeepCanvas.instance != null)
        {
            Destroy(KeepSoundManager.instance.gameObject);
        }        
    }


    public void ChangeScene() // Start씬의 StartButton 클릭시 호출
    {
        SceneManager.LoadScene("Lobby_GameScene"); // 로비씬 입장
    }
}