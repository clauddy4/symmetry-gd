using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotateCell : MonoBehaviour
{
    public GameObject cell;

    public void RotateCellOnClick() {
        cell.transform.Rotate(0, 0, -90);
    }
}
