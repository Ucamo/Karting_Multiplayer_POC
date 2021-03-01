using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class FollowTrackController : MonoBehaviour
{
    int currentTarget=0;
    float randomValue=0;
    ArcadeKart thisKart;

    void Start(){
        //All racers will follow the same path, this will change the exact position that they will follow.
        randomValue= Random.Range(-4f,4f);

        //Get reference for ArcadeKart
        thisKart = GetComponent<ArcadeKart>();
    }

    void Update()
    {
        //Has the race started?
        bool canMove = thisKart.GetCanMove();
        if(canMove){
            //Follow the path
            FollowPath_Piece();
        }

    }

    void FollowPath_Piece()
    {
        GameObject PathTrack = GameObject.Find("path_piece ("+currentTarget+")");
        if(PathTrack!=null){
        Vector3 targetPosition = new Vector3(PathTrack.transform.position.x+randomValue,PathTrack.transform.position.y,PathTrack.transform.position.z+randomValue);
        Vector3 currentPosition = transform.position;
        transform.position = Vector3.MoveTowards(currentPosition,targetPosition, 0.3f);

        // Determine which direction to rotate towards
        Vector3 targetDirection = targetPosition - currentPosition;

        // The step size is equal to speed times frame time.
        float singleStep = 5f * Time.deltaTime;
        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(currentPosition, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);
        

        float dist = Vector3.Distance(targetPosition, currentPosition);

        if(dist<=0.5){
            if(currentTarget==37){
                currentTarget=-1;
            }
            currentTarget++;
        }     
        }  
    }
}
