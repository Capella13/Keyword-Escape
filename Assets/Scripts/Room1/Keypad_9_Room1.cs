using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_9_Room1 : MonoBehaviour
{
    public bool selected = false;

    private void OnMouseDown()  // 9번 키패드가 클릭되었을 때 호출되는 메서드
    {
        if (FindObjectOfType<KeypadDirector_Room1>().isInput) // 현재 KeypadDirector가 입력 상태(true)인지 확인
        {
            selected = true; // 선택이 되었음을 표시
        }
    }
}
