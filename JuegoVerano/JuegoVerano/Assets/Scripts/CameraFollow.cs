using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


	public Vector2 offset = new Vector2 (0.06f, 0.06f);

	public float dampTime = 0.4f;
	private Vector3 velocity = Vector3.zero;
    private Transform target;


	void Awake() {
		Application.targetFrameRate = 60;
        target = FindObjectOfType<PlayerScript>().GetComponent<Transform>(); //TODO Mismo problema que en el otro, hay que meter en las otras funciones el Find

    }


	public void ResetToStartPosition() {
        target = FindObjectOfType<PlayerScript>().GetComponent<Transform>();
        Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);
		Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(offset.x, offset.y, point.z));
		Vector3 destination = transform.position + delta;
		
		destination = new Vector3(destination.x, offset.y, destination.z);
		transform.position = destination;
	}


	void Update () {
        target = FindObjectOfType<PlayerScript>().GetComponent<Transform>();
        Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);
		Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(offset.x, offset.y, point.z));
		Vector3 destination = transform.position + delta;

		destination = new Vector3(destination.x, offset.y, destination.z);

		transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		

	}
}
