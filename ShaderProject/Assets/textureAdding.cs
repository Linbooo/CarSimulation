using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textureAdding : MonoBehaviour {

	void Start()
	    {
	        Texture2D texture = new Texture2D(4, 4);
	        GetComponent<Renderer>().material.mainTexture = texture;
					texture.filterMode = FilterMode.Point;
					texture.wrapMode = TextureWrapMode.Clamp;
	        for (int y = 0; y < texture.height; y++)
	        {
	            for (int x = 0; x < texture.width; x++)
	            {
	                //Color color = ((x & y) != 0 ? Color.white : Color.gray);
	                //texture.SetPixel(x, y, color);
									Color color;
									if(x%2 == 0){
										if(y%2 != 0){


											color = Color.blue;
										}else{
											color = Color.red;
										}
									}else{
										if(y%2 == 0){
											color = Color.blue;
										}else{
											color = Color.red;
										}
									}
									texture.SetPixel(x,y, color);

	            }
	        }
	        texture.Apply();
					Color pixel_colour = texture.GetPixel(0, 1);
					Debug.Log("pixel color is : " + pixel_colour);
					Debug.Log("Size is " + texture.width + " by " + texture.height);


					float width = GetComponent<Renderer>().bounds.size.x;
					float height = GetComponent<Renderer>().bounds.size.z;
					Debug.Log("bounds.size.x : " + width);
					Debug.Log("bounds.size.z : " + height);

	    }


}
