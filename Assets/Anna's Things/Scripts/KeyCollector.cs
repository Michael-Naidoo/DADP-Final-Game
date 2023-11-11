using UnityEngine;
using UnityEngine.UI;

public class KeyCollector : MonoBehaviour
{
    public Image keyImage;
    public Sprite grayKeySprite;
    public Sprite coloredKeySprite;

    private GameObject[] collectibles; // An array to hold references to all collectibles.

    private void Start()
    {
        keyImage.sprite = grayKeySprite;
        collectibles = GameObject.FindGameObjectsWithTag("Collectible"); // Find all collectible GameObjects in the scene.
    }

    public void CollectKey()
    {
        keyImage.sprite = coloredKeySprite;

        // Check if all collectibles have been collected.
        foreach (var collectible in collectibles)
        {
            if (collectible.activeSelf)
            {
                return;  
            }
        }

        
    }

}