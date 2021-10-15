using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientos : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent <Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            anim.SetBool("Baile", true);
        }
        if (!Input.GetKey("d"))
        {
            anim.SetBool("Baile", false);
        }
        if (Input.GetKey("w"))
        {
            anim.SetBool("Caminado", true);
        }
        if (!Input.GetKey("w"))
        {
            anim.SetBool("Caminado", false);
        }
        if (Input.GetKey("r"))
        {
            anim.SetBool("Corriendo", true);
        }
        if (!Input.GetKey("r"))
        {
            anim.SetBool("Corriendo", false);
        }
        if (Input.GetKey("f"))
        {
            anim.SetBool("Caer", true);
        }
        if (!Input.GetKey("f"))
        {
            anim.SetBool("Caer", false);
        }
    }
}
