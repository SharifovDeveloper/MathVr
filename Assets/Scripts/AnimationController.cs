using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private bool isAnimationOn = false;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for input or any condition to toggle animation on/off
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Toggle the boolean parameter to turn on/off the animation
            isAnimationOn = !isAnimationOn;

            // Set the boolean parameter in the Animator controller
            animator.SetBool("IsAnimationOn", isAnimationOn);
        }
    }
}
