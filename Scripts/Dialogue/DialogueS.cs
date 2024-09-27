using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueS : MonoBehaviour
{
    public TMPro.TextMeshProUGUI dialogue;
    public GameObject brainicon;
    private Coroutine currentCoroutine;

    public void Test(){
        dialogueChange("Testing the dialogue system " + Random.Range(30, 200), 1);
        isThought();
    }

    public void dialogueChange(string text, int thought){
        if (currentCoroutine != null) {
            StopCoroutine(currentCoroutine);
        }
        currentCoroutine = StartCoroutine(ShowText(text,thought));
    }

    public void isThought(){
        brainicon.SetActive(true);
    }

    public IEnumerator ShowText(string text, int thought){
    	if(thought == 1){
    		isThought();
    	}
        dialogue.text = text;
        yield return new WaitForSeconds(10f);
        dialogue.text = "";
        brainicon.SetActive(false);
    }
}