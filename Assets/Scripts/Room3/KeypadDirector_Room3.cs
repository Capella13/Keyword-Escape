using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadDirector_Room3: MonoBehaviour    // Room3에 있는 키패드 암호를 열 때 사용하는 스크립트
{
    int count = 0;  // 현재 숫자 포지션 위치

    [SerializeField] Sprite[] nums;     // 숫자 스프라이트 이미지 배열 (10개)
    [SerializeField] GameObject[] positions;    // 정답 입력란에 있는 숫자의 위치 (3개)
    [SerializeField] GameObject openDoor; // 문이 열려 있는 오브젝트

    public bool isInput = true;  // 입력 가능 여부

    void Update()
    {
        if (isInput)
        {
            if (FindObjectOfType<Keypad_1_Room3>().selected)  // 1번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_1_Room3>().selected = false;  // 1번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;   // 카운트 횟수 올리기

                if (this.count == 1) // 현재 입력된 차례가 첫 번째 입력일 때
                {
                    this.positions[0].SetActive(true);   // 숨겼던 모습 활성화 시키기
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[1];
                    // 입력란 중 첫 번째 자리를 1번 이미지로 교체하기
                }
                else if (this.count == 2) // 현재 입력된 차례가 두 번째 입력일 때
                {
                    this.positions[1].SetActive(true);   // 숨겼던 모습 활성화 시키기
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[1];
                    // 입력란 중 두 번째 자리를 1번 이미지로 교체하기
                }
                else // 현재 입력된 차례가 세 번째 입력일 때
                {
                    this.positions[2].SetActive(true);   // 숨겼던 모습 활성화 시키기
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[1];
                    // 입력란 중 세 번째 자리를 1번 이미지로 교체하기

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드

                    this.count = 0;  // 현재가 세 번째 입력이므로 카운트 횟수를 다시 0으로 초기화

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8]) // 정답 438이 맞을 경우
                    {
                        print("정답");
                    }
                    else  // 오답일 경우
                    {
                        Invoke("ResetPosition", 1f);    // 1초 뒤 입력란에 입력했던 숫자의 모습들 숨기는 메서드 실행
                    }
                }
            }

            if (FindObjectOfType<Keypad_2_Room3>().selected)  // 2번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_2_Room3>().selected = false;  // 2번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[2];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[2];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[2];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                    {
                        print("정답");
                    }
                    else
                    {
                        Invoke("ResetPosition", 1f);
                    }
                }
            }

            if (FindObjectOfType<Keypad_3_Room3>().selected)  // 3번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_3_Room3>().selected = false;  // 3번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[3];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[3];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[3];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                    {
                        print("정답");
                    }
                    else
                    {
                        Invoke("ResetPosition", 1f);
                    }
                }
            }

            if (FindObjectOfType<Keypad_4_Room3>().selected)  // 4번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_4_Room3>().selected = false;  // 4번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[4];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[4];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[4];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                    {
                        print("정답");
                    }
                    else
                    {
                        Invoke("ResetPosition", 1f);
                    }
                }
            }

            if (FindObjectOfType<Keypad_5_Room3>().selected)  // 5번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_5_Room3>().selected = false;  // 5번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[5];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[5];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[5];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                    {
                        print("정답");
                    }
                    else
                    {
                        Invoke("ResetPosition", 1f);
                    }
                }
            }

            if (FindObjectOfType<Keypad_6_Room3>().selected)  // 6번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_6_Room3>().selected = false;  // 6번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[6];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[6];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[6];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                    {
                        print("정답");
                    }
                    else
                    {
                        Invoke("ResetPosition", 1f);
                    }
                }
            }

            if (FindObjectOfType<Keypad_7_Room3>().selected)  // 7번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_7_Room3>().selected = false;  // 7번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[7];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[7];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[7];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                    {
                        print("정답");
                    }
                    else
                    {
                        Invoke("ResetPosition", 1f);
                    }
                }
            }

            if (FindObjectOfType<Keypad_8_Room3>().selected)  // 8번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_8_Room3>().selected = false;  // 8번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[8];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[8];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[8];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                    {
                        print("정답");
                    }
                    else
                    {
                        Invoke("ResetPosition", 1f);
                    }
                }
            }

            if (FindObjectOfType<Keypad_9_Room3>().selected)  // 9번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_9_Room3>().selected = false;  // 9번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[9];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[9];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[9];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
                    {
                        print("정답");
                    }
                    else
                    {
                        Invoke("ResetPosition", 1f);
                    }
                }
            }

            if (FindObjectOfType<Keypad_0_Room3>().selected)  // 0번 키패드가 선택되었을 때
            {
                FindObjectOfType<Keypad_0_Room3>().selected = false;  // 0번 키패드가 선택되었던 것을 다시 false로 돌려놓기
                this.count++;

                if (this.count == 1)
                {
                    this.positions[0].SetActive(true);
                    this.positions[0].GetComponent<SpriteRenderer>().sprite = nums[0];
                }
                else if (this.count == 2)
                {
                    this.positions[1].SetActive(true);
                    this.positions[1].GetComponent<SpriteRenderer>().sprite = nums[0];
                }
                else
                {
                    this.positions[2].SetActive(true);
                    this.positions[2].GetComponent<SpriteRenderer>().sprite = nums[0];

                    isInput = false;  // 세 번째 입력이 끝났으므로 더 이상 입력할 수 없도록 false로 바꾸기

                    // 정답 비교 코드 작성
                    this.count = 0;

                    if (this.positions[0].GetComponent<SpriteRenderer>().sprite == nums[4] &&
                        this.positions[1].GetComponent<SpriteRenderer>().sprite == nums[3] &&
                        this.positions[2].GetComponent<SpriteRenderer>().sprite == nums[8])
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

    }

    void ResetPosition() // 입력란에 입력했던 숫자의 모습들 숨기기
    {
        for (int i = 0; i < positions.Length; i++)   // nums의 개수(3개) 만큼 반복하기
        {
            this.positions[i].SetActive(false);  // 입력란 전체 초기화 (모습 비활성화)
        }

        isInput = true;   // 다시 입력 가능 상태로 만들기
    }
}
