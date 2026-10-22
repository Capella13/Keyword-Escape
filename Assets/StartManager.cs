using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public void ChangeScene() // Start씬의 StartButton 클릭시 호출
    {
        SceneManager.LoadScene("Lobby_GameScene"); // 로비씬 입장
    }
}
