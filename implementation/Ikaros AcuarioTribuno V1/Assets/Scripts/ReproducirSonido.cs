using UnityEngine;
using System.Collections;

public class ReproducirSonido : MonoBehaviour {
	public AudioClip sonidoAcuario;
	


	// Use this for initialization
	void Start () {
	 //playSoundAmbient();
	}
	
	// Update is called once per frame
	void Update () {
	

	}
	/*Reproducir sonido*/
	public void playSoundAcuario(){
		  Debug.Log("ingreso al metodo de sonido");
		  audio.PlayOneShot(sonidoAcuario);
	}


}
