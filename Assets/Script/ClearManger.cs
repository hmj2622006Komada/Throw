using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearManger : MonoBehaviour
{
	float step_time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		step_time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
		step_time += Time.deltaTime;

        if(step_time >= 5.0f)
		{
			SceneManager.LoadScene("StartScenes");
		}
    }
}
