using UnityEngine;
using System.Collections;
public class GameOverChecker : MonoBehaviour
{
	// 1
	public GameObject m_gameOver;
	// 2
	private bool m_isOver = false;
	void Start ()
	{
	}
	
	void Update ()
	{
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		// 3
		if (other.gameObject.tag == "Enemy")
		{
			// 4
			if(m_isOver == false)
			{
			// 5
				m_isOver = true;
				// 6
				m_gameOver.SetActive(true);
				// 7
				StartCoroutine("restartGame");
			}
		}
		Destroy (other.gameObject);
	}
	private IEnumerator restartGame()
	{
		// 8
		yield return new WaitForSeconds (5.0f);
		// 9
		Application.LoadLevel("main");
		yield return null;
	}
}