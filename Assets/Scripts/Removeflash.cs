using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removeflash : MonoBehaviour
{
    public bool turnOff = false; 

    void Update()
    {
        
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(0.2f);
        this.gameObject.SetActive(false);
    }
}
