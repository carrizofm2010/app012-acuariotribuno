using UnityEngine;
using System.Collections;

public class ReproducirAnimacion : MonoBehaviour {
	
	private Animation animacion;

	public Transform modelo3D;
	private float speed=0.4f;
	public float tiempoAnimacion=0;
	public float tiempoTotal=0;
	public float velicidadAnimacion=0 ;
	private bool banderaAcuario= true;
	
	//public int contador=0;
	// Use this for initialization
	
	public Transform marker;
	private DefaultTrackableEventHandler defaultTrackeableEventHandler;
	private ReproducirSonido soundPlay;
	
	void Start () {
	  animacion = modelo3D.GetComponentInChildren<Animation>();
	  this.animarPersonaje();
	
	  defaultTrackeableEventHandler = marker.GetComponent<DefaultTrackableEventHandler>();
	  soundPlay = GetComponent<ReproducirSonido>();
	}
	
	// Update is called once per frame
	void Update () {
		
		soundPlay.playSoundAcuario();

		if (defaultTrackeableEventHandler.GetFlagMarker()){
			if(banderaAcuario){
				soundPlay.playSoundAcuario();
				banderaAcuario=false;
			}
		velicidadAnimacion=animacion["AnimacionShark"].speed;
		tiempoAnimacion=animacion["AnimacionShark"].time;
	   tiempoTotal=animacion["AnimacionShark"].length;
		if(tiempoAnimacion==0){
			this.animarPersonaje();
		}	
		
		}
	}
	
	public void animarPersonaje(){
		tiempoAnimacion=animacion["AnimacionShark"].time;
		animacion["AnimacionShark"].layer = 2;
	    animacion["AnimacionShark"].wrapMode=WrapMode.Once;
		animacion["AnimacionShark"].speed=speed;
		animacion.Play("AnimacionShark");
		audio.Play();

	}

}
