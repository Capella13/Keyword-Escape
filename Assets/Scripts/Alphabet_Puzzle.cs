using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alphabet_Puzzle : MonoBehaviour
{
    [SerializeField] Sprite[] alphabets;    // 알파벳 스프라이트 이미지 배열 (26개)
    [SerializeField] GameObject alphabet;   // 선택된 알파벳이 출력되는 오브젝트
    [SerializeField] GameObject up;         // Alphabet_Puzzle 오브젝트가 가지고 있는 Up 오브젝트
    [SerializeField] GameObject down;       // Alphabet_Puzzle 오브젝트가 가지고 있는 Down 오브젝트

    int now = 0;    // 현재 출력되는 알파벳 요소(인덱스)값 초기화

    void Update()
    {
        if (up.GetComponent<Up>().selected)    // Up 버튼이 선택된 경우
        {
            up.GetComponent<Up>().selected = false;  // Up 버튼이 선택되었던 것을 다시 false로 돌려놓기

            this.now++; // 현재 출력되는 알파벳 요소(인덱스)값을 다음 요소(인덱스)값으로 변경

            if (this.now == alphabets.Length)   // 만일 현재 순서가 26이 된다면
            {
                now = 0;    // 현재 순서를 0으로 초기화하기
            }

            alphabet.GetComponent<SpriteRenderer>().sprite = alphabets[now];
            // 현재 알파벳을 다음 알파벳으로 바꾸기
        }

        if (down.GetComponent<Down>().selected)    // Down 버튼이 선택된 경우
        {
            down.GetComponent<Down>().selected = false;  // Down 버튼이 선택되었던 것을 다시 false로 돌려놓기

            this.now--; // 현재 출력되는 알파벳 요소(인덱스)값을 이전 요소(인덱스)값으로 변경

            if (this.now <= 0)   // 만일 현재 순서가 0번 인덱스 이전 문자라면
            {
                now = 25;    // 현재 순서를 마지막 문자(Z)로 바꾸기
            }

            alphabet.GetComponent<SpriteRenderer>().sprite = alphabets[now];
            // 현재 알파벳을 이전 알파벳으로 바꾸기
        }
    }
}
