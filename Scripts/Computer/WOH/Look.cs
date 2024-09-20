using UnityEngine;

public class Look : MonoBehaviour
{
	public GameObject pointer;
	public GameObject Player;
	public GameObject fireball;
	public GameObject shootHole;
	public GameObject gameTF;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 relativePos = pointer.transform.position - this.transform.position;
		Quaternion rotation = Quaternion.LookRotation (relativePos);   
		this.transform.rotation = rotation;

		float x = Input.GetAxis("Horizontal") * 70*Time.deltaTime;
        float y = Input.GetAxis("Vertical") * 70*Time.deltaTime;

        Player.transform.position = new Vector3(Player.transform.position.x + x/5, Player.transform.position.y + y/5, Player.transform.position.z);

		if(Input.GetMouseButtonDown(0)){
			GameObject fireballS = Instantiate(fireball, shootHole.transform.position, rotation);
			fireballS.transform.SetParent(gameTF.transform);
			fireballS.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(pointer.transform.position.x - fireballS.transform.position.x,pointer.transform.position.y - fireballS.transform.position.y,0).normalized * 40;
		}

    }
}
