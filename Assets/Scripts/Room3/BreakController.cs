using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakController : MonoBehaviour // 꽃병이나 컵이나 벽을 깨트리게 하는 오브젝트
{
    [SerializeField] GameObject broke;   // 깨져있는 잔해 모습 오브젝트

    private void OnMouseDown() // 오브젝트를 클릭하면 실행되는 메서드
    {
        Sprite selectSprite = ItemController.items[ActiveItem.selectItemIndex]
            .GetComponent<Image>().sprite;
        // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기

        if (selectSprite == null) // 선택한 아이템이 없으면
        {
            return; // 아무것도 하지 않고 종료
        }

        if (selectSprite.name.Equals("Hammer")) // 현재 선택된 아이템이 Hammer라면
        {
            gameObject.SetActive(false); // 깨지지 않은 오브젝트(=본인) 비활성화 
            broke.SetActive(true);   // 깨져있는 잔해 오브젝트 활성화
        }
    }
}
