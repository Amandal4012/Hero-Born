using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;
public class HeroB : MonoBehaviour
{
    public int RotationSpeed = 100;
    private Transform itemTransform;
    // Start is called before the first frame update
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }
}
