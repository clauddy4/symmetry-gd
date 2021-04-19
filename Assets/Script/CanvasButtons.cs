using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseMenuUI;

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

    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void Pause() {
        PlaySoundOnClick();

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
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
