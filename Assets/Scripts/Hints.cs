using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour {

    public Animator animator;

	public void hintBoxOpen () {
        animator.SetBool("isOpen", true);
	}

    public void hintBoxClose()
    {
        animator.SetBool("isOpen", false);

    }


}
