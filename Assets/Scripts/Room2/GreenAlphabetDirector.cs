using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAlphabetDirector : MonoBehaviour
{
    [SerializeField] GameObject[] selectAlphabets;  // 6개의 Alphabet_Puzzle_을 모아둔 배열
    private bool isAnswer = false;  // 정답의 유무를 체크하는 플래그 변수

    void Update()
    {
        if (isAnswer)   // 정답이 맞다면
        {
            return;     // 밑의 코드를 실행하지 않음
        }

        if (selectAlphabets[0].GetComponent<Alphabet_Puzzle>().now == 6 &&
            selectAlphabets[1].GetComponent<Alphabet_Puzzle>().now == 0 &&
            selectAlphabets[2].GetComponent<Alphabet_Puzzle>().now == 12 &&
            selectAlphabets[3].GetComponent<Alphabet_Puzzle>().now == 4) // 답이 GAME 일 때
        {
            print("정답");
            isAnswer = true;
            // 다시 업데이트 메서드로 들어왔을 때, 같은 작업을 반복하지 않게 막아주는 용도의 플래그 변수를 true로 변경
        }
    }
}
