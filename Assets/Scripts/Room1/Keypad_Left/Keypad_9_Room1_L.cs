using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_9_Room1_L : MonoBehaviour
{
    public bool selected = false;

    //###########
    AudioSource audioSource;
    [SerializeField] AudioClip button;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()  // 9번 키패드가 클릭되었을 때 호출되는 메서드
    {
        if (FindObjectOfType<KeypadDirector_Room1_L>().isInput) // 현재 KeypadDirector가 입력 상태(true)인지 확인
        {
            selected = true; // 선택이 되었음을 표시

            audioSource.PlayOneShot(button); // 소리 재생
        }
    }
}
