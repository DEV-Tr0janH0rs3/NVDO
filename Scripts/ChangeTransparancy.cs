using UnityEngine;

public class ChangeTransparancy : MonoBehaviour
{
  	public Material transparentmat;
  	public Material normalmat;

  	public bool isInside;

  	public DoorScript ds;

  	public GameObject door1;
  	public GameObject door2;

  	void Update(){
  		if(isInside){
  			if(ds.onoroff){
  				ChangeMatN();
  			} else {
  				ChangeMatT();
  			}
  		} else {
  			ChangeMatN();
  		}
  	}

  	public void ChangeMatT(){
  		door1.GetComponent<MeshRenderer>().material = transparentmat;
  		door2.GetComponent<MeshRenderer>().material = transparentmat;
  	}
  	public void ChangeMatN(){
  		door1.GetComponent<MeshRenderer>().material = normalmat;
  		door2.GetComponent<MeshRenderer>().material = normalmat;
  	}
}
