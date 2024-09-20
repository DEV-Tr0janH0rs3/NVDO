using UnityEngine;

public class FPSCap : MonoBehaviour
{
	void Awake() {
	Application.targetFrameRate = 240;
	}
}
