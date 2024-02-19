using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public List<ButtonScript> buttons = new List<ButtonScript>();
    private int currentIndex = 0;

    void Start()
    {
        Debug.Log("Number of buttons: " + buttons.Count);
        if (buttons.Count > 0)
        {
            buttons[0].isHovering = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveToNextButton();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveToPreviousButton();
        }
    }

    void MoveToNextButton()
    {
        if (currentIndex < buttons.Count)
        {
            buttons[currentIndex].isHovering = false;
            currentIndex++;
            if (currentIndex >= buttons.Count)
            {
                currentIndex = 0;
            }
            buttons[currentIndex].isHovering = true;
        }
    }

    void MoveToPreviousButton()
    {
        if (currentIndex < buttons.Count)
        {
            buttons[currentIndex].isHovering = false;
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = buttons.Count - 1;
            }
            buttons[currentIndex].isHovering = true;
        }
    }
}
