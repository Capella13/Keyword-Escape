using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenCabinet : MonoBehaviour
{
    [SerializeField] GameObject openDoor; // 문이 열려 있는 오브젝트
    [SerializeField] GameObject Note;   // 노트 오브젝트

    [SerializeField] AudioClip open; // 열렸을 때 재생될 오디오 클립
    AudioSource audioSource;    // 오디오 소스 컴포넌트를 찾기 위한 필드

    private void Start()
    {
        this.audioSource = GetComponent<AudioSource>();  // 오디오 소스 컴포넌트 찾기
    }

    private void OnMouseDown()
    {
        this.openDoor.SetActive(true); // 문이 열려 있는 오브젝트 활성화
        this.Note.SetActive(true); // 노트 오브젝트 활성화
        audioSource.PlayOneShot(open); // 열리는 소리 재생
    }
}
