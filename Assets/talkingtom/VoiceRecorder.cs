using UnityEngine;
using System.Collections;

public class VoiceRecorder : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioClip recordedClip;

    void Start()
    {
        // Attach AudioSource to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void StartRecording()
    {
        // Start recording from the microphone (up to 10 seconds)
        recordedClip = Microphone.Start(null, false, 10, 44100);
    }

    public void StopRecording()
    {
        // Stop recording
        Microphone.End(null);
        // Assign the recorded clip to the AudioSource
        audioSource.clip = recordedClip;
        PlayWithCatVoice();
    }

    void PlayWithCatVoice()
    {
       
        audioSource.pitch = 1.5f; // Adjust pitch for cat-like effect
        audioSource.Play(); // Play the recorded audio
    }

    public void StopPlayback()
    {
        audioSource.loop = false; // Disable looping
        audioSource.Stop(); // Stop the audio playback
    }
}
