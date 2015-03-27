using UnityEngine;
using System.Collections;

public class PeppaAda : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
		animator.SetInteger ("tocado", 1);

       else 
			animator.SetInteger ("tocado", 0);
	}
	
	void OnMouseDown(){
		
		
		audio.Play ();

		animator.SetInteger ("tocado", 1);
	}
	void OnMouseUp(){
		animator.SetInteger ("tocado", 0);
	}
}