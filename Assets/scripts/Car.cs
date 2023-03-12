using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	float minSpeed = 8f * sceneManager.carSpeed;
	float maxSpeed = 12f * sceneManager.carSpeed;

	float speed = 1f;

	void Start ()
	{
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

}
