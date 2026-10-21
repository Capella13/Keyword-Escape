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
            selectSprite = ItemController.items[ActiveItem.selectItemIndex]
            .GetComponent<Image>().sprite;
            // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기
        }

        if (selectSprite == null)   // 만일 선택된 아이템이 없다면
        {
            return; // 아무것도 실행하지 않고 넘어가기
        }

        if (selectSprite.name.Equals("Hammer")) // 현재 선택된 아이템이 Hammer라면
        {
            gameObject.SetActive(false); // 깨지지 않은 오브젝트(=본인) 비활성화 
            broke.SetActive(true);   // 깨져있는 잔해 오브젝트 활성화
        }
    }
}

/*public class BreakController : MonoBehaviour // 꽃병이나 컵이나 벽을 깨트리게 하는 오브젝트
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
        // 선택된 아이템이 없고 인덱스가 유효한 범위 내에 있는지 확인
        if (selectSprite == null)
        {
            // 인벤토리 배열이나 선택된 인덱스가 안전한지 확인
            if (ItemController.items != null &&
                ActiveItem.selectItemIndex >= 0 &&
                ActiveItem.selectItemIndex < ItemController.items.Length)
            {
                GameObject selectedItemObj = ItemController.items[ActiveItem.selectItemIndex];

                // 아이템 슬롯 자체가 비어있지 않은 경우에만 진행
                if (selectedItemObj != null)
                {
                    Image itemImage = selectedItemObj.GetComponent<Image>();

                    // Image 컴포넌트가 실제로 존재할 때만 sprite 가져오기
                    if (itemImage != null && itemImage.sprite != null)
                    {
                        selectSprite = itemImage.sprite;
                        print("찾았어~!");
                    }
                }
            }
        }

        print("일단 클릭은 됐는데...");

        // 2. 최종적으로 selectSprite가 여전히 null인지 체크
        if (selectSprite == null)
        {
            print("Nulllllll (선택된 아이템이 없거나 이미지가 없습니다)");
            return; // 아무것도 실행하지 않고 넘어가기
        }
        else if (selectSprite.name.Equals("Hammer")) // 현재 선택된 아이템이 Hammer라면
        {
            print("얘 망치인데?");
            gameObject.SetActive(false); // 깨지지 않은 오브젝트(=본인) 비활성화 
            broke.SetActive(true);   // 깨져있는 잔해 오브젝트 활성화

            if (this.audioSource != null && breaked != null)
            {
                this.audioSource.PlayOneShot(breaked);   // 클릭했을 때 오디오 재생
            }
        }
    }

        private void OnMouseDown() // 오브젝트를 클릭하면 실행되는 메서드
        {
            if (selectSprite == null)   // 만일 선택된 아이템이 없다면
            {
                selectSprite = ItemController.items[ActiveItem.selectItemIndex]
                .GetComponent<Image>().sprite;
                // 인벤토리 목록에서 선택한 아이템의 이미지를 찾기
                print("찾았어~!");
            }

            print("일단 클릭은 됐는데...");

            if (selectSprite == null)   // 만일 선택된 아이템이 없다면
            {
                print("Nulllllll");
                return; // 아무것도 실행하지 않고 넘어가기
            }
            else if (selectSprite.name.Equals("Hammer")) // 현재 선택된 아이템이 Hammer라면
            {
                print("얘 망치인데?");
                gameObject.SetActive(false); // 깨지지 않은 오브젝트(=본인) 비활성화 
                broke.SetActive(true);   // 깨져있는 잔해 오브젝트 활성화
                this.audioSource.PlayOneShot(breaked);   // 클릭했을 때 오디오 재생
            }
        }
    }
}*/