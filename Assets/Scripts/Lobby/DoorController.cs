using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoorController : MonoBehaviour     // 로비에 있는 현관문을 열 때 사용하는 스크립트
{
    [SerializeField] GameObject openDoor;   // 문 열린 모습 오브젝트

    [SerializeField] AudioClip open; // 문 열린 오브젝트를 클릭했을 때 재생될 오디오 클립
    AudioSource audioSource;    // 오디오 소스 컴포넌트를 찾기 위한 필드

    private void Start()
    {
        this.audioSource = GetComponent<AudioSource>();  // 오디오 소스 컴포넌트 찾기
    }

    private void OnMouseDown() // 문을 클릭하면 실행되는 메서드
    {
        if (ActiveItem.selectItemIndex != -1) // 인벤토리 목록을 선택하지 않은 상태에서는 작업처리가 되지 않도록 한다
        {
            Sprite selectSprite = Inventory.items[ActiveItem.selectItemIndex]
                .GetComponent<Image>().sprite;

            if (selectSprite != null && selectSprite.name.Equals("Key")) // 인벤토리에 아이템이 존재하고 현재 선택된 아이템이 Key라면
            {
                /*GetComponent<SpriteRenderer>().sprite = openDoor;
                // 스프라이트 이미지를 openDoor로 변경하기
                // = 즉, 문을 열기*/

                openDoor.SetActive(true);   // 문 열린 오브젝트 활성화
                openDoor.GetComponent<BoxCollider2D>().enabled = true; // 문 열린 오브젝트 콜라이더 활성화

                gameObject.GetComponent<BoxCollider2D>().enabled = false; // 본인 콜라이더 비활성화

                audioSource.PlayOneShot(open); // 열리는 소리 재생
            }
        }    
        // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기

    }
}