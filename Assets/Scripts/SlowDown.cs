using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    float timeShift = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        Time.timeScale = timeShift;
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        Time.timeScale = 1.0f;
    }
}
