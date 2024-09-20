using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController charcontroll;
	public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        charcontroll.Move(move * speed * Time.deltaTime);
    }
}