using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class UIAnimation : MonoBehaviour {

    private Animator animator;

    public bool IsOpened
    {
        get { return animator.GetBool("IsOpened"); }
        set
        {
            if (!gameObject.activeInHierarchy) gameObject.SetActive(true);
            animator.SetBool("IsOpened", value);
            
        }
    }

    void OnEnable()
    {
        if (animator) return;
        animator = GetComponent<Animator>();
    }

    
}
