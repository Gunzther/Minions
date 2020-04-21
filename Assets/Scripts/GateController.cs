using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public GameObject canvas;
    public GameObject target;

    Animator anim;

    private void Awake()
    {
        anim = target.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canvas.activeSelf) anim.SetTrigger("activeGate");    
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
    }
}
