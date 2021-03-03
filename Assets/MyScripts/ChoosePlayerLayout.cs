using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayerLayout : MonoBehaviour
{
    public void SetUp1PlayerMode(){
        ValuesBetweenScenes.NumberOfPlayers=1;
    }

    public void SetUp2PlayerMode(){
        ValuesBetweenScenes.NumberOfPlayers=2;
    }

    public void SetUp3PlayerMode(){
        ValuesBetweenScenes.NumberOfPlayers=3;
    }

    public void SetUp4PlayerMode(){
        ValuesBetweenScenes.NumberOfPlayers=4;
    }
}
