using UnityEngine;
using System.Collections;

public class MusicaOff : MonoBehaviour {
	bool botonAplastado = true ;
	private Animator animator;

	// Use this for initialization
	void Start () {
				animator = GetComponent<Animator> ();
		}
	
	// Update is called once per frame
	void   Update () {


			
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown(0)&&botonAplastado==false) {
			audio.Pause();
			botonAplastado= true;
			animator.SetInteger ("tocado", 0);
		}
		else if (Input.GetMouseButtonDown (0) && botonAplastado == true) {
			audio.Play();
			botonAplastado=false;
			animator.SetInteger ("tocado", 1);
		}


	}



}