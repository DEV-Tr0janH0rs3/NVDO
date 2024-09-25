using UnityEngine;

public class RayCastControll : MonoBehaviour
{
	public GameObject rmsg;
    void Update()
    {
    	Ray ray = new Ray(this.transform.position, this.transform.forward);
    	Debug.DrawRay(this.transform.position, this.transform.forward * 2, Color.green, 2f);
    	RaycastHit hit;

    	if(Physics.Raycast(ray, out hit, 3f)){
            GameObject hitObj = hit.collider.transform.gameObject;
    		if(hitObj.GetComponent<RayCastMSG>()){
    			rmsg.GetComponent<TMPro.TextMeshProUGUI>().text = hitObj.GetComponent<RayCastMSG>().msg;
    		} else {
    			rmsg.GetComponent<TMPro.TextMeshProUGUI>().text = "";
    		}
    	} else {
    		rmsg.GetComponent<TMPro.TextMeshProUGUI>().text = "";
    	}
    }
}
