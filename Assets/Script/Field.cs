using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Field : MonoBehaviour
{
    public GameObject victoryUI;
    public Text movesLeft;

    public Image stars;
    public Sprite stars3, stars2, stars1;

    private string movesTxt;
    private int movesInt;

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

            movesTxt = movesLeft.text.Remove(0, 21);
            movesTxt = movesTxt.Trim( new Char[] { '<', '/', 's', 'i', 'z', 'e', '>' } );
            movesInt = Int32.Parse(movesTxt);

            if (movesInt >= 6) {
                stars.sprite = stars3;
            } else if (movesInt >= 4) {
                stars.sprite = stars2;
            } else {
                stars.sprite = stars1;
            }
        } 
    }
}
