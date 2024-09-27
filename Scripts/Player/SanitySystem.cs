using UnityEngine;
using UnityEngine.UI;

public class SanitySystem : MonoBehaviour
{
	public int sanity = 255;
	public Image sanityimg;
	public GameObject sanityimgbig;

    public void DecreseSanity(int amount){
    	sanity = sanity - amount;
    }
    
    void Update()
    {
    	if(sanity < 0) {
    		sanity = 0;
    	}
        sanityimg.color = new Color32(255,(byte)sanity,(byte)sanity,200);
        sanityimgbig.GetComponent<Image>().color = new Color32(255,(byte)sanity,(byte)sanity,200);
    }
}
