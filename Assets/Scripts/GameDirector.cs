using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    [SerializeField] string RightnextRoom;      // 거실 찾기

    [SerializeField] GameObject cameraMain;     // 메인 카메라 찾기
    [SerializeField] GameObject detailBg;       // 자세히 보기 버튼을 누르면 나오는 아이템의 배경 (반투명 배경) 찾기
    [SerializeField] GameObject closeButton;    // 자세히 보기 버튼을 누르면 나오는 자세히 보기 닫기 버튼 찾기
    [SerializeField] GameObject backButton;     // 오브젝트 아이템을 Zoom 했을 때 나타나는 뒤로가기 버튼 찾기

    [SerializeField] GameObject[] detailItems;  // 아이템은 총 12가지 이므로 배열로 여러 개 선언.

    public void ChangeScene() // 다음 장면 넘기는 화살표 버튼을 눌렀을 때 활성화되는 메서드
    {
        SceneManager.LoadScene(RightnextRoom); // 다음으로 씬 넘기는 코드
    }

    public void OnDetailButton() // 자세히 보기 버튼을 눌렀을 때 활성화되는 메서드
    {
        this.detailBg.SetActive(true);      // 아이템의 반투명 배경 활성화하기
        this.closeButton.SetActive(true);   // 아이템 자세히 보기 닫기 버튼 활성화 하기

        for (int i = 0; i < detailItems.Length; i++) // 자세히 보기로 띄워져있는 아이템 전부 반복문으로 둘러보기
        {
            this.detailItems[i].SetActive(false); // 자세히 보기로 띄워져있는 아이템 전부 닫기 (모습 숨기기)
        }

        if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Key")) // 만일 선택된 아이템이 열쇠(Key)라면
        // ActiveItem.selectItem는 현재 선택된 인벤토리이다. (아이템이 아니다.)
        // GetComponent<Image>().sprite는 인벤토리에 있는 아이템의 이미지를 찾는다.
        // 그리고 이미지의 이름을 name 프로퍼티로 찾을 수 있다.
        // 단, Tostring()으로 변환하면 안 됨. (순수한 문자열이 아니기 때문)
        {
            this.detailItems[0].SetActive(true); // 열쇠(Key)의 자세히 보기 이미지 띄우기
        }
        else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Bag")) // 만일 선택된 아이템이 가방(Bag)이라면
        {
            this.detailItems[1].SetActive(true); // 가방(Bag)의 자세히 보기 이미지 띄우기
        }
        else if (ActiveItem.selectItem.GetComponent<Image>().sprite.name.Equals("Light")) // 이미지 만들어야 함
        {
            // 이미지 만들고 그 이미지를 연결해주고 하는 노가다 해야함..
        }
        /*else
        {
            // 추후 이곳에서 선택되지 않은 상태, 즉 null일 때 자세히 보기를 클릭했을 때 나는 오류를 처리해주기
        }*/ 
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
        cameraMain.transform.position = new Vector3(0, 0, -10);   // 카메라 원위치로 다시 되돌리기

        cameraMain.GetComponent<Camera>().orthographicSize = 5f;
        // 메인 카메라는 원근감이 없기 때문에 orthographicSize로 zoom을 조정해주어야 한다.

        this.backButton.SetActive(false);   // 뒤로 가기 버튼 비활성화 시키기
    }
}
