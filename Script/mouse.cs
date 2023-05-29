using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour {

	public GameObject m_bullet;
	void Start ()
	{
	
	}
	void Update ()
	{
	// 2
		if (Input.GetMouseButtonDown(0))
		{
		fire();
		}
	}
	private void fire()
	{
		// 1
		Vector3 mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		GameObject bullet = Instantiate (m_bullet) as GameObject;
		bullet.transform.position = transform.position;
		// 2
		float rad = Mathf.Atan2 (mouse.y - transform.position.y, mouse.x -
		transform.position.x);
		// 3
		bullet.transform.Rotate (new Vector3(0,0, Mathf.Rad2Deg * rad));
	}
}
