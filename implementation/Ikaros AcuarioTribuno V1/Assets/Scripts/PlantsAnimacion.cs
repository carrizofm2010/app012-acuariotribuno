using UnityEngine;
using System.Collections;

public class PlantsAnimacion: MonoBehaviour {
	
	private Animation animacion;

	public Transform modelo3D;
	private float speed=0.2f;
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
		
		velicidadAnimacion=animacion["AnimacionPlants"].speed;
		tiempoAnimacion=animacion["AnimacionPlants"].time;
	   tiempoTotal=animacion["AnimacionPlants"].length;
		if(tiempoAnimacion==0){
			this.animarPersonaje();
		}	
	
	}
	
	public void animarPersonaje(){
		tiempoAnimacion=animacion["AnimacionPlants"].time;
		animacion["AnimacionPlants"].layer = 2;
	    animacion["AnimacionPlants"].wrapMode=WrapMode.Once;
		animacion["AnimacionPlants"].speed=speed;
		animacion.Play("AnimacionPlants");
	}

}
