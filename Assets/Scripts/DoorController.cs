using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    [SerializeField] Sprite openDoor;
    // 인스펙터 창에서 이미지 연결해주기

    private void OnMouseDown() // 문을 클릭하면 실행되는 메서드
    {
        Sprite selectSprite = ItemController.items[int.Parse(EventSystem.current.currentSelectedGameObject.tag)]
            .GetComponent<Image>().sprite;
        // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기


        if (selectSprite.name.Equals("Key")) // 현재 선택된 아이템이 Key라면
        {
            GetComponent<SpriteRenderer>().sprite = openDoor;
            // 스프라이트 이미지를 openDoor로 변경하기
            // = 즉, 문을 열기
        }
    }
}
