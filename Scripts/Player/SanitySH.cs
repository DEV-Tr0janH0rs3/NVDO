using UnityEngine;

public class SanitySH : MonoBehaviour
{
	public GameObject sanityimgbig;

    public void HideSanity(){
    	sanityimgbig.SetActive(false);
    }

    public void ShowSanity(){
    	sanityimgbig.SetActive(true);
    }

    void Update(){
    	if(Input.GetKeyDown(KeyCode.Tab)){
    		ShowSanity();
    	}
    }
}
