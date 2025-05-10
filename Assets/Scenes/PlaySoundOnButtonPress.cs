using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnButtonPress : MonoBehaviour
{
    public Button yourButton;  // Assign your button in the Inspector
    public AudioClip soundClip;  // Assign your sound clip in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        // Create an AudioSource component if it doesn't already exist
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundClip;

        // Make sure the AudioSource plays only once when triggered
        audioSource.playOnAwake = false;

        // Assign the button click event
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(PlaySound);
        }
    }

    // Method to play the sound
    private void PlaySound()
    {
        if (audioSource != null && soundClip != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource or sound clip is not set!");
        }
    }
}
