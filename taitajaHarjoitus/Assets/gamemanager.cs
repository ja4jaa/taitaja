using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject[] esteet;
    private int ran;
    private int placement = 0;
    void Start()
    {
        StartCoroutine("DoCheck");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DoCheck()
    {
        for (; ; )
        {
            ran = Random.Range(0, esteet.Length);
            placement += 25;
            Instantiate(esteet[ran], new Vector3(placement, 0, 0), Quaternion.identity);           
            yield return new WaitForSeconds(1f);
        }
    }
}
