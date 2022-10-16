using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
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
        i = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        offset = i * moveMul;
        transform.position = initPos + new Vector3(Mathf.Sin(offset), Mathf.Sin(offset) / 3.5f, 0);
        i += incAmount;
    }
}
