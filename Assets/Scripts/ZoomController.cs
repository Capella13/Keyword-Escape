using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour
{
    GameObject cameraMain;     // 메인 카메라 오브젝트 찾기
    GameObject backButton;     // 다시 돌아가기 버튼 찾기
    // 비활성화 되어있는 상태에서는 GameObject.Find()로 찾을 수 없기 때문에 [SerializeField]로 연결해준다.

    private float leftSet = 0.4f;   // 오브젝트를 인벤토리의 크기만큼 왼쪽으로 옮기는 필드

    private void Start()
    {
        if (KeepCamera.instance != null)    // 널 체크
        {
            cameraMain = KeepCamera.instance.gameObject;
        }

        if (KeepCanvas.instance != null)    // 널 체크
        {
            backButton = KeepCanvas.instance.gameObject.transform.Find("BackButton").gameObject;
            // 자식의 transform 컴포넌트 중에서 BackButton 이라는 이름을 가지고 있는 자식 컴포넌트를 찾고
            // 그 컴포넌트를 가지고 있는 컴포넌트, 즉, BackButton 오브젝트를 찾는다.
            print("Test" + backButton);
        }
    }



    private void OnMouseDown()
    {
        GetComponent<BoxCollider2D>().enabled = false;

        cameraMain.transform.position = new Vector3(this.transform.position.x + this.leftSet,
            this.transform.position.y, -10);
        // 카메라의 position 값을, 클릭한 오브젝트의 위치로 이동시킨다.
        /// 또한, x의 값에 보정값을 더하여 확대한 오브젝트가 인벤토리 때문에 오른쪽으로 쏠려보이는 오브젝트를
        /// 임의로 왼쪽으로 옮겨 보기 좋게 한다.

        cameraMain.GetComponent<Camera>().orthographicSize = 1.3f;
        // 메인 카메라는 원근감이 없기 때문에 orthographicSize로 zoom을 조정해주어야 한다.

        this.backButton.SetActive(true);   // 뒤로 가기 버튼 활성화 하기
    }
}
