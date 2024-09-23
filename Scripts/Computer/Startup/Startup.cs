using UnityEngine;

public class Startup : MonoBehaviour
{
	public PcStates pcState;
	public GameObject StartUpScr;

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
