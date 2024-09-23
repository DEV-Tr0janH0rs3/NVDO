using UnityEngine;

public class CastSpells : MonoBehaviour
{
	public Animator anim;

    void Update()
    {
		if(Input.GetMouseButtonDown(0)){
			anim.SetBool("IsCasting", true);
		}
    }
}
