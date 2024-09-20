using UnityEngine;

public class DoorScript : MonoBehaviour
{
	public Animator anim;
	public bool onoroff = false;

    void Update()
    {
		if(onoroff){
			anim.SetBool("IsOpen", true);
		} else {
			anim.SetBool("IsOpen", false);
		}
    }
}
