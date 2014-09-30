using UnityEngine;
using System.Collections;

public class DibujarPantalla : MonoBehaviour {

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
		if(Input.GetKeyDown(KeyCode.Menu)||Input.GetKey(KeyCode.M))
		{
		    Application.LoadLevel("About");
		}
	}
	 
}
