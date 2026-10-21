using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class RedAlphabetDirector : MonoBehaviour    // Lobby에 있는 열쇠가 든 상자를 열 때 사용하는 스크립트
{
    [SerializeField] GameObject[] selectAlphabets;  // 6개의 Alphabet_Puzzle_을 모아둔 배열
    [SerializeField] GameObject openDoor;   // 열쇠가 들어있는 빨간 상자의 열린 모습
    [SerializeField] GameObject closeDoor;  // 열쇠가 들어있는 빨간 상자의 닫힌 모습
    [SerializeField] GameObject key;  // 열쇠

    private bool isAnswer = false;  // 정답의 유무를 체크하는 플래그 변수

    //###########
    AudioSource audioSource;
    [SerializeField] AudioClip boxopen;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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

            //###########
            audioSource.PlayOneShot(boxopen);

            openDoor.SetActive(true);   // 열린 상자 이미지 활성화
            key.SetActive(true);        // 열쇠 모습 활성화
            closeDoor.SetActive(false); // 닫힌 상자 이미지 비활성화

            isAnswer = true;
            // 다시 업데이트 메서드로 들어왔을 때, 같은 작업을 반복하지 않게 막아주는 용도의 플래그 변수를 true로 변경
        }
    }
}
