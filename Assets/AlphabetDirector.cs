using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetDirector : MonoBehaviour
{
    [SerializeField] GameObject[] selectAlphabets;  // 6개의 Alphabet_Puzzle을 모아둔 배열
    private bool isAnswer = false;  // 정답의 유무를 체크하는 플래그 변수

    void Update()
    {

        if (isAnswer)   // 정답이 맞다면
        {
            return;     // 밑의 코드를 실행하지 않음
        }

        if (selectAlphabets[0].GetComponent<Alphabet_Puzzle>().now == 11 &&
            selectAlphabets[1].GetComponent<Alphabet_Puzzle>().now == 20 &&
            selectAlphabets[2].GetComponent<Alphabet_Puzzle>().now == 21 &&
            selectAlphabets[3].GetComponent<Alphabet_Puzzle>().now == 6 &&
            selectAlphabets[4].GetComponent<Alphabet_Puzzle>().now == 6 &&
            selectAlphabets[5].GetComponent<Alphabet_Puzzle>().now == 12) // 답이 LUVGGM 일 때
        {
            print("정답");
            isAnswer = true;
            // 다시 업데이트 메서드로 들어왔을 때, 같은 작업을 반복하지 않게 막아주는 용도의 플래그 변수를 true로 변경
        }
    }
}
