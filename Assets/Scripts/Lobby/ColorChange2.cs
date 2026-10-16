using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange2 : MonoBehaviour
{
    private Color[] colors; // 색상 배열
    public int selectedIndex = 0;  // 현재 선택된 색상의 인덱스 번호
    private SpriteRenderer childrenColor;   // 자식 오브젝트의 SpriteRenderer 컴포넌트 참조

    void Start()
    {
        this.colors = new Color[6]; // 배열 인스턴스 생성

        this.colors[0] = new Color(209f / 255f, 97f / 255f, 97f / 255f);    // #D16161 - 빨간색
        this.colors[1] = new Color(255f / 255f, 168f / 255f, 115f / 255f);  // #FFA873 - 주황색
        this.colors[2] = new Color(251f / 255f, 208f / 255f, 52f / 255f);   // #FBD034 - 노란색
        this.colors[3] = new Color(126f / 255f, 217f / 255f, 87f / 255f);   // #7ED957 - 초록색
        this.colors[4] = new Color(121f / 255f, 171f / 255f, 255f / 255f);  // #79ABFF - 파란색
        this.colors[5] = new Color(209f / 255f, 178f / 255f, 255f / 255f);  // #D1B2FF - 보라색

        this.childrenColor = transform.Find("Color_2").gameObject.GetComponent<SpriteRenderer>();
        // 자식 오브젝트의 SpriteRenderer 컴포넌트 찾기

        this.childrenColor.color = this.colors[selectedIndex];
        // 자식 오브젝트가 가지고 있는 SpriteRenderer 컴포넌트의 color 프로퍼티를 현재의 색(colors[0])으로 초기화
    }

    private void OnMouseDown()  // ColorFrame_0을 클릭하면 실행되는 메서드
    {
        print("2");
        this.selectedIndex++;   // 다음 색상으로 바꾸기

        if (this.selectedIndex == 6)    // 만일 현재 선택된 색상 인덱스가 6번이라면 (6번은 존재하지 않는 인덱스 번호이므로)
        {
            this.selectedIndex = 0;     // 색상 인덱스 코드를 0번으로 바꾸기
        }

        this.childrenColor.color = this.colors[selectedIndex];
        // 자식 오브젝트가 가지고 있는 SpriteRenderer 컴포넌트의 color 프로퍼티를 현재의 색(colors[0])으로 설정

        if (this.selectedIndex == 2 && FindObjectOfType<ColorChange0>().selectedIndex == 0 &&
    FindObjectOfType<ColorChange1>().selectedIndex == 3)
        {
            print("정답");
        }
    }
}
