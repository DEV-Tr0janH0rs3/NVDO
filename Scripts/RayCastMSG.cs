using UnityEngine;

public class RayCastMSG : MonoBehaviour
{
	public string msg;
	public GameObject menu;

	public void OpenMenu(){
		menu.SetActive(true);
	}
}
