using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoorController : MonoBehaviour     // 로비에 있는 현관문을 열 때 사용하는 스크립트
{
    [SerializeField] GameObject openDoor;   // 문 열린 모습 오브젝트
    Sprite selectSprite;    // 인벤토리 목록에서 선택된 이미지(아이템)

    private void OnMouseDown() // 문을 클릭하면 실행되는 메서드
    {
        if (selectSprite != null)
        {
            selectSprite = ItemController.items[ActiveItem.selectItemIndex]
            .GetComponent<Image>().sprite;
            // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기
        }

        if (selectSprite == null)   // 만일 선택된 아이템이 없다면
        {
            return; // 아무것도 실행하지 않고 넘어가기
        }

        if (selectSprite.name.Equals("Key")) // 현재 선택된 아이템이 Key라면
        {
            this.openDoor.SetActive(true);   // 문 열린 오브젝트 활성화
        }
    }
}
