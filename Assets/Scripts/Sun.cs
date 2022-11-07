using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    Vector3 initPos;
    float i;
    float offset;

    public float moveMul;
    public float incAmount;


    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //offset = i * moveMul;
        float timeOffset = Time.time / incAmount;
        transform.position = initPos + new Vector3(0, Mathf.Cos(timeOffset) * moveMul, Mathf.Sin(timeOffset) * moveMul);
        //i += incAmount;
    }
}
