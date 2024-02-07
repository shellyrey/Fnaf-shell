using UnityEngine;

public class DoorDownUp : MonoBehaviour
{
    private Animator animator;
    private bool closedDoor = false;
    public GameObject doorDown;
    public GameObject doorUp;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Perform a raycast from the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits a GameObject
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit GameObject has the ClickableObject script attached
                DoorDownUp clickedObject = hit.transform.GetComponent<DoorDownUp>();

                if (clickedObject != null && clickedObject == this)
                {
                    // Call a method or perform an action when the GameObject is clicked
                    clickedObject.Door1();
                }
            }
        }
    }

    void Door1()
    {
        if (!closedDoor) // Check if the door is not closed
        {
            doorDown.SetActive(true);
            closedDoor = true;
            doorUp.SetActive(false); // Make sure doorUp is not active when closing the door
        }
        else if (Input.GetMouseButton(0)) // Check if the left mouse button is clicked
        {
            doorDown.SetActive(false);
            closedDoor = false;
            doorUp.SetActive(true);
        }
    }
}
