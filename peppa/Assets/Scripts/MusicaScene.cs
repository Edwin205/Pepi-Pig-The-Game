using UnityEngine;
using System.Collections;

public class MusicaScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
	audio.Play ();
	Invoke ("CargarNivelJuego",audio.clip.length);
	
}
void CargarNivelJuego(){
	Application.LoadLevel ("ColoresScene");
}

}
