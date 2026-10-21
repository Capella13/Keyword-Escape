using UnityEngine;
using UnityEngine.EventSystems;

public class ZoomController : MonoBehaviour // 오브젝트를 줌인해주는 메서드
{
    GameObject cameraMain;     // 메인 카메라 오브젝트 찾기
    GameObject backButton;     // 다시 돌아가기 버튼 찾기
    // 비활성화 되어있는 상태에서는 GameObject.Find()로 찾을 수 없기 때문에 [SerializeField]로 연결해준다.

    private float leftSet = 0.4f;   // 오브젝트를 인벤토리의 크기만큼 왼쪽으로 옮기는 필드

    private void Start()
    {
        // 싱글톤 오브젝트를 바인딩([SerializeField]) 방법으로 찾을 때 못 찾는 경우가 있음. (유니티 버그 같음..)
        // 여기서도 이런 경우가 생겨서 바인딩 대신에 직접 찾는 방법을 사용했다.

        if (KeepCamera.instance != null)    // 널 체크
        {
            this.cameraMain = KeepCamera.instance.gameObject;
            // 카메라를 직접 [SerializeField]으로 연결하려니 어떠한 문제가 생겨 코드 내에서 찾기
        }

        if (KeepCanvas.instance != null)    // 널 체크
        {
            this.backButton = KeepCanvas.instance.gameObject.transform.Find("BackButton").gameObject;
            // 자식의 transform 컴포넌트 중에서 BackButton 이라는 이름을 가지고 있는 자식 오브젝트를 찾는다.
        }
    }

    private void OnMouseDown()  // 줌인할 오브젝트를 클릭했을 때 활성화 되는 메서드
    {
        if (EventSystem.current.IsPointerOverGameObject())
        // 게임 오브젝트와 UI의 위치가 겹쳐 있을 때, UI의 버튼에 마우스 커서가 올려져 있으면 (클릭하면)
        // 게임 오브젝트의 OnMouseDown이 처리되지 않도록 함.
        {
            return; // 리턴하기 (이 이하 코드 실행하지 않기)
        }

        GameDirector.zoomedObject = gameObject.name;    // 현재 줌인한 오브젝트의 이름 저장

        if (!GameDirector.zoomedObject.Equals("Red_Simple-Tutorial") && !GameDirector.zoomedObject.Equals("Green_Simple-Tutorial") &&
            !GameDirector.zoomedObject.Equals("Blue_Simple-Tutorial") && !GameDirector.zoomedObject.Equals("Green_Picture-Frame") &&
            !GameDirector.zoomedObject.Equals("Color-Books_3") && !GameDirector.zoomedObject.Equals("Blue_Clock") &&
            !GameDirector.zoomedObject.Equals("Shoes") && !GameDirector.zoomedObject.Equals("Pot_1") &&
            !GameDirector.zoomedObject.Equals("pot_2") && !GameDirector.zoomedObject.Equals("Frames") &&
            !GameDirector.zoomedObject.Equals("Green_Frame_2") && !GameDirector.zoomedObject.Equals("TV_1") &&
            !GameDirector.zoomedObject.Equals("TV_2") && !GameDirector.zoomedObject.Equals("Plant_2") &&
            !GameDirector.zoomedObject.Equals("Light_3") && !GameDirector.zoomedObject.Equals("Green_Frame_1") &&
            !GameDirector.zoomedObject.Equals("Books_4") && !GameDirector.zoomedObject.Equals("Boxs_2") &&
            !GameDirector.zoomedObject.Equals("Books_1") && !GameDirector.zoomedObject.Equals("Boxs_1") &&
            !GameDirector.zoomedObject.Equals("Books_2") && !GameDirector.zoomedObject.Equals("Chair_0") &&
            !GameDirector.zoomedObject.Equals("Pot3") && !GameDirector.zoomedObject.Equals("Pot4_Room2") &&
            !GameDirector.zoomedObject.Equals("Green_Frame") && !GameDirector.zoomedObject.Equals("Image-Frame") &&
            !GameDirector.zoomedObject.Equals("Cleaning-tools-Item") && !GameDirector.zoomedObject.Equals("Chair_1") &&
            !GameDirector.zoomedObject.Equals("Light1") && !GameDirector.zoomedObject.Equals("Plant") &&
            !GameDirector.zoomedObject.Equals("Frames") && !GameDirector.zoomedObject.Equals("Green_Frame2") &&
            !GameDirector.zoomedObject.Equals("Red_Clock") && !GameDirector.zoomedObject.Equals("Globe") &&
            !GameDirector.zoomedObject.Equals("Pot1") && !GameDirector.zoomedObject.Equals("Globe"))
        // 같은 위치에 콜라이더가 2개 겹쳐있는 오브젝트들은 바깥쪽 줌용 콜라이더를 비활성화해야
        // 안쪽 콜라이더와 겹침 문제를 해결할 수 있지만, 같은 위치에 콜라이더가 겹쳐있지 않은 오브젝트들은
        // 바깥쪽 줌용 콜라이더를 비활성화 할 필요가 없을 뿐더러, 비활성화 할 경우 줌인 후
        // 또다시 다른 오브젝트 줌 시 콜라이더가 비활성 상태로 남게 되어 다시 줌이 되지 않기 때문에 콜라이더 비활성 처리를 하지 않는다.
        {
            GetComponent<BoxCollider2D>().enabled = false;
            // 줌인한 오브젝트의 뒤에 있는 일부 오브젝트가 줌인한 오브젝트의 콜리이더 때문에 선택이 안 되는 경우가 존재하여
            // 줌인한 오브젝트의 콜라이더 제거
        }

        if (GameDirector.zoomedObject.Equals("Pot4_Room2")) // 만약 Room2에 있는 Pot4_Room2 오브젝트를 줌인했다면
        {
            GameObject.Find("Special_Book").GetComponent<BoxCollider2D>().enabled = false;
            // Special_Book 오브젝트의 콜라이더를 비활성화 시켜서 Sepcial_Book 오브젝트가 줌인되지 않도록 한다.
            // 옆에 있는 화분을 줌인한 상태에서 Special_Book 오브젝트를 줌인하면
            // Book_Open 오브젝트가 활성화 되며 뒤로 가기 버튼을 누를 수도 없고 닫기 버튼을 누를 수도 없는 상황이 발생하기 때문.
        }

        this.cameraMain.transform.position = new Vector3(this.transform.position.x + this.leftSet,
            this.transform.position.y, -10);
        // 카메라의 position 값을, 클릭한 오브젝트의 위치로 이동시킨다.
        /// 또한, x의 값에 보정값을 더하여 확대한 오브젝트가 인벤토리 때문에 오른쪽으로 쏠려보이는 오브젝트를
        /// 임의로 왼쪽으로 옮겨 보기 좋게 한다.

        this.cameraMain.GetComponent<Camera>().orthographicSize = 1.3f;
        // 메인 카메라는 원근감이 없기 때문에 orthographicSize로 zoom을 조정해주어야 한다.

        this.backButton.SetActive(true);   // 뒤로 가기 버튼 활성화 하기
    }
}
