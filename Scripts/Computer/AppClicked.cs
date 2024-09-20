using UnityEngine;
using UnityEngine.UI;

public class AppClicked : MonoBehaviour
{
	public ManageProgram op;
	public GameObject tprogram;
	public Image ticon;
	public string tname;
	void OnCollisionEnter2D(Collision2D other){
		if(Input.GetMouseButton(0)){
			if(other.gameObject.name == "NO"){
				op.ClosePrompt();
			} else if(other.gameObject.name == "YES") {
				StartCoroutine(op.OpenTheProgram(tprogram,tname,ticon));
			} else if (other.gameObject.tag == "DesktopIcon"){
				op.AppThings(other.gameObject.GetComponent<Image>(), other.gameObject.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text,other.gameObject.transform.GetComponent<WantDisk>().diskWanted,other.gameObject.transform.GetComponent<WantDisk>().diskname);
				tprogram = other.gameObject.GetComponent<IconToApp>().program;
				ticon = other.gameObject.GetComponent<Image>();
				tname = other.gameObject.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text;
			} else if(other.gameObject.name == "CloseButton"){
				op.CloseTheProgram();
			} else if(other.gameObject.name == "OK_Prompt"){
				op.CloseDvDPrompt();
			}
		}
	}
	void OnCollisionStay2D(Collision2D other){
		if(Input.GetMouseButton(0)){
			if(other.gameObject.name == "NO"){
				op.ClosePrompt();
			} else if(other.gameObject.name == "YES") {
				StartCoroutine(op.OpenTheProgram(tprogram,tname,ticon));
			} else if (other.gameObject.tag == "DesktopIcon"){
				op.AppThings(other.gameObject.GetComponent<Image>(), other.gameObject.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text,other.gameObject.transform.GetComponent<WantDisk>().diskWanted,other.gameObject.transform.GetComponent<WantDisk>().diskname);
				tprogram = other.gameObject.GetComponent<IconToApp>().program;
				ticon = other.gameObject.GetComponent<Image>();
				tname = other.gameObject.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text;
			} else if(other.gameObject.name == "CloseButton"){
				op.CloseTheProgram();
			} else if(other.gameObject.name == "OK_Prompt"){
				op.CloseDvDPrompt();
			}
		}
	}

}
