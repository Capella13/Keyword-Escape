using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_7_Room3 : MonoBehaviour
{
    public bool selected = false;

    //###########
    AudioSource audioSource;
    [SerializeField] AudioClip button;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()   // 계속 정답인지 체크해야하므로 Update() 메서드 사용
    {
        if (FindObjectOfType<KeypadDirector_Room3>().isOpen)    // 만일 정답이라면 = 문이 열렸다면
        {
            gameObject.SetActive(false);    // 콜라이더 겹칩 방지로 인해 모습 비활성화
        }
    }

    private void OnMouseDown()  // 7번 키패드가 클릭되었을 때 호출되는 메서드
    {
        if (FindObjectOfType<KeypadDirector_Room3>().isInput) // 현재 KeypadDirector가 입력 상태(true)인지 확인
        {
            selected = true; // 선택이 되었음을 표시

            //###########
            audioSource.PlayOneShot(button);
        }
    }
}
