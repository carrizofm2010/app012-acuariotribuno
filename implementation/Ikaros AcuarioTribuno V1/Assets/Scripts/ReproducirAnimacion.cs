using UnityEngine;
using System.Collections;

public class ReproducirAnimacion : MonoBehaviour {
	
	private Animation animacion;

	public Transform modelo3D;
	private float speed=0.4f;
	public float tiempoAnimacion=0;
	public float tiempoTotal=0;
	public float velicidadAnimacion=0 ;
	//public int contador=0;
	// Use this for initialization
	void Start () {
	  animacion = modelo3D.GetComponentInChildren<Animation>();
	  this.animarPersonaje();

	}
	
	// Update is called once per frame
	void Update () {
		
		velicidadAnimacion=animacion["AnimacionShark"].speed;
		tiempoAnimacion=animacion["AnimacionShark"].time;
	   tiempoTotal=animacion["AnimacionShark"].length;
		if(tiempoAnimacion==0){
			this.animarPersonaje();
		}	
	
	}
	
	public void animarPersonaje(){
		tiempoAnimacion=animacion["AnimacionShark"].time;
		animacion["AnimacionShark"].layer = 2;
	    animacion["AnimacionShark"].wrapMode=WrapMode.Once;
		animacion["AnimacionShark"].speed=speed;
		animacion.Play("AnimacionShark");
	}

}