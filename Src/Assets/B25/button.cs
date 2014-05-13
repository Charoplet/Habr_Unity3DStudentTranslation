using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	public Texture2D normalTex;
    public Texture2D hoverTex;
 
    private void OnMouseEnter() 
    {
        guiTexture.texture = hoverTex;
    }

    private void OnMouseExit()
    {
        guiTexture.texture = normalTex;
    }

    private void OnMouseDown()
    {
        Debug.Log("clicked");
    }
}
