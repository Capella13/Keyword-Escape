using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour     // Alphabet_Puzzle 오브젝트의 자식인 Up 오브젝트의 스크립트
{
    public bool selected = false;   // 현재 선택 여부를 확인하는 플래그 변수. false으로 초기화 하였다.

    private void OnMouseDown()  // Up 오브젝트를 선택했을 때
    {
        selected = true;    // 현재 선택되었다는 의미에서 true로 변경
    }
}
