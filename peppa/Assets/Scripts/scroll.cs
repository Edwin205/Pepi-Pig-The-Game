using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	public float velocidad = 0f;
	private float tiempoInicio = 0f;

	// Use this for initialization
	void Start () {

	}




	
	// Update is called once per frame
	void Update () {

			renderer.material.mainTextureOffset = new Vector2(((Time.time - tiempoInicio) * velocidad) % 1, 0);

	}
}
