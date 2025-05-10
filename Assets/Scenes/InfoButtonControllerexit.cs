using UnityEngine;
using UnityEngine.UI;

public class InfoButtonControllerexit : MonoBehaviour
{
    public GameObject infoPanel;        // Reference to the info panel
    public AudioSource audioSource;     // Reference to the AudioSource component

    private void Start()
    {
        // Ensure the panel is hidden at the start
        if (infoPanel != null)
        {
            infoPanel.SetActive(false);
        }
    }

    // Method to show the panel and play the audio
    public void ShowPanel()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
            
            // Play the audio if it is not already playing
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    // Method to hide the panel and stop the audio
    public void HidePanel()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(false);
            
            // Stop the audio if it is playing
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
