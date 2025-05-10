using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;
    public AnimationClip[] animationClips;

    private void Reset()
    {
        // Automatically try to find the Animator component if not assigned.
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    // This method can be used to manually play an animation via script.
    public void PlayAnimation(string animationName)
    {
        if (animator != null)
        {
            animator.Play(animationName);
        }
    }

    // Add more methods for handling animation logic if necessary
}