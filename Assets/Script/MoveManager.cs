using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveManager : MonoBehaviour
{
	float coolDownTime = 2.7f;  // 一定時間入力を受け付けない
	float nexInputTime;
	
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
		if (Time.time < nexInputTime) return;

		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			Throw();
			// 一定時間入力を受け付けない
			nexInputTime = Time.time + coolDownTime;
		}
		
	}

	void Throw()
	{
		// オブジェクトの複製
		GameObject obj = Instantiate(prefabToThrow, throwPoint.position, throwPoint.rotation);

		Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();

		// オブジェクトを右上に飛ばす
		if(obj == true)
		{
			rb.AddForce(transform.up * throwForce);
			rb.AddForce(transform.right * RightForce);  
		}

	}
}