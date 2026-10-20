using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCabinet : MonoBehaviour
{
    [SerializeField] GameObject openDoor; // 문이 열려 있는 오브젝트

    private void OnMouseDown()
    {
        openDoor.SetActive(true); // 문이 열려 있는 오브젝트 활성화
    }
}
