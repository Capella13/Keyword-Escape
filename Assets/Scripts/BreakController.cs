using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakController : MonoBehaviour // 꽃병이나 컵이나 벽을 깨트리게 하는 오브젝트
{
    [SerializeField] GameObject broke;   // 깨져있는 잔해 모습 오브젝트
    Sprite selectSprite;    // 인벤토리 목록에서 선택된 이미지(아이템)

    [SerializeField] AudioClip breaked; // 깨졌을 때 재생될 오디오 클립
    AudioSource audioSource;    // 오디오 소스 컴포넌트를 찾기 위한 필드

    private void Start()
    {
        this.audioSource = GetComponent<AudioSource>();  // 오디오 소스 컴포넌트 찾기
    }

    private void OnMouseDown() // 오브젝트를 클릭하면 실행되는 메서드
    {
        if (selectSprite != null)   // 만일 선택된 아이템이 없다면
        {
            selectSprite = Inventory.items[ActiveItem.selectItemIndex]
            .GetComponent<Image>().sprite;
            // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기
        }

        /*if (selectSprite == null)   // 만일 선택된 아이템이 없다면
        {
            return; // 아무것도 실행하지 않고 넘어가기
        }*/

        if (selectSprite.name.Equals("Hammer")) // 현재 선택된 아이템이 Hammer라면
        {
            print(1);

            gameObject.SetActive(false); // 깨지지 않은 오브젝트(=본인) 비활성화 
            broke.SetActive(true);   // 깨져있는 잔해 오브젝트 활성화
            audioSource.PlayOneShot(breaked); // 깨지는 소리 재생
        }
    }
}