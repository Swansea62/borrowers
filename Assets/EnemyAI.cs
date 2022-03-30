using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public AiSensor sensor;
    // Start is called before the first frame update
    void Start()
    {
        sensor = GetComponent<AiSensor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
