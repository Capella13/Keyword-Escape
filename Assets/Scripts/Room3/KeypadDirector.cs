using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadDirector : MonoBehaviour
{
    int count = 0;  // 현재 숫자 포지션 위치

    [SerializeField] Sprite[] nums;     // 숫자 스프라이트 이미지 배열
    [SerializeField] GameObject[] positions;    // 정답 입력란에 있는 숫자의 위치

    void Update()
    {
        if (FindObjectOfType<Keypad_1>().selected)  // 1번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_1>().selected = false;  // 1번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;   // 카운트 횟수 올리기

            if (count == 1) // 현재 입력된 차례가 첫 번째 입력일 때
            {
                positions[0].SetActive(true);   // 숨겼던 모습 활성화 시키기
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[1];
                // 입력란 중 첫 번째 자리를 1번 이미지로 교체하기
            }
            else if (count == 2) // 현재 입력된 차례가 두 번째 입력일 때
            {
                positions[1].SetActive(true);   // 숨겼던 모습 활성화 시키기
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[1];
                // 입력란 중 두 번째 자리를 1번 이미지로 교체하기
            }
            else // 현재 입력된 차례가 세 번째 입력일 때
            {
                positions[2].SetActive(true);   // 숨겼던 모습 활성화 시키기
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[1];
                // 입력란 중 세 번째 자리를 1번 이미지로 교체하기


                // 정답 비교 코드

                count = 0;  // 현재가 세 번째 입력이므로 카운트 횟수를 다시 0으로 초기화

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8]) // 정답 438이 맞을 경우
                {
                    print("정답");
                }
                else  // 오답일 경우
                {
                    Invoke("ResetPosition", 1f);    // 1초 뒤 입력란에 입력했던 숫자의 모습들 숨기는 메서드 실행
                }
            }
        }

        if (FindObjectOfType<Keypad_2>().selected)  // 2번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_2>().selected = false;  // 2번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[2];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[2];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[2];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }

        if (FindObjectOfType<Keypad_3>().selected)  // 3번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_3>().selected = false;  // 3번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[3];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[3];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[3];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }

        if (FindObjectOfType<Keypad_4>().selected)  // 4번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_4>().selected = false;  // 4번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[4];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[4];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[4];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }

        if (FindObjectOfType<Keypad_5>().selected)  // 5번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_5>().selected = false;  // 5번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[5];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[5];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[5];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }

        if (FindObjectOfType<Keypad_6>().selected)  // 6번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_6>().selected = false;  // 6번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[6];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[6];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[6];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }

        if (FindObjectOfType<Keypad_7>().selected)  // 7번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_7>().selected = false;  // 7번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[7];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[7];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[7];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }

        if (FindObjectOfType<Keypad_8>().selected)  // 8번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_8>().selected = false;  // 8번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[8];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[8];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[8];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }

        if (FindObjectOfType<Keypad_9>().selected)  // 9번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_9>().selected = false;  // 9번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[9];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[9];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[9];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }

        if (FindObjectOfType<Keypad_0>().selected)  // 0번 키패드가 선택되었을 때
        {
            FindObjectOfType<Keypad_0>().selected = false;  // 0번 키패드가 선택되었던 것을 다시 false로 돌려놓기
            this.count++;

            if (count == 1)
            {
                positions[0].SetActive(true);
                positions[0].GetComponent<SpriteRenderer>().sprite = nums[0];
            }
            else if (count == 2)
            {
                positions[1].SetActive(true);
                positions[1].GetComponent<SpriteRenderer>().sprite = nums[0];
            }
            else
            {
                positions[2].SetActive(true);
                positions[2].GetComponent<SpriteRenderer>().sprite = nums[0];

                // 정답 비교 코드 작성
                count = 0;

                if (positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                    positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                    positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                {
                    print("정답");
                }
                else
                {
                    Invoke("ResetPosition", 1f);
                }
            }
        }
    }

    void ResetPosition() // 입력란에 입력했던 숫자의 모습들 숨기기
    {
        for (int i = 0; i < positions.Length; i++)   // nums의 개수(3개) 만큼 반복하기
        {
            print(i);
            positions[i].SetActive(false);  // 입력란 전체 초기화 (모습 비활성화)
        }
    }
}
