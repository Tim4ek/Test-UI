using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIAnimButton : MonoBehaviour, IPointerClickHandler {

    private UIAnimation current;
    [SerializeField]
    public UIAnimation next;


    void Awake()
    {
        current = GetComponentInParent<UIAnimation>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        next.IsOpened = current.IsOpened;
        current.IsOpened = !current.IsOpened;
    }
}
