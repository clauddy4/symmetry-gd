using UnityEngine;

namespace Script
{
    public class Cell : Field
    {
        public GameObject cell;

        public bool isRight;
        public int clicksToWin;
        private int clicks;

        private void Start()
        {
            if (clicks == clicksToWin) isRight = true;
        }

        public void RotateCellOnClick()
        {
            PlaySound();
            cell.transform.Rotate(0, 0, -90);

            clicks++;

            if (GetRightClicksCount())
                isRight = true;
            else
                isRight = false;
        }

        private bool GetRightClicksCount()
        {
            if (clicks == clicksToWin)
            {
                return true;
            }

            for (var i = 1; i <= 50; i++)
                if (clicks == 4 * i + clicksToWin)
                    return true;
            return false;
        }

        private void PlaySound()
        {
            if (PlayerPrefs.GetString("music") != "No")
                GetComponent<AudioSource>().Play();
        }
    }
}