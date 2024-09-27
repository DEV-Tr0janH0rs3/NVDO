using UnityEngine;

public class Triggers : MonoBehaviour
{
    public DialogueS dialogue;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "DialogueTrigger"){
            dialogue.dialogueChange("",0);
        }
       	other.gameObject.GetComponent<ChangeTransparancy>().isInside = true;
    }
    private void OnTriggerExit(Collider other)
    {
       	other.gameObject.GetComponent<ChangeTransparancy>().isInside = false;
    }
}
