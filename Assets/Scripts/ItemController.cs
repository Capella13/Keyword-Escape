using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    [SerializeField] Sprite newSprite;      // Inspector에서 Image의 Source Image로 들어가야 할 필드
    public static GameObject[] items;       // Hierarchy에 있는 inventory

    /*AudioSource audioSource;    // 오디오 소스 컴포넌트를 찾기 위한 필드
    [SerializeField] AudioClip pickUp;   // 아이템을 얻었을 때 나는 소리 (pop)*/

    public static bool isGotKey = false;        // 
    public static bool isGotMorse = false;
    public static bool isGotDriver = false;
    public static bool isGotFlash = false;
    public static bool isGotBattery = false;
    public static bool isGotGreenNote1 = false;
    public static bool isGotGreenNote2 = false;
    public static bool isGotHammer = false;
    public static bool isGotL = false;
    public static bool isGotU = false;
    public static bool isGotG = false;
    public static bool isGotM = false;

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();  // 오디오 소스 컴포넌트 찾기

        if (isGotKey && gameObject.CompareTag("Key"))
            // 현재 키를 얻은 상태와 씬에서 Key 태그를 가진 오브젝트(Key)가 존재의 유무가 같다면
        {
            Destroy(this.gameObject);   // 게임 오브젝트 삭제
        }
        else if (isGotMorse && gameObject.CompareTag("Morse"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotDriver && gameObject.CompareTag("Driver"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotFlash && gameObject.CompareTag("Flash"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotBattery && gameObject.CompareTag("Battery"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotGreenNote1 && gameObject.CompareTag("Green_Note_1"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotGreenNote2 && gameObject.CompareTag("Green_Note_2"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotHammer && gameObject.CompareTag("Hammer"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotL && gameObject.CompareTag("NoteL"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotU && gameObject.CompareTag("NoteU"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotG && gameObject.CompareTag("NoteG"))
        {
            Destroy(this.gameObject);
        }
        else if (isGotM && gameObject.CompareTag("NoteM"))
        {
            Destroy(this.gameObject);
        }

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
        //audioSource.PlayOneShot(pickUp);  
        /*AudioSource.PlayClipAtPoint(pickUp, transform.position, 100);  // 아이템 얻을 때 나는 소리 재생
        // PlayClipAtPoint() : 오브젝트가 삭제되어도 소리가 끊기지 않고 재생되는 메서드
        // 소리가 끝나면 자동으로 오디오 소스가 삭제됨
        // (아이템 오브젝트가 거의 동시에 삭제되므로 PlayOneShot()을 사용하면 소리가 안 남)*/
        /// 근데 소리가 너무 작아서 포기함.. 들리긴 들림

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

        if (gameObject.CompareTag("Key"))   // 현재 얻은 아이템이 Key라면
        {
            isGotKey = true;    // Key를 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("Morse"))
        {
            isGotMorse = true;  // Morse-Code-Table을 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("Driver"))
        {
            isGotDriver = true; // Driver를 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("Flash"))
        {
            isGotFlash = true;  // Flash를 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("Battery"))
        {
            isGotBattery = true;    // Battery를 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("Green_Note_1"))
        {
            isGotGreenNote1 = true; // Green_Note_1을 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("Green_Note_2"))
        {
            isGotGreenNote2 = true; // Green_Note_2을 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("Hammer"))
        {
            isGotHammer = true;     // Hammer를 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("NoteL"))
        {
            isGotL = true;          // Key_Note_L을 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("NoteU"))
        {
            isGotU = true;          // Key_Note_U을 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("NoteG"))
        {
            isGotG = true;          // Key_Note_G을 획득했음을 체크하는 플래그 변수를 true로 변경
        }
        else if (gameObject.CompareTag("NoteM"))
        {
            isGotM = true;          // Key_Note_M을 획득했음을 체크하는 플래그 변수를 true로 변경
        }
            Destroy(this.gameObject);   // 클릭한 게임 오브젝트 삭제
    }
}
