using UnityEngine;

public class Triggers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       	other.gameObject.GetComponent<ChangeTransparancy>().isInside = true;
    }
    private void OnTriggerExit(Collider other)
    {
       	other.gameObject.GetComponent<ChangeTransparancy>().isInside = false;
    }
}
