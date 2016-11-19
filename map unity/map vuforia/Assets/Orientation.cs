using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Orientation : MonoBehaviour {


	private float speed;
	private float amountToMove;
	//SerialPort sp = new SerialPort("/dev/tty.Bluetooth-Incoming-Port", 9600);

	// Use this for initialization
	void Start () {
		//sp.Open ();
		//sp.ReadTimeout = 1;
	}
	
	// Update is called once per frame
	void Update () {
		amountToMove = speed * Time.deltaTime;

//		if (sp.IsOpen) {
//			try {
//				moveArrow();	
//			} catch (System.Exception){
//			}
//		}
	}


//	void moveArrow(){
//		int direction = sp.ReadByte ();
//		switch (direction) {
//		case 1:
//			//turn 
//			break;
//		case 2:
//			//turn
//			break;
//		case 3:
//			//turn 
//			break;
//		case 4:
//			//turn
//			break;
//		}
//	}

}
