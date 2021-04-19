using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject victoryUI;

    private int point;

    void Update() {
        GameObject[] cells;
        
        cells = GameObject.FindGameObjectsWithTag("cell");
        point = 0;

        foreach (GameObject cell in cells) {
            Cell c = cell.GetComponent<Cell>();

            if (c.isRight) {
                point++;
            }
        }
        if (point == cells.Length) {
            victoryUI.SetActive(true);
        } 
    }
}
