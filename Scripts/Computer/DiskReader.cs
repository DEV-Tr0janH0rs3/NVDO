using UnityEngine;

public class DiskReader : MonoBehaviour
{
	public string diskname;
    void Update()
    {
    	if(this.gameObject.transform.childCount != 0){
    		diskname = this.gameObject.transform.GetChild(0).gameObject.name;
    	} else {
    		diskname = "";
    	}
    }
}
