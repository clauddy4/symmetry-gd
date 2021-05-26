using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class Field : MonoBehaviour
    {
        public GameObject victoryUI, fireworks;
        public Text movesLeft;

        public Image stars;
        public Sprite stars3, stars2, stars1;
        private bool coroutineIsRunning;
        private int movesInt;

        private string movesTxt;
        private int point;

        private void Update()
        {
            GameObject[] cells;

            cells = GameObject.FindGameObjectsWithTag("cell");
            point = 0;

            foreach (var cell in cells)
            {
                var c = cell.GetComponent<Cell>();

                if (c.isRight) point++;
            }

            if (point == cells.Length)
            {
                Instantiate(fireworks, new Vector2(0, 0), Quaternion.identity);

                if (!coroutineIsRunning)
                {
                    coroutineIsRunning = true;
                    StartCoroutine(makeWin(1f));
                }

                movesTxt = movesLeft.text.Remove(0, 21);
                movesTxt = movesTxt.Trim('<', '/', 's', 'i', 'z', 'e', '>');
                movesInt = int.Parse(movesTxt);

                if (movesInt >= 6)
                    stars.sprite = stars3;
                else if (movesInt >= 4)
                    stars.sprite = stars2;
                else
                    stars.sprite = stars1;
            }
        }

        private IEnumerator<WaitForSeconds> makeWin(float time)
        {
            yield return new WaitForSeconds(time);
            victoryUI.SetActive(true);
        }
    }
}