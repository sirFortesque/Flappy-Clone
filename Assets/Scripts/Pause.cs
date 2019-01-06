using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	bool paused = false;
	
	private void Update() 
	{
		if(Input.GetButtonUp("Jump"))
		{
			if(!paused)
			{
				Time.timeScale = 0;
				paused=true;
			}
			else
			{
				Time.timeScale = 1;
				paused=false;
			}
		}
	}
}
