using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();

        // Start the glitch effect
        StartCoroutine(PlayGlitchAnimation());
    }

    private System.Collections.IEnumerator PlayGlitchAnimation()
    {
        while (true)
        {
            // Randomize the playback speed
            float randomSpeed = Random.Range(0.5f, 2.0f);
            animator.speed = randomSpeed;

            // Randomize the time of the animation
            float randomTime = Random.Range(0f, animator.GetCurrentAnimatorStateInfo(0).length);
            animator.Play("ChicaTweaking", 0, randomTime);

            // Wait for a random duration before the next glitch
            float glitchDuration = Random.Range(0.5f, 2.0f);
            yield return new WaitForSeconds(glitchDuration);
        }
    }
}
