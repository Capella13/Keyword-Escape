using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireplaceController : MonoBehaviour
{
    [SerializeField] GameObject NoteM;   // 노트 M 오브젝트
    Sprite selectSprite;    // 인벤토리 목록에서 선택된 이미지(아이템)

    private void OnMouseDown() // 오브젝트를 클릭하면 실행되는 메서드
    {
        if (selectSprite != null)
        {
            selectSprite = Inventory.items[ActiveItem.selectItemIndex]
            .GetComponent<Image>().sprite;
            // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기
        }

        if (selectSprite == null)   // 만일 선택된 아이템이 없다면
        {
            return; // 아무것도 실행하지 않고 넘어가기
        }

        if (selectSprite.name.Equals("Flashlight_On")) // 현재 선택된 아이템이 Flashlight_On이라면
        {
            gameObject.SetActive(false); // 깨지지 않은 오브젝트(=본인) 비활성화 
            NoteM.SetActive(true);   // 깨져있는 잔해 오브젝트 활성화
        }
    }
}
