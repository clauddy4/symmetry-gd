using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene("LevelChoice");
    }
}
