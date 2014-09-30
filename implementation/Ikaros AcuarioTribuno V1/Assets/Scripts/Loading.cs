using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {
  public GUITexture guiTextureLoading;
	public Texture loading;

	void Start () {
		guiTextureLoading.guiTexture.texture=loading;
		this.SituarLoading();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void SituarLoading(){
	//DERECHA
    guiTextureLoading.transform.position = Vector3.zero;
    guiTextureLoading.transform.localScale = Vector3.zero; 
	guiTextureLoading.guiTexture.pixelInset=new Rect(Screen.width/2-100,Screen.height/2-100,200,200);
  }

}
