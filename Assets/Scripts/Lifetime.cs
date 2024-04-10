using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime = lifeTime - Time.deltaTime;

        if(lifeTime < 0) { GameObject.Destroy(gameObject); }
    }
}
