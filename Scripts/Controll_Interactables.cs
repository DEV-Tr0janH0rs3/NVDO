using UnityEngine;

public class Controll_Interactables : MonoBehaviour
{
	public void ControlCams(ControlPC ctrlCams){
		ctrlCams.stopMainCtrl();
	}

	public void PickReturnObject(int choise, Transform hand, Transform pickedObject){
		switch (choise) {
		    case 1:
    			pickedObject.SetParent(hand.transform);
    			pickedObject.localPosition = Vector3.zero;
		        break;
		    case 2:

		        break;
		    default:
		        break;
		}
	}

	public void ComputerControll(int cmd){

	}

	public void OpenClose(DvDOpen dvd, DoorScript ds){
		if(dvd != null){
    		if(dvd.onoroff){
    			dvd.onoroff = false;
    		} else {
    			dvd.onoroff = true;
    		}
		}
		if(ds != null){
    		if(ds.onoroff){
    			ds.onoroff = false;
    		} else {
    			ds.onoroff = true;
    		}
		}
	}

}
