using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour {
	 Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
	       animator.SetBool("Walk", true);
		}
		if(Input.GetKeyUp(KeyCode.W))
		{
	        animator.SetBool("Walk", false);
		}
	}
}
