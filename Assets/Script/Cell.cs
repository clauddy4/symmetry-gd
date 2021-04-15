using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cell : Field
{
    public GameObject cell;

    public bool isRight = false;
    private int clicks = 0;
    public int clicksToWin;

        void Start() {
        if (clicks == clicksToWin) {
            isRight = true;
        }
    }

    public void RotateCellOnClick() {
        cell.transform.Rotate(0, 0, -90);

        clicks++;

        if (GetRightClicksCount()) {
            isRight = true;
        } else {
            isRight = false;
        }
        Debug.Log(isRight);
    }

    private bool GetRightClicksCount() {
        if (clicks == clicksToWin) {
            return true;
        } else {
            for (int i = 1; i <= 50; i++) {
                if (clicks == 4*i + clicksToWin) {
                    return true;
                }
            }
            return false;
        }
    }
}
