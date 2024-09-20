using UnityEngine;

public class CheckIfSpellHit : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag != "Cursor"){
			Destroy (this.gameObject);
		}
	}
}
