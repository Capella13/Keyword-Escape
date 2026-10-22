using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour    // 전등의 전구 부분을 깨트리는 스크립트
{
    Sprite selectSprite;    // 인벤토리 목록에서 선택된 이미지(아이템)

    [SerializeField] AudioClip breaked; // 깨졌을 때 재생될 오디오 클립
    AudioSource audioSource;    // 오디오 소스 컴포넌트를 찾기 위한 필드

    private void OnMouseDown() // 전구 부분을 클릭하면 실행되는 메서드
    {
        if (selectSprite != null)   // 만일 선택된 아이템이 없다면
        {
            selectSprite = Inventory.items[ActiveItem.selectItemIndex]
            .GetComponent<Image>().sprite;
            // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기
        }

        if (selectSprite == null)   // 만일 선택된 아이템이 없다면
        {
            return; // 아무것도 실행하지 않고 넘어가기
        }

        if (selectSprite.name.Equals("Hammer")) // 현재 선택된 아이템이 Hammer라면
        {
            gameObject.SetActive(false);   // 전구 오브젝트(본인) 비활성화
        }
    }
}
