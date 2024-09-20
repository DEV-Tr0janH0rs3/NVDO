using UnityEngine;

public class Startup : MonoBehaviour
{
	public PcStates pcState;
	public GameObject StartUpScr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Think()
    {
        pcState.CallBlink();
    }
    public void PlayAudio(int num){
    	pcState.PlayAudio(num);
    }
    public void Finish(){
    	StartUpScr.SetActive(false);
    }
}
