using UnityEngine;

public class ControlPC : MonoBehaviour
{
	public GameObject mainCam;
	public GameObject Peff1;
	public GameObject Peff2;
	public GameObject LowRez1;
	public GameObject LowRez2;
	public GameObject pcCam1;
	public GameObject crosshair;

    void Start()
    {
        
    }

    void Update()
    {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(mainCam.activeSelf == false){
				mainCam.SetActive(true);
				Peff1.SetActive(true);
				Peff2.SetActive(false);
				LowRez1.SetActive(true);
				LowRez2.SetActive(false);
				pcCam1.SetActive(false);
				crosshair.SetActive(true);
			}
		}
    }

    public void stopMainCtrl(){
    	mainCam.SetActive(false);
    	Peff1.SetActive(false);
    	Peff2.SetActive(true);
    	LowRez1.SetActive(false);
    	LowRez2.SetActive(true);
    	pcCam1.SetActive(true);
    	crosshair.SetActive(false);
    }
}
