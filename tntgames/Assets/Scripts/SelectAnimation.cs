using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class SelectAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        Animator animator = GetComponent<Animator>();
        if(animator != null)
        {
            animator.Play("MenuButtonAnimation");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer Exit");

    }

}
