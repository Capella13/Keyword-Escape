using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    [SerializeField] Sprite newSprite;      // Inspector에서 Image의 Source Image로 들어가야 할 필드
    public static GameObject[] items;       // Hierarchy에 있는 inventory

    private void Start()
    {
        items = new GameObject[12];    // 배열 인스턴스 생성

        // 각 요소마다 초기화 작업
        items[0] = GameObject.Find("Inventory_0");
        items[1] = GameObject.Find("Inventory_1");  
        items[2] = GameObject.Find("Inventory_2");
        items[3] = GameObject.Find("Inventory_3");
        items[4] = GameObject.Find("Inventory_4");
        items[5] = GameObject.Find("Inventory_5");
        items[6] = GameObject.Find("Inventory_6");
        items[7] = GameObject.Find("Inventory_7");
        items[8] = GameObject.Find("Inventory_8");
        items[9] = GameObject.Find("Inventory_9");
        items[10] = GameObject.Find("Inventory_10");
        items[11] = GameObject.Find("Inventory_11");
    }

    private void OnMouseDown() // Scene에 있는 게임 오브젝트를 클릭했을 때 자동 호출되는 이벤트 메소드
                               // 단, 게임오브젝트가 Collider를 가지고 있어야 하며,
                               // 카메라의 이름이 MainCamera여야 한다.
    {
        for (int i = 0; i < items.Length; i++) // Image UI(아이템 저장 목록)중에서 비어있는 부분에 차례대로
                                               // 획득한 아이템 이미지를 추가하기 위하여 목록들의
                                               // Source Image가 null인지 아닌지를 체크하는 반복문.
                                               // null인 경우에만 이미지를 추가한다.
        {
            if (items[i].GetComponent<Image>().sprite == null) // Source Image가 null인지 체크
            {
                items[i].GetComponent<Image>().sprite = newSprite; 
                // 이미지가 null인 UI의 Image 컴포넌트의 sprite를 newSprite로 변경

                break; // 이미지가 1개만 들어가게 반복문 탈출해야 한다.
            }
        }
            
        Destroy(this.gameObject);   // 클릭한 게임 오브젝트 삭제
    }
}
