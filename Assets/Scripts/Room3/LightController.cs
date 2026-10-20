using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour    // 전등의 전구 부분을 깨트리는 스크립트
{

    private void OnMouseDown() // 전구 부분을 클릭하면 실행되는 메서드
    {
        Sprite selectSprite = ItemController.items[ActiveItem.selectItemIndex]
            .GetComponent<Image>().sprite;
        // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기


        if (selectSprite.name.Equals("Hammer")) // 현재 선택된 아이템이 Hammer라면
        {
            gameObject.SetActive(false);   // 전구 오브젝트 비활성화
        }
    }
}
