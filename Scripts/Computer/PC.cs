using UnityEngine;

public class PC : MonoBehaviour
{
	public Animator DvDDrive;
	public bool onoroff;
	public void TurnOnOff(){

	}
	public void DvDOpenClose(bool onoff){
		if(onoff){
			onoroff = true;
			DvDDrive.SetBool("OpenClose", true);
		} else {
			onoroff = false;
			DvDDrive.SetBool("OpenClose", false);
		}
	}
}
