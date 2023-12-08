using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bar : MonoBehaviour
{
  public float targetWidth = 492f; // Set your desired width here
    private Image barImage;

    private void Start()
    {
        barImage = GetComponent<Image>();
    }

    private void Update()
    {
        // Decrease the width gradually over time
        float currentWidth = barImage.rectTransform.sizeDelta.x;
        float newWidth = Mathf.MoveTowards(currentWidth, targetWidth, Time.deltaTime * 10f); // Adjust the speed as needed
        barImage.rectTransform.sizeDelta = new Vector2(newWidth, barImage.rectTransform.sizeDelta.y);
    }
}

