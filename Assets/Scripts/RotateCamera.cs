using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
    public float minYRotation = -30.0f; // Adjust this value for the minimum y-axis rotation
    public float maxYRotation = 30.0f; // Adjust this value for the maximum y-axis rotation

    void Update()
    {
        // Rotate the camera on the z-axis constantly
        RotateCameraZ();
    }

    void RotateCameraZ()
    {
        // Calculate the rotation amount
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Get the current rotation
        Vector3 currentRotation = transform.rotation.eulerAngles;

        // Calculate the new y-axis rotation
        float newYRotation = currentRotation.y + rotationAmount;

        if (newYRotation > 180.0f)
        {
            newYRotation -= 360.0f;
        }

        // Clamp the y-axis rotation within the specified range
        newYRotation = Mathf.Clamp(newYRotation, minYRotation, maxYRotation);

        // Apply the new rotation
        transform.rotation = Quaternion.Euler(currentRotation.x, newYRotation, currentRotation.z);
    }

    public void leftSlow()
    {
        rotationSpeed = -40f;

    }
    public void leftFast()
    {
        rotationSpeed = -80f;

    }
    public void rightSlow()
    {
        rotationSpeed = 40f;

    }
    public void rightFast()
    {
        rotationSpeed = 80f;

    }
    public void stopMiddle()
    {
        rotationSpeed = 0f;
    }

   
}
