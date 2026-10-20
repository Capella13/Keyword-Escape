using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UI 관련 컴포넌트 사용하기 위해 필요

public class DetailKey : MonoBehaviour
    // 아이템을 인벤토리에서 선택한 후, 자세히 보기 버튼을 누른 뒤에
    // 확대된 오브젝트를 클릭했을 때 나오는 힌트 메세지가 출력되는 스크립트
{
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
        this.hintText.text = "이걸로 현관문을 열 수 있을 것 같다.";
    }
}