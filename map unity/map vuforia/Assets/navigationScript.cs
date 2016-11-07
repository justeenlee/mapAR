using UnityEngine;
using System.Collections;
using Vuforia;

public class navigationScript : MonoBehaviour, IVirtualButtonEventHandler {
	private GameObject button2;
	private GameObject button2Rep;
	Color c1 = new Color (0F, 0F, 0F);

	// Use this for initialization
	void Start () {
		button2 = GameObject.Find ("button2");
		button2Rep = GameObject.Find ("button2Rep");
		button2.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		Debug.Log ("=============================" +button2.name+" set up ");

	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour btn) {
		Debug.Log ("******************** pressed\n");
		if (btn.VirtualButtonName == "button2") {
			Debug.Log (btn.VirtualButtonName + "============================= pressed\n");
			button2Rep.GetComponent<Renderer> ().material.color = c1;
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour btn) {
		Debug.Log ("============================= released");

		button2Rep.GetComponent<Renderer>().material.color = new Color (255F, 255F, 255F);
	}


}
