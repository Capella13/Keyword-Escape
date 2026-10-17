using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public bool selected = false;

    private void OnMouseDown()
    {
        selected = true;
    }
}
