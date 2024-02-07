using System.Collections;
using UnityEngine;

public class Swivel : MonoBehaviour
{
    public Transform target; // The target to swivel around
    public float swivelSpeed = 1.0f; // Speed of swiveling

    private bool isSwiveling = false;

    void Start()
    {
        // Start the swiveling process
        StartCoroutine(SwivelCamera());
    }

    IEnumerator SwivelCamera()
    {
        while (true)
        {
            // Swivel to the left
            yield return SwivelTo(-90f);

            // Pause for a moment
            yield return new WaitForSeconds(1.0f);

            // Swivel to the right
            yield return SwivelTo(90f);

            // Pause for a moment
            yield return new WaitForSeconds(1.0f);
        }
    }

    IEnumerator SwivelTo(float angle)
    {
        if (!isSwiveling)
        {
            isSwiveling = true;

            Quaternion targetRotation = Quaternion.Euler(0, angle, 0);

            while (Quaternion.Angle(transform.rotation, targetRotation) > 0.01f)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, swivelSpeed * Time.deltaTime);
                yield return null;
            }

            transform.rotation = targetRotation;
            isSwiveling = false;
        }
    }
}
