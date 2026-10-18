using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;  // 유니티 엔진을 사용하기 위해서 필요한 네임스페이스
using UnityEngine.SceneManagement;  // 씬을 바꾸기 위해서 필요한 네임스페이스
using UnityEngine.UI;   // UI를 사용하기 위해서 필요한 네임스페이스

public class GameDirector : MonoBehaviour   // 전체적인 게임을 관리하며 여러가지 기능을 담당하는 스크립트
{
    [SerializeField] string rightNextRoom;     // 오른쪽 방 찾기
    [SerializeField] string leftNextRoom;      // 왼쪽 방 찾기

    [SerializeField] GameObject cameraMain;     // 메인 카메라 찾기
    [SerializeField] GameObject detailBg;       // 자세히 보기 버튼을 누르면 나오는 아이템의 배경 (반투명 배경) 찾기
    [SerializeField] GameObject closeButton;    // 자세히 보기 버튼을 누르면 나오는 자세히 보기 닫기 버튼 찾기
    [SerializeField] GameObject backButton;     // 오브젝트 아이템을 Zoom 했을 때 나타나는 뒤로가기 버튼 찾기

    [SerializeField] GameObject[] detailItems;  // 아이템은 총 12가지 이므로 배열로 여러 개 선언.

    public void RChangeScene() // 오른쪽 장면 넘기는 화살표 버튼을 눌렀을 때 활성화되는 메서드
    {
        SceneManager.LoadScene(this.rightNextRoom); // 다음으로 씬 넘기는 코드
    }
    public void LChangeScene() // 왼쪽 장면 넘기는 화살표 버튼을 눌렀을 때 활성화되는 메서드
    {
        SceneManager.LoadScene(this.leftNextRoom); // 다음으로 씬 넘기는 코드
    }

    public void OnDetailButton() // 자세히 보기 버튼을 눌렀을 때 활성화되는 메서드
    {
        if (ActiveItem.selectItem.GetComponent<Image>().sprite != null) // 만일 선택된 아이템이 없다면 실행하지 않기
        {
            this.detailBg.SetActive(true);      // 아이템의 반투명 배경 활성화하기
            this.closeButton.SetActive(true);   // 아이템 자세히 보기 닫기 버튼 활성화 하기

            for (int i = 0; i < detailItems.Length; i++) // 자세히 보기로 띄워져있는 아이템 전부 반복문으로 둘러보기
            {
                this.detailItems[i].SetActive(false); // 자세히 보기로 띄워져있는 아이템 전부 닫기 (모습 숨기기)
            }

            if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Key")) // 만일 선택된 아이템이 열쇠(Key)라면
            /// ActiveItem.selectItem는 현재 선택된 인벤토리이다. (아이템이 아니다.)
            /// GetComponent<Image>().sprite는 인벤토리에 있는 아이템의 이미지를 찾는다.
            /// 그리고 이미지의 이름을 name 프로퍼티로 찾을 수 있다.
            /// 단, Tostring()으로 변환하면 안 됨. (순수한 문자열이 아니기 때문)
            {
                this.detailItems[0].SetActive(true); // 열쇠(Key)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Morse"))
            // 만일 선택된 아이템이 모스부호 숫자표(Morse-Code-Table)라면
            {
                this.detailItems[1].SetActive(true);
                // 모스부호 숫자표(Morse)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Screwdriver"))
            // 만일 선택된 아이템이 드라이버(Screwdriver)라면
            {
                this.detailItems[2].SetActive(true);
                // 드라이버(Screwdriver)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Flashlight"))
            // 만일 선택된 아이템이 손전등(Flash)라면
            {
                this.detailItems[3].SetActive(true);
                // 손전등(Flash)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Battery"))
            // 만일 선택된 아이템이 배터리(Battery)라면
            {
                this.detailItems[4].SetActive(true);
                // 배터리(Battery)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Green_Note_1"))
            // 만일 선택된 아이템이 초록색 쪽지(GreenNote1)라면
            {
                this.detailItems[5].SetActive(true);
                // 초록색 쪽지(GreenNote1)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Green_Note_2"))
            // 만일 선택된 아이템이 초록색 쪽지(GreenNote2)라면
            {
                this.detailItems[6].SetActive(true);
                // 초록색 쪽지(GreenNote2)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Hammer"))
            // 만일 선택된 아이템이 망치(Hammer)라면
            {
                this.detailItems[7].SetActive(true);
                // 망치(Hammer)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Key_Note_L"))
            // 만일 선택된 아이템이 알파벳 L(L)이라면
            {
                this.detailItems[8].SetActive(true);
                // 알파벳 L(L)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Key_Note_U"))
            // 만일 선택된 아이템이 알파벳 U(U)라면
            {
                this.detailItems[9].SetActive(true);
                // 알파벳 U(U)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Key_Note_G"))
            // 만일 선택된 아이템이 알파벳 G(G)라면
            {
                this.detailItems[10].SetActive(true);
                // 알파벳 G(G)의 자세히 보기 이미지 띄우기
            }
            else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Key_Note_M"))
            // 만일 선택된 아이템이 알파벳 M(M)이라면
            {
                this.detailItems[11].SetActive(true);
                // 알파벳 M(M)의 자세히 보기 이미지 띄우기
            }
        }
    }

    public void OnDetailCloseButton() // 자세히 보기 닫기 버튼(DetailCloseButton)을 클릭했을 때 활성화되는 메서드
    {
        this.detailBg.SetActive(false);     // 자세히 보기 버튼을 누르면 나오는 아이템의 반투명 배경 비활성화 (모습 숨기기)
        this.closeButton.SetActive(false);  // 자세히 보기 닫기 버튼 비활성화 (모습 숨기기)

        for (int i = 0; i < detailItems.Length; i++) // 자세히 보기로 띄워져있는 아이템 전부 반복문으로 둘러보기
        {
            this.detailItems[i].SetActive(false); // 자세히 보기로 띄워져있는 아이템 전부 닫기 (모습 숨기기)
        }
    }

    public void OnBackButton() // 뒤로 가기 버튼을 클릭했을 때 활성화되는 메서드
    {
        print("뒤로 가기 버튼 활성화");

        /*GameObject.Find("ZoomColorPuzzle").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.Find("ZoomBagCollider").GetComponent<BoxCollider2D>().enabled = true;*/


        this.cameraMain.transform.position = new Vector3(0, 0, -10);   // 카메라 원위치로 다시 되돌리기

        this.cameraMain.GetComponent<Camera>().orthographicSize = 5f;
        // 메인 카메라는 원근감이 없기 때문에 orthographicSize로 zoom을 조정해주어야 한다.

        this.backButton.SetActive(false);   // 뒤로 가기 버튼 비활성화 시키기
    }
}
