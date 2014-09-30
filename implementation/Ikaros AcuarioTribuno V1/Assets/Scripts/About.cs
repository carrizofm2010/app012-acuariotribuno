using UnityEngine;
using System.Collections;

public class About : MonoBehaviour {
	
	public GUIStyle styleLabelIkaros;
	public GUIStyle styleBox;
	private Rect Caja;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	Caja=new Rect(0,0,Screen.width,Screen.height);
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}
	}
	
	void OnGUI() {
		
				GUI.Box(Caja,"", styleBox);

        GUILayout.BeginArea(new Rect(10, 10, Screen.width-20, Screen.height-20));
		GUILayout.BeginVertical();
        GUILayout.Label("",styleLabelIkaros, GUILayout.Height(Screen.height/20));
		
		GUILayout.EndVertical();
        GUILayout.EndArea();
		
    }
}
