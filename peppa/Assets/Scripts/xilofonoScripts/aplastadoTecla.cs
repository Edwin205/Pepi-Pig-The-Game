using UnityEngine;
using System.Collections;

public class aplastadoTecla : MonoBehaviour {

	private Animator animator;



	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update(){
		

			
		
	}
	
	void OnMouseDown(){
		audio.Play ();


		animator.SetInteger ("tocado", 1);
}
	void OnMouseUp(){
		animator.SetInteger ("tocado", 0);

	}

}