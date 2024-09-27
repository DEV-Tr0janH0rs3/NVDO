using UnityEngine;

public class CameraScript : MonoBehaviour
{

	public float mouseSense = 100f;

	public Transform playerBody;

	public ControlPC ctrlCams;

	public GameObject hand;

    public Controll_Interactables ci;

	float xRotation = 0f;

    void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;

		xRotation -= mouseY;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		playerBody.Rotate(Vector3.up * mouseX);

		if(Input.GetMouseButtonDown(0)){
			ShootRay();
		}

        if(Input.GetKeyDown(KeyCode.U)){
            if(Cursor.lockState == CursorLockMode.None){
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            } else {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    public void ShootRay(){
    	Ray ray = new Ray(this.transform.position, this.transform.forward);
    	Debug.DrawRay(this.transform.position, this.transform.forward * 2, Color.red, 2f);
    	RaycastHit hit;

    	if(Physics.Raycast(ray, out hit, 3f)){
            GameObject hitObj = hit.collider.transform.gameObject;
    		Debug.Log(hitObj.name);
    		if(hitObj.name == "MONITORScreen"){
    			ci.ControlCams(ctrlCams);
    		}
			if(hitObj.tag == "Pickable"){
                ci.PickReturnObject(1,hand.transform,hit.collider.transform);
    		}
    		if(hitObj.name == "COMP1"){
                ci.ComputerControll(hitObj.GetComponent<RayCastMSG>());
    		}
            if(hitObj.name == "DvD" && hand.transform.childCount > 0 && hand.transform.GetChild(0).gameObject.name.Contains("Disk")){
    			GameObject diska = hand.transform.GetChild(0).gameObject;
    			hand.transform.GetChild(0).gameObject.transform.SetParent(hitObj.transform);
    			diska.transform.localPosition = new Vector3(0,0,0.7f);
    		}
    		if(hitObj.tag == "DvDBox" && hand.transform.childCount > 0 && hand.transform.GetChild(0).gameObject.name.Contains("Disk")){
    			GameObject diska = hand.transform.GetChild(0).gameObject;
    			hand.transform.GetChild(0).gameObject.transform.SetParent(hitObj.transform.root);
    			diska.transform.localPosition = new Vector3(0f,-0.01f,0f);
    		}
    		if(hitObj.tag == "DvDBox" && hand.transform.childCount == 0){
                ci.OpenClose(hitObj.transform.root.gameObject.GetComponent<DvDOpen>(),null);
    		}
    		if(hitObj.tag == "Door"){
                ci.OpenClose(null,hitObj.transform.root.gameObject.GetComponent<DoorScript>());
    		}
    	}
    }
}
