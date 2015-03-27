using UnityEngine;
using System.Collections;

public class letrasEspanol : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		
		
		audio.Play ();
		Invoke ("CargarNivelJuego",audio.clip.length);
		animator.SetInteger ("tocado", 1);
	}
	void OnMouseUp(){
		animator.SetInteger ("tocado", 0);
	}
	void CargarNivelJuego(){
		Application.LoadLevel ("letrasEspanolScene");
	}
}
