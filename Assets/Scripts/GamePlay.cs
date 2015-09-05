using UnityEngine;
using System.Collections;

public class GamePlay : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public Transform cameraTransform;
	private GameObject temp1;
	private GameObject temp2;
	 
	// Use this for initialization
	void Start () {
		temp1=player2;
		temp2=player1;

	//	RaycastHit hit;
	
	}

	// Update is called once per frame
	void Update () {

		temp1.transform.RotateAround(temp2.gameObject.transform.position, Vector3.up, 200 * Time.deltaTime);

		RaycastHit hit;
		Vector3 diff = player2.transform.position-cameraTransform.position;
		float scale = 1.15f;

		Ray ray = new Ray(cameraTransform.position, diff);
		LayerMask mask = LayerMask.GetMask("BoxLayer");
		if(Input.anyKeyDown)
		{
			if (Physics.Raycast(ray, out hit, diff.magnitude*scale, mask.value))
			{
				Debug.Log (hit.transform.name);
				Debug.DrawLine(ray.origin, hit.point,Color.red);
				temp1.transform.position=hit.transform.position;
				temp1.transform.rotation=hit.transform.rotation;

				temp1=player1;
				temp2=player1;
			}
			else
			{
				Debug.DrawLine(cameraTransform.position, cameraTransform.position+diff*scale, Color.blue);
				Debug.Log ("Game over");
			}
		}
		/*
		Physics.Raycast(temp1.transform.position, Vector3.down, 20); 
		Physics.Raycast(temp1.transform.position, Vector3.right, 20);
		Debug.DrawLine(temp1.transform.position, Vector3.right, Color.blue);

		if(Input.anyKeyDown)
		{
			Debug.Log ("key pressed");
		}*/
	}//Update()

}//MonoBehaviour
