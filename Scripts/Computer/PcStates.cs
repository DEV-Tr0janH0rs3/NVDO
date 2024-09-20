using UnityEngine;
using System.Collections;

public class PcStates : MonoBehaviour
{
    public GameObject thinkLight;
    public AudioSource audio;
    public AudioSource audio2;



    public void CallBlink()
    {
    	StartCoroutine(BlinkLight());
    }

    public void PlayAudio(int num){
    	if(num == 1){
    		audio2.clip = (AudioClip)Resources.Load("Sounds/PcBeep");
			audio2.Play();
    	}
    	if(num == 2){
    		audio.clip = (AudioClip)Resources.Load("Sounds/FansStart");
			audio.Play();
    	}
    	if(num == 3){
    		audio.clip = (AudioClip)Resources.Load("Sounds/PCRunning");
			audio.Play();
    	}

    }

    public IEnumerator BlinkLight()
    {

            int burstCount = Random.Range(30, 200); 
            Debug.Log(burstCount);
            for (int i = 0; i < burstCount; i++)
            {

                thinkLight.SetActive(!thinkLight.activeSelf);
                yield return new WaitForSeconds(0.01f);
            }

            thinkLight.SetActive(false);
    }
}
