using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject leftLight;
    void Update()
        
    {
        // Check for mouse click
        if (Input.GetMouseButton(0))
        {
            // Perform a raycast from the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits a GameObject
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit GameObject has the ClickableObject script attached
                Button clickedObject = hit.transform.GetComponent<Button>();

                if (clickedObject != null)
                {
                    // Call a method or perform an action when the GameObject is clicked
                    clickedObject.OnClick();
                }
            }
        }
        else
        {
            // Disable leftLight when the mouse is not clicking the GameObject
            leftLight.SetActive(false);
        }
    }

    // Method to be called when the GameObject is clicked
    void OnClick()
    {
        leftLight.SetActive(true);

        // Your action or logic here
        Debug.Log("GameObject Clicked: " + gameObject.name);
    }
}
