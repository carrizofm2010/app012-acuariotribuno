using UnityEngine;
using System.Collections;

public class Salir : MonoBehaviour {
	void Update () {
			if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);// saliendo de la aplicacion
		}
	
	}
}
