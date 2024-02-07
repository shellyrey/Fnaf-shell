using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
public class InvisButton : MonoBehaviour, IPointerExitHandler
{

    public GameObject invis;
    public GameObject camDown;

        public void OnPointerExit(PointerEventData eventData)
        {
            Debug.Log("Mouse left the button");
        camDown.SetActive(true);
        invis.SetActive(false);

        }
    }

