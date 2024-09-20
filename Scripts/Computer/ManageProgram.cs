using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManageProgram : MonoBehaviour
{
	public GameObject fullScreen;
	public Image fscreenicon;
	public GameObject fscreenname;
	public GameObject AppPrompt;
	public GameObject DvDAppPrompt;
	public Image dvdapppic;
	public GameObject dvdappname;
	public Image apppic;
	public GameObject appname;
	public GameObject activeProgram;
	public GameObject desktop;
	public DiskReader diskread;
	public PcStates pc;

	public void AppThings(Image img, string app, bool wantdisk, string diskname){
		if(wantdisk){
			if(diskread.diskname == diskname){
				AppPrompt.SetActive(true);
				apppic.sprite = img.sprite;
				appname.GetComponent<TMPro.TextMeshProUGUI>().text = app;
			} else {
				DvDAppPrompt.SetActive(true);
				dvdapppic.sprite = img.sprite;
				dvdappname.GetComponent<TMPro.TextMeshProUGUI>().text = app;
			}
		} else {
			AppPrompt.SetActive(true);
			apppic.sprite = img.sprite;
			appname.GetComponent<TMPro.TextMeshProUGUI>().text = app;
		}
	}
	public IEnumerator OpenTheProgram(GameObject theprogram, string name, Image icon){
		pc.CallBlink();
		desktop.SetActive(false);
		activeProgram = theprogram;
		AppPrompt.SetActive(false);
		yield return new WaitForSeconds(Random.Range(1,3));
		fullScreen.SetActive(true);
		fscreenicon.sprite = icon.sprite;
		fscreenname.GetComponent<TMPro.TextMeshProUGUI>().text = name;
		theprogram.SetActive(true);
	}
	public void CloseTheProgram(){
		fullScreen.SetActive(false);
		if(activeProgram != null){
			activeProgram.SetActive(false);
		}
		desktop.SetActive(true);
	}
	public void ClosePrompt(){
		apppic.sprite = null;
		appname.GetComponent<TMPro.TextMeshProUGUI>().text = "";
		AppPrompt.SetActive(false);
	}
	public void CloseDvDPrompt(){
		dvdapppic.sprite = null;
		dvdappname.GetComponent<TMPro.TextMeshProUGUI>().text = "";
		DvDAppPrompt.SetActive(false);
	}


}
