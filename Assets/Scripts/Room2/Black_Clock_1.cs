using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Black_Clock_1 : MonoBehaviour
{
    float sensitivity = 30f; //회전에 필요한 드래그 최소길이
    float rotateInterval = 0.3f; //드래그중 회전하는 시간 간격(초)

    Vector3 mouseInit; //드래그 시작위치
    float nextRotateTime = 0f; //다음 회전이 가능한 시간

    float nowAngle = 0f; //휠의 현재 회전위치(도)
    public int step = 0;

    [SerializeField] GameObject openDoor;  // Safe 문 열려있는 모습 오브젝트
    [SerializeField] GameObject keyNoteG;  // 쪽지 G가 들어있는 오브젝트

    //###########
    AudioSource audioSource;
    [SerializeField] AudioClip dial;
    [SerializeField] AudioClip ureka;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown() //이 스크립트 오브젝트의 콜라이더 내에서 마우스 클릭시
    {
        mouseInit = Input.mousePosition; //드래그 시작위치
        nextRotateTime = Time.time; //회전 가능 시간
    }

    void OnMouseDrag() //마우스 드래그시
    {
        //드래그된 벡터(스크린 좌표 기준)
        Vector3 mouseOffset = Input.mousePosition - mouseInit;

        if (mouseOffset.magnitude > sensitivity) //드래그된 벡터 길이가 회전 필요 최소길이 보다 길때
        {
            //현재 설정된 시간 간격(rotateInterval)이 지났을 때만 회전 실행
            if (Time.time >= nextRotateTime) //최초엔 시간 간격 없이 회전
            {
                //다음 회전 가능 시간 갱신
                nextRotateTime = Time.time + rotateInterval;

                //현재 오브젝트의 월드 좌표를 스크린 좌표로 변환 (오브젝트의 화면상 중심점)
                Vector3 objectScreenPos = Camera.main.WorldToScreenPoint(transform.position);

                //오브젝트 중심을 기준으로 한 마우스 시작 위치의 상대 좌표
                Vector2 relativeInitPos = (Vector2)mouseInit - (Vector2)objectScreenPos;

                if (Mathf.Abs(mouseOffset.x) > Mathf.Abs(mouseOffset.y)) //드래그된 벡터에서 x성분이 지배적일 때
                {
                    if (relativeInitPos.y >= 0) //오브젝트 기준 1, 2사분면(위쪽)
                    {
                        if (mouseOffset.x < 0)
                        {
                            rotateWheel(9.0f);   //반시계방향
                        }
                        else
                        {
                            rotateWheel(-9.0f);  //시계방향
                        }
                    }
                    else //오브젝트 기준 3, 4사분면(아래쪽)
                    {
                        if (mouseOffset.x < 0)
                        {
                            rotateWheel(-9.0f);   //시계방향
                        }
                        else
                        {
                            rotateWheel(9.0f);    //반시계방향
                        }
                    }
                }
                else //드래그된 벡터에서 y성분이 지배적일 때
                {
                    if (relativeInitPos.x < 0) //오브젝트 기준 2, 3사분면(왼쪽)
                    {
                        if (mouseOffset.y < 0)
                        {
                            rotateWheel(9.0f);   //반시계방향
                        }
                        else
                        {
                            rotateWheel(-9.0f);  //시계방향
                        }
                    }
                    else //오브젝트 기준 1, 4사분면(오른쪽)
                    {
                        if (mouseOffset.y < 0)
                        {
                            rotateWheel(-9.0f);  //시계방향
                        }
                        else
                        {
                            rotateWheel(9.0f);   //반시계방향
                        }
                    }
                }
            }
        }
    }

    void rotateWheel(float ang)
    {
        //###########
        audioSource.PlayOneShot(dial);

        transform.Rotate(new Vector3(0, 0, ang)); //오브젝트 회전
        nowAngle = nowAngle + ang; //현재 휠의 회전위치 갱신

        //nowAngle값을 각도가 0 ~ 360도 이내의 값만 가지도록.
        //nowAngle값은 계속 회전시 그값이 다시 사용되어야 하므로
        //새로운 지역변수를 만들어서 사용한다.
        float currentDegree = nowAngle % 360f;

        //각도가 양수의 값만 가지도록.
        if (currentDegree < 0f)
        {
            currentDegree += 360f;
        }

        //시계방향으로 각도값이 증가하도록 currentDegree값 수정
        // currentDegree = 360f - currentDegree;

        //0 ~ 360도 값을 0 ~ 39 눈금값으로 변환
        step = (int)(currentDegree / 9f) % 40;

        print("현재 눈금값 : " + step);

        if (this.step == 13 && FindObjectOfType<Black_Clock_0>().step == 4 &&
            FindObjectOfType<Black_Clock_2>().step == 26)
        {
            print("정답");

            //###########
            audioSource.PlayOneShot(ureka);

            this.openDoor.SetActive(true); // 문 열린 모습 활성화
            this.keyNoteG.SetActive(true); // 쪽지 G 오브젝트 활성화
            /// Lobby에 있는 열쇠 박스를 열기 위한 단서
        }
    }
}
