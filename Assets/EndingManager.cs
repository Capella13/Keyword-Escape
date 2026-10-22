using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    [SerializeField] AudioClip clear; // 문 열린 오브젝트를 클릭했을 때 재생될 오디오 클립
    AudioSource audioSource;    // 오디오 소스 컴포넌트를 찾기 위한 필드

    private void Start()
    {
        this.audioSource = GetComponent<AudioSource>();  // 오디오 소스 컴포넌트 찾기
    }

    private void OnMouseDown() // 문을 클릭하면 실행되는 메서드
    {
        audioSource.PlayOneShot(clear); // 열리는 소리 재생
        Invoke("ChangeScene", 2f);
    }

    public void ChangeScene() // Start씬의 StartButton 클릭시 호출
    {
        SceneManager.LoadScene("StartScene"); // 로비씬 입장
    }
}
