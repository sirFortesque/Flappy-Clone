using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public int window;

	void Start () { 
		window = 1; 
	} 

	void OnGUI () { 
		GUI.BeginGroup (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 300, 200)); 

			if(window == 1) 
				{ 
					if(GUI.Button (new Rect (10,30,180,30), "Play game")) { 
						window = 2;   
					} 
					if(GUI.Button (new Rect (10,70,180,30), "Control")) { 
						window = 3; 
					} 
					if(GUI.Button (new Rect (10,110,180,30), "About")) { 
						window = 4; 
					} 
				}

			if(window == 2) { 
				Application.LoadLevel(1); 
			} 

			if (window == 3) { 
				GUI.Label (new Rect (50, 10, 200, 30), "Press Space to pause the game");
				GUI.Label (new Rect (50, 40, 200, 60), "Press the left mouse button to control the bird");

				if(GUI.Button (new Rect (50,80,180,30), "Exit")) { 
				window = 1; 
				} 
			}

			if (window == 4) { 
				GUI.Label (new Rect (50, 10, 200, 30), "Developer - Peter Parker");
				GUI.Label (new Rect (50, 40, 200, 60), "Tester - Tony Stark");

				if(GUI.Button (new Rect (50,70,180,30), "Exit")) { 
				window = 1; 
				}
			}

		GUI.EndGroup (); 
	}

}
