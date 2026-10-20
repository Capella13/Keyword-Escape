using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintController : MonoBehaviour
{
    [SerializeField] Sprite openBag; // 에셋에 있는 가방 열린 이미지 연결해주기

    [SerializeField] GameObject morseCode;  // 가방 열리는 이미지 때 활용할 모스부호 숫자표

    Text hintText;  // 하단에 힌트를 알려주는 텍스트 컴포넌트 연결해주기

    private void Start()
    {
        // 싱글톤 오브젝트를 바인딩([SerializeField]) 방법으로 찾을 때 못 찾는 경우가 있음. (유니티 버그 같음..)
        // 여기서도 이런 경우가 생겨서 바인딩 대신에 직접 찾는 방법을 사용했다.

        if (KeepCanvas.instance != null)    // 널 체크
        {
            this.hintText = KeepCanvas.instance.gameObject.transform.Find("HintText").gameObject.GetComponent<Text>();
            // 자식의 transform 컴포넌트 중에서 HintText 이라는 이름을 가지고 있는 자식 오브젝트를 찾고
            // Text 컴포넌트를 찾는다.
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Hide")) // 만약 태그가 Hide일 때
            // Hide : 오브젝트 내에 힌트가 숨겨져 있을 때
        {
            this.hintText.text = "무언가 단서가 숨겨져 있는 것 같다.";
        }
        else if (gameObject.CompareTag("Lock")) // 만약 태그가 Lock일 때
            // Lock : 가지고 있는 아이템이나 단서들을 조합하여 잠긴 것을 열 수 있는 오브젝트일 때
        {
            this.hintText.text = "드라이버로 열 수 있을 것 같다.";
        }
        else if (gameObject.CompareTag("Break")) // 만약 태그가 Break일 때
            // Break : 망치 아이템을 사용하여 오브젝트를 클릭했을 때 깨질 수 있는 오브젝트일 때
        {
            this.hintText.text = "망치로 깨트릴 수 있을 것 같다.";
        }
        else if (gameObject.CompareTag("HintText"))
        {
            this.hintText.text = "힌트가 되는 문구가 쓰여있다.";
        }
        else if (gameObject.CompareTag("KeyBox")) // 만약 태그가 KeyBox일 때
            // KeyBox : 열쇠가 들어있는 박스일 때. 문 왼쪽에 있는 박스를 의미한다.
        {
            this.hintText.text = "열쇠가 들어있는 박스다. 영어 스펠링을 조합하여 열 수 있을 것 같다.";
        }
        else if (gameObject.CompareTag("Bag")) // 만약 태그가 Bag일 때
            // Bag : 가방을 클릭했을 때 닫혀있는 가방을 열 때
        {
            GetComponent<SpriteRenderer>().sprite = openBag;
            // 가방의 Sprite 이미지를 열려있는 가방의 이미지(openBag)으로 바꾼다.
            if (morseCode != null)  // 이미 숫자표를 가져가서 없는 상황에서는 body가 실행되지 않게 한다.
            {
                morseCode.SetActive(true); // 숫자표 활성화
            }
        }
        else if (gameObject.CompareTag("BlackClock")) // 만약 태그가 BlackClock일 때
        {
            this.hintText.text = "이 검은 시계는 4시 13분 26초를 가리키고 있다.";
        }
        else if (gameObject.CompareTag("RedClock")) // 만약 태그가 RedClock일 때
        {
            this.hintText.text = "이 빨간 시계는 2시 24분 35초를 가리키고 있다.";
        }
        else
        {
            this.hintText.text = "여기에는 아무것도 없는 것 같다.";
        }
    }
}
