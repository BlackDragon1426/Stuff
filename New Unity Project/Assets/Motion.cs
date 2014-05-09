using UnityEngine;
using System.Collections;

public class Motion : MonoBehaviour
{
	// Update is called once per frame
	void FixedUpdate()
	{
		Vector3 input = new Vector3(Input.GetAxis("Horizontal"),0,0);
		float speed = 10;

		transform.position += input * speed * Time.deltaTime;
	}
}
