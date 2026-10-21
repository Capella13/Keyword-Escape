using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour
{
    GameObject detailBg;       // 아이템의 배경 (반투명 배경) 찾기
    GameObject closeButton;    // 닫기 버튼 찾기
    [SerializeField] GameObject bookOpen; // 책이 열려 있는 오브젝트

    private void Start()
    {
        // 싱글톤 오브젝트를 바인딩([SerializeField]) 방법으로 찾을 때 못 찾는 경우가 있음. (유니티 버그 같음..)
        // 여기서도 이런 경우가 생겨서 바인딩 대신에 직접 찾는 방법을 사용했다.

        if (KeepCanvas.instance != null)    // 널 체크
        {
            this.detailBg = KeepCanvas.instance.gameObject.transform.Find("Detail_Bg").gameObject;
            // 자식의 transform 컴포넌트 중에서 HintText 이라는 이름을 가지고 있는 자식 오브젝트를 찾는다.

            this.closeButton = KeepCanvas.instance.gameObject.transform.Find("DetailCloseButton").gameObject;
            // 자식의 transform 컴포넌트 중에서 HintText 이라는 이름을 가지고 있는 자식 오브젝트를 찾는다.

            print("closeButton : " + this.closeButton);
        }
    }

    private void OnMouseDown()
    {
        this.detailBg.SetActive(true);      // 아이템의 반투명 배경 활성화하기
        this.closeButton.SetActive(true);   // 아이템 자세히 보기 닫기 버튼 활성화 하기
        this.bookOpen.SetActive(true);     // 책이 열려 있는 오브젝트 활성화

        if (!GameDirector.isDetailClose) // 만약 아이템 자세히 보기 닫기 버튼이 눌러져서 isDetailClose가 true라면
        {
            print("나 진짜 살아있어요");
            print(GameDirector.isDetailClose);
            this.bookOpen.SetActive(false);    // 책이 열려 있는 오브젝트 비활성화
        }
    }
}
