using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaySoundButton : MonoBehaviour
{
    public Button myButton;           // Reference to the UI Button
    public AudioSource audioSource;   // Reference to the AudioSource component
    public string nextSceneName;      // Name of the scene to load

    void Start()
    {
        // Attach the PlayAndChangeScreen method to the button click event
        myButton.onClick.AddListener(PlayAndChangeScreen);
    }

    void PlayAndChangeScreen()
    {
        // Play the sound
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();

            // Load the next scene after the sound finishes
            Invoke("LoadNextScene", audioSource.clip.length);
        }
        else
        {
            // If there's no sound, immediately load the next scene
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(nextSceneName);
    }
}
