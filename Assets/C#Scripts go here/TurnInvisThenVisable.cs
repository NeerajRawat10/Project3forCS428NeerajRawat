using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnInvisThenVisable : MonoBehaviour
{
    public GameObject teemo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowHide(3.0f));
    }

    IEnumerator ShowHide(float thedelay){
        teemo.SetActive(true);
        yield return new WaitForSeconds(thedelay);
        teemo.SetActive(false);
    }
}
