using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) //on collision (enter) aka do this!!
    {
        if(other.gameObject.tag == "Player"){ //accessing tag from gameobj
        GetComponent<MeshRenderer>().material.color = Color.red;
        //accessing the component "mesh renderer" then accesing its material color and changing it
        //to make sure only the player makes obj red we use tags
        gameObject.tag = "Hit"; //when obj hits sum change the name to hit
        }
    }
}
