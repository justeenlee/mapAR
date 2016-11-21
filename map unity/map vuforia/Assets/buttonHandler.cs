using UnityEngine;
using System.Collections;
using Vuforia;

public class buttonHandler : MonoBehaviour, IVirtualButtonEventHandler {
	//private GameObject buttonARep;
	//private GameObject button2Rep;
	private GameObject hpworldRep;
	private GameObject curLocationRep;
	private GameObject path;
	private bool[] selected;
	private Color river;
	private Color turquoise;


	Animator shrekAnimator;
	bool isVisible = true;
	GameObject shrekBuilding;
	GameObject entrance;
	Animator entranceAnimator;

	// Use this for initialization
	void Start () {
		//GameObject.Find ("map").GetComponent<Renderer> ().material.color.a = 0; 
		
		//button2Rep = GameObject.Find ("button2Rep");
		//buttonARep = GameObject.Find ("buttonARep");
		hpworldRep = GameObject.Find ("hpworldRep");
		curLocationRep = GameObject.Find ("curLocationRep");
//		hpworldRep.GetComponent<Renderer> ().material.color = river;
//		curLocationRep.GetComponent<Renderer> ().material.color = river;


		shrekBuilding = GameObject.Find ("shrek building");
		shrekAnimator = shrekBuilding.GetComponent<Animator> ();
		entrance = GameObject.Find ("entrance");
		entranceAnimator = entrance.GetComponent<Animator> ();

		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i)
		{
			vbs[i].RegisterEventHandler(this);
			Debug.Log ("=============================" +vbs[i].name+" set up!");
		}
		path = GameObject.Find ("path");
		path.SetActive (false);

		selected = new bool[vbs.Length];
		for (int j = 0; j < vbs.Length; j++) {
			selected [j] = false;
		}

		Debug.Log ("\n"+curLocationRep.GetComponent<MeshRenderer>().material);
		river = new Color (52/255f, 152/255f, 219/255f);
		turquoise = new Color (26/255f, 188/255f, 156/255f);
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour btn) {
		//Debug.Log (btn.VirtualButtonName + "===================== pressed\n");

		if (btn.VirtualButtonName == "curLocation") {
			if (selected [0] != true) {
				Debug.Log ("===================== " + btn.VirtualButtonName + " selected \n");
				selected [0] = true;
				curLocationRep.GetComponent<Renderer> ().material.color = turquoise;
			} else {
				Debug.Log ("===================== " + btn.VirtualButtonName + " DE selected \n");
				selected [0] = false;
				curLocationRep.GetComponent<Renderer> ().material.color = river;
			}
		} else if (btn.VirtualButtonName == "hpworld") {
			if (selected [1] != true) {
				Debug.Log ("===================== " + btn.VirtualButtonName + " selected \n");
				selected [1] = true;
				hpworldRep.GetComponent<Renderer> ().material.color = turquoise;
				path.SetActive (true);
			} else {
				Debug.Log ("===================== " + btn.VirtualButtonName + " DE selected \n");
				selected [1] = false;
				hpworldRep.GetComponent<Renderer> ().material.color = Color.white; //Color.clear
				path.SetActive (false);
			}

			Debug.Log ("\n" + hpworldRep.GetComponent<MeshRenderer> ().material.color);

		} else if (btn.VirtualButtonName == "ses") {
			if (isVisible) {
				shrekAnimator.SetTrigger ("Sink");
				entranceAnimator.SetTrigger ("Sink");
				isVisible = false;
				//shrekBuilding.SetActive (false);
				//entrance.SetActive (false);
			} else {
				//shrekBuilding.SetActive (true);
				//entrance.SetActive (true);
				shrekAnimator.SetTrigger ("Rise");
				entranceAnimator.SetTrigger ("Rise");
				isVisible = true;
			}

		}

//		if (selected [0] && selected [1]) {
//			path.SetActive (true);
//		} else {
//			path.SetActive (false);
//		}

	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour btn) {
		Debug.Log (" ---> " + btn.VirtualButtonName+"\n");

		if (btn.VirtualButtonName == "buttonA") {

		} else if (btn.VirtualButtonName == "button2") {
			
		} 
	}
}