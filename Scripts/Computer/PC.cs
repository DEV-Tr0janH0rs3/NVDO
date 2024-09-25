using UnityEngine;

public class PC : MonoBehaviour
{
	public Animator DvDDrive;
	public bool onoroff;
	public void TurnOnOff(){

	}
	public void DvDOpenClose(){
		if(DvDDrive.GetBool("OpenClose") == false){
			onoroff = true;
			DvDDrive.SetBool("OpenClose", true);
		} else {
			onoroff = false;
			DvDDrive.SetBool("OpenClose", false);
		}
	}
}
