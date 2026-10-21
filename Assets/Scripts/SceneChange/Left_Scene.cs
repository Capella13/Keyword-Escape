using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Left_Scene : MonoBehaviour
{
    [SerializeField] string leftScene;  // ¿ŞÂÊ ¾À ÀÌ¸§

    private void OnMouseDown()
    {
        SceneManager.LoadScene(leftScene);  // ¿ŞÂÊ ¾ÀÀ¸·Î ÀÌµ¿
    }
}
