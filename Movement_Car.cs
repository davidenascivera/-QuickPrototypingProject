using UnityEngine;
using System.Collections;

public class Movement_Car : MonoBehaviour
{

		private float moveSpeed = 0.4f;
		public GameObject my_object;
		public void Avanti()
		{
			my_object.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

		}
	public void Sinistra()
		{
		my_object.transform.Rotate(0, moveSpeed * Time.deltaTime * 100, 0);
	}

		public void Indietro()
		{
			my_object.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

	}
	public void Destra()
		{
		my_object.transform.Rotate(0, -moveSpeed * Time.deltaTime * 100, 0);

	}// Use this for initialization
	void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (Input.GetKey (KeyCode.UpArrow))
						my_object.transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		
				if (Input.GetKey (KeyCode.DownArrow))
						my_object.transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		
				if (Input.GetKey (KeyCode.LeftArrow))
						my_object.transform.Rotate (0, moveSpeed * Time.deltaTime * 100, 0);

				if (Input.GetKey (KeyCode.RightArrow))
						my_object.transform.Rotate (0, - moveSpeed * Time.deltaTime * 100, 0);

				if (Input.GetKey ("escape"))
						Application.Quit ();
			
		
		
		}
	
}