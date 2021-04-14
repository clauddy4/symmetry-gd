using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseMenuUI;

    public GameObject cells;

    public Sprite musicOn, musicOff;

    private void Start() {
        if (PlayerPrefs.GetString("music") == "No" && gameObject.name == "Music") 
            GetComponent<Image>().sprite = musicOff;
    }

    public void Play() {
        SceneManager.LoadScene("LevelChoice");
    }

    public void Replay() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Close() {
        SceneManager.LoadScene("Main");
    }

    public void LoadScene() {
        SceneManager.LoadScene(gameObject.name);
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        cells.SetActive(true);
        isGamePaused = false;
    }

    public void Pause() {
        PlaySoundOnClick();

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        cells.SetActive(false);
        isGamePaused = true;
    }

    public void PlayMusic() {
        
        if (PlayerPrefs.GetString("music") == "No") {
            PlayerPrefs.SetString("music", "Yes");
            GetComponent<Image>().sprite = musicOn;
        } else {
            PlayerPrefs.SetString("music", "No");
            GetComponent<Image>().sprite = musicOff;
        } 
    }

    public void PlaySoundOnClick() {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
    }
}
