using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
	[SerializeField] GameObject hp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		this.hp.GetComponent<Image>().fillAmount -= 0.33f;
    }
}
