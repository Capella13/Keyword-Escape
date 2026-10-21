using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeOpen : MonoBehaviour
{
    [SerializeField] GameObject openDoor;  // Safe 문 열려있는 모습 오브젝트

    AudioSource audioSource;    // 오디오 소스 컴포넌트를 찾기 위한 필드
    [SerializeField] AudioClip open;   // 문 열릴 때 나는 소리

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  // 오디오 소스 컴포넌트 찾기
    }

    private void OnMouseDown()
    {
        this.openDoor.SetActive(true);  // Safe 문 열려있는 모습 오브젝트 활성화
        audioSource.PlayOneShot(open);  // 문 열릴 때 나는 소리 재생
    }
}
