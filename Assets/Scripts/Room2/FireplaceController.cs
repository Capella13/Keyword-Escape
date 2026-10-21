using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireplaceController : MonoBehaviour
{
    [SerializeField] GameObject NoteM;   // 깨져있는 잔해 모습 오브젝트
    Sprite selectSprite;

    private void OnMouseDown() // 오브젝트를 클릭하면 실행되는 메서드
    {

        if (ActiveItem.selectItem != null)
        {
            this.selectSprite = ItemController.items[ActiveItem.selectItemIndex]
                .GetComponent<Image>().sprite;
            // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기
        }

        if (selectSprite == null) // 선택한 아이템이 없으면
        {
            return; // 아무것도 하지 않고 종료
        }

        if (!selectSprite.name.Equals("Flashlight_On")) // 현재 선택된 아이템이 Flashlight_On이라면
        {
            NoteM.SetActive(true);   // NoteM 오브젝트 활성화
        }
    }
}
