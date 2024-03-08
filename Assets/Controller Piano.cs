using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPiano : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource _do, _re, _mi, _fa, _sol;
    void Start()
    {
        Debug.Log("Bat dau");
        _do = GameObject.FindWithTag("Do").GetComponent <AudioSource>();
        _re = GameObject.FindWithTag("Re").GetComponent <AudioSource>();
        _mi = GameObject.FindWithTag("Mi").GetComponent <AudioSource>();
        _fa = GameObject.FindWithTag("Fa").GetComponent <AudioSource>();
        _sol = GameObject.FindWithTag("Sol").GetComponent <AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _do.Play();
            Debug.Log("You play Do");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _re.Play();
            Debug.Log("You play Re");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _mi.Play();
            Debug.Log("You play Mi");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            _fa.Play();
            Debug.Log("You play Fa");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            _sol.Play();
            Debug.Log("You play Sol");
        }
    }
}
