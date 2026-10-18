using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Left_Scene : MonoBehaviour
{
    [SerializeField] string leftScene;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(leftScene);
    }
}
