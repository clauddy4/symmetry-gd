using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LoseController : MonoBehaviour {

    public GameObject loseUI;
    public Text movesLeftText;

    public int moves;

    void Start() {
        movesLeftText.text = "MOVES LEFT: <size=26>" + moves + "</size>";
    }

    public void loseController() {
        moves--;
        movesLeftText.text = "MOVES LEFT: <size=26>" + moves + "</size>";

        if (moves == 0) {
            loseUI.SetActive(true);
        }
    }
}
