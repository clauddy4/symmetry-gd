using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class LoseController : MonoBehaviour
    {
        public GameObject loseUI;
        public Text movesLeftText;

        public int moves;

        private void Start()
        {
            movesLeftText.text = "MOVES LEFT: <size=76>" + moves + "</size>";
        }

        public void loseController()
        {
            moves--;
            movesLeftText.text = "MOVES LEFT: <size=76>" + moves + "</size>";

            if (moves == 0) loseUI.SetActive(true);
        }
    }
}