using UnityEditor.Analytics;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
	[SerializeField] Vector3 startPos;

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
