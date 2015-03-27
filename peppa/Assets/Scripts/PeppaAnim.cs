using UnityEngine;
using System.Collections;

public class PeppaAnim : MonoBehaviour {
	private Animator animator;
	
	
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update(){
		
		if(Input.GetMouseButton(0))
			animator.SetInteger ("tocado", 1);
		else
		animator.SetInteger ("tocado", 0);
	}

		

		
		


}