using UnityEngine;

public class MenuOpen : MonoBehaviour 
{
	public CameraScript cs;
	public PlayerMovement pm;
	public GameObject rmsg;

    void OnEnable()
    {
        cs.enabled = false;
        pm.enabled = false;
        rmsg.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        	CloseMenu();
        }
    }

    public void CloseMenu(){
        cs.enabled = true;
        pm.enabled = true;
        rmsg.SetActive(true);
        this.gameObject.SetActive(false);    	
    }
}
