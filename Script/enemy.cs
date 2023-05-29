using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	public float m_minSpeed = -0.01f;
	public float m_maxSpeed = -0.01f;
	private float m_speed = 0.0f;
	// Use this for initialization
	void Start () {
		m_speed = Random.Range (m_minSpeed, m_maxSpeed);
		Debug.Log (m_speed);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector2 (m_speed, 0));
	}
}
