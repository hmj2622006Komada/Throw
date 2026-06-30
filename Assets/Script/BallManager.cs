using System.Threading;
using UnityEngine;

public class BallManager : MonoBehaviour
{
	[SerializeField] GameObject ball;

	//[SerializeField] GameObject gameManager;

	//public void SetGameManager(GameObject gm) { gameManager = gm; }


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "bird")
		{
			//GetComponent<BirdMove>().SetGameManager(gameManager);


			Destroy(gameObject);
		}
	}

	//private void OnTriggerEnter2D(Collider2D collision)
	//{
	//	Debug.Log("ダメージ");
	//	//Destroy(collision.gameObject);
	//}

	void Start()
	{
		// 3秒後にこのゲームオブジェクトを削除する
		Destroy(gameObject, 3.0f);
	}
}