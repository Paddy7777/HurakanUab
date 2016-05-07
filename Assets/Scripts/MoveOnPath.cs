using UnityEngine;
using System.Collections;

public class MoveOnPath : MonoBehaviour {

	public PathEditor PathToFollow;

	public int currentWayID = 0;
	public float speed;
	private float reachDistance = 1.0f;
	public float rotationSpeed = 5.0f;
	public string pathName;



	Vector3 lastPosition;
	Vector3 currentPosition;

	// Use this for initialization
	void Start () {
		// PathToFollow = GameObject.Find (pathName).GetComponent<PathEditor> ();
		lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (PathToFollow.pathObjects [currentWayID].position, transform.position);
		transform.position = Vector3.MoveTowards (transform.position, PathToFollow.pathObjects [currentWayID].position, Time.deltaTime * speed);
		var rotation = Quaternion.LookRotation (PathToFollow.pathObjects [currentWayID].position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationSpeed);
		 


		if (distance <= reachDistance) {
			currentWayID++; 
		}

		if (currentWayID >= PathToFollow.pathObjects.Count) {
			currentWayID = 0;
		}
	}
}
