using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveManager : MonoBehaviour
{
	
	Rigidbody2D rb;
	[SerializeField] GameObject prefabToThrow;
	[SerializeField] Transform throwPoint;
	[SerializeField] float throwForce = 10f;
	[SerializeField] float RightForce = 10f;

	//SpriteRenderer spriteRenderer;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		
	}

	private void Update()
	{
		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			Throw();
		}
		
	}

	void Throw()
	{
		// オブジェクトの複製
		GameObject obj = Instantiate(prefabToThrow, throwPoint.position, throwPoint.rotation);

		Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();

		if(obj == true)
		{
			rb.AddForce(transform.up * throwForce);
			rb.AddForce(transform.right * RightForce);

			// 画面外に出たらオブジェクトを破棄する
			if (transform.position.y < -5.5f)
			{
				Destroy(obj);
			}
		}

	}
}

