using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CellController : MonoBehaviour
{
    public GameObject cell;

    private int clicks = 0;
    public int clicksToWin;

    public int winPoint = 0;

    void Start() {
        if (clicks == clicksToWin)
            winPoint++;
    }

    void Update() {
        if (winPoint == 7) 
            Debug.Log("Win!");
    }

    public void RotateCellOnClick() {
        cell.transform.Rotate(0, 0, -90);

        clicks++;

        if (clicks == clicksToWin || clicks % clicksToWin + 4 == 0)
            winPoint++;
    }
}
