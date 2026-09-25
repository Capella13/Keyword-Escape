using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ActiveItem : MonoBehaviour // 인벤토리가 가지고 있는 스크립트
{
    bool flag = true;   // 동일한 item이 클릭될 때마다 값이 바뀌면서 toggle 스위치 역할을 해주는 필드
    [SerializeField] int inventoryIndex;         // 현재 클릭된 인벤토리의 번호
    [SerializeField] GameObject[] inventorys;    // Hierarchy에 있는 inventory
    public static GameObject selectItem;         // 선택된 인벤토리

    public void OnButtonClick() // 버튼을 클릭할 때 마다 실행되는 메서드
    {
        print(ItemController.items[int.Parse(EventSystem.current.currentSelectedGameObject.tag)]
            .GetComponent<Image>().sprite.ToString());
        // ItemController에 있는 items배열(목록 버튼 UI들의 묶음)의 sprite의 이름을 찾아
        // 현재 들어간 아이템이 무엇인지 파악.

        // Parse는 int형 구조체의 소속 메서드.
        // int형이 아닌 매개변수 인자의 자료형을 int로 바꿔 리턴하는 역할을 한다.

        selectItem = ItemController.items[int.Parse(EventSystem.current.currentSelectedGameObject.tag)];

        if (this.flag) // flag가 true이라면
        {
            Active(); // 흰색으로 변경
        }
        else          // 아니라면 (= flag가 false라면)
        {
            InActive(); // 회색으로 변경
        }

        this.flag = !this.flag; // 현재 플래그 변수의 값과 반대의 값을 대입
    }

    public void Active() // flag 변수가 true 일 때 실행되는 메서드
    {
        transform.parent.gameObject.GetComponent<Image>().color = Color.white;
        // 이 스크립트를 가지고 있는 오브젝트의 부모(배경이미지)를 찾아서 흰색으로 바꾼다.

        // 나머지 아이템 인벤토리의 ActiveItem 스크립트에 InActive를 호출시킨다. - 숙제

        for (int i = 0; i < inventorys.Length; i++)
        {
            if (i != inventoryIndex) // 현재 클릭한 인벤토리 값이 아닌 다른 나머지 애들
            {
                inventorys[i].transform.parent.gameObject.GetComponent<Image>().color
                 = new Color((172.0f / 255.0f), (172.0f / 255.0f), (172.0f / 255.0f));
                // 회색으로 바꿔주기 - 문제가 있음
            }
        }
    }

    public void InActive() // flag 변수가 false일 때 실행되는 메서드
    {
        transform.parent.gameObject.GetComponent<Image>().color
            = new Color((172.0f / 255.0f), (172.0f / 255.0f), (172.0f / 255.0f));
        // 이 스크립트를 가지고 있는 오브젝트의 부모(배경이미지)를 찾아서 회색으로 바꾼다.
    }
}
