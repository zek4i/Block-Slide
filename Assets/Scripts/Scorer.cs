using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit"){ //wen the tag is not hit dont increase the score
        hits++;
        Debug.Log("We have Hit the wall these many times: "+hits);
        }
    }
}
