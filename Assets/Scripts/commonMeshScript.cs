using UnityEngine;
using System.Collections;

public class commonMeshScript : MonoBehaviour {

	public string sortingLayer;
	void Start ()
	{
		var renderer = GetComponent<MeshRenderer>();
		renderer.sortingLayerName = sortingLayer;
	}
	/*
	 * void OnTriggerEnter(Collider col)
	{
		Debug.Log ("OnTriggerEnter");
		switch(col.tag)
		{
		case "Expectedplatform":
			//Debug.Log ("Expectedplatform");
			if(Input.anyKeyDown)
			{
				Debug.Log ("key pressed");
			}
			break;
		}
		if(Input.anyKeyDown)
		{
			if(col.tag=="Expectedplatform")
			{
				Debug.Log ("key pressed on Expectedplatform");
			}
			else
			{
				Debug.Log("game over");
			}
		}
	}//OnTriggerEnter()
*/
}
