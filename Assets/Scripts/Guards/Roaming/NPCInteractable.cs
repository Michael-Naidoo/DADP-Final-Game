using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    [SerializeField] private string interactText;

    private Animator animator;
    private NPCHeadLookAt nPCHeadLookAt;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        nPCHeadLookAt = GetComponent<NPCHeadLookAt>();
    }

    public void Interact(Transform interactorTransform)
    {
        ChatBubble3D.Create(transform.transform, new Vector3(-.3f, 1.7f, 0f), ChatBubble3D.IconType.Happy, "Hey Mate!");

        animator.SetTrigger("Talk");

        //float playerHeight = 1.7f;
        //npcHeadLookAt.LookAtPosition(interactorTransform.position + Vector3.up * playerHeight);
    }

    public string GetInteractText()
    {
        return interactText;
    }
}
