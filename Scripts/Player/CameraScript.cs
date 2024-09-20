using UnityEngine;

public class CameraScript : MonoBehaviour
{

	public float mouseSense = 100f;

	public Transform playerBody;

	public ControlPC ctrlCams;

	public GameObject hand;

	float xRotation = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
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
    }

    public void ShootRay(){
    	Ray ray = new Ray(this.transform.position, this.transform.forward * 100);
    	Debug.DrawRay(this.transform.position, this.transform.forward * 100, Color.red, 2f);
    	RaycastHit hit;

        //Hit detection
    	if(Physics.Raycast(ray, out hit)){
    		if(hit.collider != null){
    			Debug.Log(hit.collider.transform.gameObject.name);
    			if(hit.collider.transform.gameObject.name == "MONITORScreen"){
    				ctrlCams.stopMainCtrl();
    			}
    			if(hit.collider.transform.gameObject.tag == "Pickable"){
    				hit.collider.transform.SetParent(hand.transform);
    				hit.collider.transform.localPosition = Vector3.zero;
    			}
    			if(hit.collider.transform.gameObject.name == "COMP1"){
    				if(hit.collider.transform.gameObject.GetComponent<PC>().onoroff){
    					hit.collider.transform.gameObject.GetComponent<PC>().DvDOpenClose(false);
    				} else {
    					hit.collider.transform.gameObject.GetComponent<PC>().DvDOpenClose(true);
    				}
    			}
    			if(hit.collider.transform.gameObject.name == "DvD" && hand.transform.childCount > 0 && hand.transform.GetChild(0).gameObject.name.Contains("Disk")){
    				GameObject diska = hand.transform.GetChild(0).gameObject;
    				hand.transform.GetChild(0).gameObject.transform.SetParent(hit.collider.transform.gameObject.transform);
    				diska.transform.localPosition = new Vector3(0,0,0.7f);
    			}
    			if(hit.collider.transform.gameObject.tag == "DvDBox" && hand.transform.childCount > 0 && hand.transform.GetChild(0).gameObject.name.Contains("Disk")){
    				GameObject diska = hand.transform.GetChild(0).gameObject;
    				hand.transform.GetChild(0).gameObject.transform.SetParent(hit.collider.transform.gameObject.transform.root);
    				diska.transform.localPosition = new Vector3(0f,-0.01f,0f);
    			}
    			if(hit.collider.transform.gameObject.tag == "DvDBox" && hand.transform.childCount == 0){
    				if(hit.collider.transform.gameObject.transform.root.gameObject.GetComponent<DvDOpen>().onoroff){
    					hit.collider.transform.gameObject.transform.root.gameObject.GetComponent<DvDOpen>().onoroff = false;
    				} else {
    					hit.collider.transform.gameObject.transform.root.gameObject.GetComponent<DvDOpen>().onoroff = true;
    				}
    			}
    			if(hit.collider.transform.gameObject.tag == "Door"){
    				if(hit.collider.transform.gameObject.transform.root.gameObject.GetComponent<DoorScript>().onoroff){
    					hit.collider.transform.gameObject.transform.root.gameObject.GetComponent<DoorScript>().onoroff = false;
    				} else {
    					hit.collider.transform.gameObject.transform.root.gameObject.GetComponent<DoorScript>().onoroff = true;
    				}
    			}
    		}
    	}
    }
}
