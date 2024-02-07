using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light flickerLight;
    public float minimumIntensity = 0.8f;
    public float maximumIntensity = 3f;

    private void Update()
    {
        flickerLight.intensity = Random.Range(minimumIntensity, maximumIntensity);
    }


}
