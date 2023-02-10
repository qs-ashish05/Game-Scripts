using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorController : MonoBehaviour
{
    public Camera mainCamera;

    [SerializeField] private Color[] colors;
    private int colorIndex = 0;
    [SerializeField] private float lerpValue;


    [SerializeField] private float time;
    private float currentTime;

    void Start()
    {
        mainCamera = Camera.main;
    }



    void Update()
    {
        ChangeSmoothCameraColor();
        SetColorChangeTime();
    }



    private void SetColorChangeTime()
    {
        if (currentTime <= 0)
        {
            IncreaseColorIndex();
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }


    private void ChangeSmoothCameraColor()
    {
        mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, colors[colorIndex], lerpValue * Time.deltaTime);
    }



    private void IncreaseColorIndex()
    {
        colorIndex++;
    }


    private void CheckColorIndexValue()
    {
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }


    private void OnDestroy()
    {
        //mainCamera.backgroundColor = 
    }
}
