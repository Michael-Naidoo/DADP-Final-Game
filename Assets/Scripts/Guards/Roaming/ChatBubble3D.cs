using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble3D : MonoBehaviour
{
    public static void Create(Transform parent, Vector3 localPosition, IconType iconType, string text)
    {
        // Instantiate a chat bubble prefab from GameAssets
       // Transform chatBubbleTransform = Instantiate(GameAssets.i.pfChatBubble, parent);
        // chatBubbleTransform.localPosition = localPosition;

        // Call the Setup method of the ChatBubble3D script on the instantiated object
       //  chatBubbleTransform.GetComponent<ChatBubble3D>().Setup(iconType, text);

        // Destroy(chatBubbleTransform.gameObject, 6f);
    }

    public void Setup(IconType iconType, string text)
    {
        // This method sets up the chat bubble with the provided icon and text
    }

    public enum IconType
    {
        Happy,
        Neutral,
        Angry
    }

    [SerializeField] private Sprite happyIconSprite = null;
}