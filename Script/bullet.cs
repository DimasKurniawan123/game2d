using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
	
	public float m_speed = 0.3f;
	void Start ()
	{
	// 2
	Destroy (gameObject, 3.0f);
	}
	void Update ()
	{
	// 3
	transform.position += transform.right * m_speed;
	}
	
		// 1
	void OnTriggerEnter2D(Collider2D other)
	{
	// 2
		if (other.gameObject.tag == "Enemy")
		{
		// 3
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}

}
