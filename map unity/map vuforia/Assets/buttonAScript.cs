using UnityEngine;
using System.Collections;
using Vuforia;

public class buttonAScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject buttonA;
	private GameObject buttonARep;
	// Use this for initialization
	void Start () {
		buttonA = GameObject.Find ("buttonA");
		buttonARep = GameObject.Find ("buttonARep");
		buttonA.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		Debug.Log ("============================= everything set up!!!");
		Debug.Log ("================= color ="+buttonARep.GetComponent<Renderer>().material.color);

	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour btn) {
		Debug.Log ("============================= pressed");
		Debug.Log (btn.VirtualButtonName);

		Color c1 = new Color (0F, 0F, 0F);
		buttonARep.GetComponent<Renderer> ().material.color = c1;
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour btn) {
		Debug.Log ("============================= released");

		buttonARep.GetComponent<Renderer>().material.color = new Color (255F, 255F, 255F);
	}

}
