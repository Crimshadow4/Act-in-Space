using UnityEngine;
using UnityEngine.UI;


public class ScoreHealth : MonoBehaviour {
	public int ScoreCount = 0;
	int cnt = 0;
	public Text ScoreText;
	public GameObject player;
	public PlayerHealth playerHealth;
	// Use this for initialization

	void Start () 
	{
		playerHealth = player.GetComponent<PlayerHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		cnt++;
		if (cnt > 20) {
			ScoreCount++;
			cnt = 0;
		}
		ScoreText.text = "Score: " + ScoreCount.ToString () + "\n" + "Health: " + playerHealth.currentHealth.ToString();
	}
}
