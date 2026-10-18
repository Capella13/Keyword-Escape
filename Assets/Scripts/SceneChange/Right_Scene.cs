using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Right_Scene : MonoBehaviour
{
    [SerializeField] string rightScene;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(rightScene);
    }
}
