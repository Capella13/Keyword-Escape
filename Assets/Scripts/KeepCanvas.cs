using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCanvas : MonoBehaviour
{
    private static KeepCanvas instance; // KeepCanvas 인스턴스를 참조하는 필드
    // 이 인스턴스를 참조하는 필드는 하나만 존재해야 하므로 꼭 static를 붙여줘야 한다.

    private void Awake() // Start()보다 일찍 시작되는 이벤트 메서드
    {
        if (instance == null)   // 만일 현재 만들어진 KeepCanvas 인스턴스가 없다면
        {
            instance = this;  // 인스턴스 생성
            DontDestroyOnLoad(gameObject); // 씬이 바뀌어도 싱글톤 인스턴스가 사라지지 않게 해준다.
        }
        else   // 만일 현재 만들어진 KeepCanvas 인스턴스가 있다면
        {
            Destroy(gameObject);    // 지금 만들려고 하는 인스턴스 삭제하기
        }
    }
}
