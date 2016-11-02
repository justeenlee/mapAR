using UnityEngine;
using System.Collections;
using Vuforia;

public class navigationScript : MonoBehaviour, IVirtualButtonEventHandler {


	private GameObject location1btn;
	private GameObject location1rep;

	// Use this for initialization
	void Start () {
		location1btn = GameObject.Find ("location1btn");
		location1rep = GameObject.Find ("location1rep");
		location1btn.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}
	
	public void OnButtonPressed(VirtualButtonAbstractBehaviour btn) {
		Debug.Log ("============================= navigation pressed");
		Debug.Log (btn.VirtualButtonName);

		Color c1 = new Color (0F, 0F, 0F);
		location1rep.GetComponent<Renderer> ().material.color = c1;
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour btn) {
		Debug.Log ("============================= navigation released");

		location1rep.GetComponent<Renderer>().material.color = new Color (255F, 255F, 255F);
	}

}
