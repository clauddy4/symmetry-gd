using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    private int point;
    public int moves;

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
            Debug.Log("Win");
        } 
    }


}
