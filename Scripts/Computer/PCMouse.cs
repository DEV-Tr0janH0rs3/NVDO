using UnityEngine;
using UnityEngine.UI;

public class PCMouse : MonoBehaviour
{
	public float sensX;
	public float sensY;
	public GameObject cursor;
	public GameObject pcMouse;
	public Vector3 gameMousePos;
	public Vector3 screenMousePos;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");
        screenMousePos = new Vector3 (cursor.GetComponent<RectTransform>().localPosition.x + mouseX * 10,cursor.GetComponent<RectTransform>().localPosition.y + mouseY * 10,0);
        screenMousePos.x = Mathf.Clamp(screenMousePos.x, -241f, 290f);
        screenMousePos.y = Mathf.Clamp(screenMousePos.y, -196f, 182f);
        cursor.GetComponent<RectTransform>().localPosition = screenMousePos;
        gameMousePos = new Vector3 (pcMouse.transform.position.x + mouseX / 150,pcMouse.transform.position.y,pcMouse.transform.position.z + mouseY / 150);
        gameMousePos.x = Mathf.Clamp(gameMousePos.x, -7.14f, -6.66f);
        gameMousePos.z = Mathf.Clamp(gameMousePos.z, 2.87f, 3.25f);
        pcMouse.transform.position = gameMousePos;
    }
}