using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject P1Camera;
    public GameObject P2Camera;
    public GameObject P3Camera;
    public GameObject P4Camera;

    private Camera cam1;
    private Camera cam2;
    private Camera cam3;
    private Camera cam4;

    void Start()
    {
        //Initialize the camera references.
        cam1 = P1Camera.GetComponent<Camera>();
        cam2 = P2Camera.GetComponent<Camera>();
        cam3 = P3Camera.GetComponent<Camera>();
        cam4 = P4Camera.GetComponent<Camera>();

        //Get number of players from Intro menu
        int numberOfPlayers = ValuesBetweenScenes.NumberOfPlayers;
        //Set up the camera layout
        switch(numberOfPlayers){
            case 1: Setup1PlayerCamera();break;
            case 2: Setup2PlayerCamera();break;
            case 3: Setup3PlayerCamera();break;
            case 4: Setup4PlayerCamera();break;
            default: Setup1PlayerCamera();break;
        }
    }

    public void Setup1PlayerCamera(){
        cam1.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
        ResetCamera(cam2);
        ResetCamera(cam3);
        ResetCamera(cam4);
    }

    public void Setup2PlayerCamera(){
        cam1.rect = new Rect(0.0f, 0.5f, 1.0f, 0.5f);
        cam2.rect = new Rect(0.0f, 0.0f, 1.0f, 0.5f);
        ResetCamera(cam3);
        ResetCamera(cam4);
    }

    public void Setup3PlayerCamera(){
        cam1.rect = new Rect(0.0f, 0.5f, 0.5f, 0.5f);
        cam2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
        cam3.rect = new Rect(0.0f, 0.0f, 1.0f, 0.5f);
        ResetCamera(cam4);
    }

    public void Setup4PlayerCamera(){
        cam1.rect = new Rect(0.0f, 0.5f, 0.5f, 0.5f);
        cam2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
        cam3.rect = new Rect(0.0f, 0.0f, 0.5f, 0.5f);
        cam4.rect = new Rect(0.5f, 0.0f, 0.5f, 0.5f);
    }
    //Camera will be Height and Width of 0, so it wouldn't show up in the game.
    void ResetCamera(Camera cam){
        cam.rect = new Rect(0.0f, 0.0f, 0.0f, 0.0f);
    }
}
