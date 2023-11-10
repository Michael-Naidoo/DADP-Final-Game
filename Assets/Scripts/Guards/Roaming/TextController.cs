using UnityEngine;

public class TextController : MonoBehaviour
{
    public GameObject textToShowWithOneOrHigher;
    public GameObject textToDisable;
    public GameObject getScoringSystem;
    public int number = 0;

    void Start()
    {
        textToDisable.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (number >= 1)
            {
                textToShowWithOneOrHigher.SetActive(true);
                textToDisable.SetActive(false);
                number -= 1;
            }
            else
            {
                textToShowWithOneOrHigher.SetActive(false);
                textToDisable.SetActive(true);
                number = Mathf.Max(0, number + 1);
            }
        }
    }

    public void SetNumber(int newNumber)
    {
        number = newNumber;
    }
}