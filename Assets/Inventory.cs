using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static GameObject[] items;       // Hierarchy에 있는 inventory
    // Start is called before the first frame update
    void Start()
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
}
