using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Right_Scene : MonoBehaviour
{
    [SerializeField] string rightScene; // 오른쪽 씬 이름

    private void OnMouseDown()
    {
        SceneManager.LoadScene(rightScene); // 오른쪽 씬으로 이동
    }
}
