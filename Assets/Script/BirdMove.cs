using UnityEditor.Analytics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMove : MonoBehaviour
{
	[SerializeField] Vector3 startPos;
	[SerializeField] int MaxHits = 3;
	//[SerializeField] GameObject gameManager;

	//public void SetGameManager(GameObject gm) { gameManager = gm; }

	int HitCount = 0;


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "ball")
		{
			// GetComponent<BirdMove>().SetGameManager(gameManager);

			HitCount++;
			if (HitCount >= MaxHits)
			{
				Destroy(gameObject);

				SceneManager.LoadScene("ClearScenes");
			}
		}
	}

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		// ÇªÇÃèÍÇ≈è„â∫Ç…ìÆÇ≠
		float PosY = startPos.y + Mathf.Sin(Time.time) * 4;
		transform.position = new
			Vector3(transform.position.x, PosY, startPos.z);
    }
}
