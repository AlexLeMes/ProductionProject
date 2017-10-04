using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelTimer : MonoBehaviour {

    public float maxTime = 0f;
    public float time = 0f;

    public bool enableTime = false;

    public Text timerText;

	void Start () 
    {
        time = maxTime;
	}
	
    void Update () 
    {
        timerText.text = time.ToString("F1");

		if (enableTime == true)
        {
            time -= Time.deltaTime;
		}
	}

    public void timerEnded()
    {
        if(time <= 0)
        {
            //GameManager.playerLost();
            Debug.Log("playerLost");
        }
            
    }
}
