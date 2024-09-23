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

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");
        screenMousePos = new Vector3 (cursor.GetComponent<RectTransform>().localPosition.x + mouseX * 10,cursor.GetComponent<RectTransform>().localPosition.y + mouseY * 10,0);
        screenMousePos.x = Mathf.Clamp(screenMousePos.x, -241f, 290f);
        screenMousePos.y = Mathf.Clamp(screenMousePos.y, -196f, 182f);
        cursor.GetComponent<RectTransform>().localPosition = screenMousePos;
        gameMousePos = new Vector3 (pcMouse.transform.position.x + mouseX / 150,pcMouse.transform.position.y,pcMouse.transform.position.z + mouseY / 150);
        gameMousePos.x = Mathf.Clamp(gameMousePos.x, -6.642f, -6.123f);
        gameMousePos.z = Mathf.Clamp(gameMousePos.z, 3.992f, 4.391f);
        pcMouse.transform.position = gameMousePos;
    }
}
