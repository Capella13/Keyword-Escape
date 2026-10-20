using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallController : MonoBehaviour // Room3에 있는 벽 깨지게 하는 스크립트
{
    [SerializeField] GameObject hole;   // 구멍(벽 깨진) 모습 오브젝트

    private void OnMouseDown() // 금 간 부분을 클릭하면 실행되는 메서드
    {
        Sprite selectSprite = ItemController.items[ActiveItem.selectItemIndex]
            .GetComponent<Image>().sprite;
        // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기


        if (selectSprite.name.Equals("Hammer")) // 현재 선택된 아이템이 Hammer라면
        {
            hole.SetActive(true);   // 구멍 오브젝트 활성화
        }
    }
}
