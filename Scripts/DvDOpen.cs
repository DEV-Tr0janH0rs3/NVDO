using UnityEngine;

public class DvDOpen : MonoBehaviour
{
	public Animator anim;
	public bool onoroff;

    void Update()
    {
		if(onoroff){
			anim.SetBool("IsOpen", true);
		} else {
			anim.SetBool("IsOpen", false);
		}
    }
}
