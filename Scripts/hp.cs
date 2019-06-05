using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class hp : MonoBehaviour
{
	Text hpText;
	public static int hpInt;

    void Start()
    {
        hpInt = 10;
        hpText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = "hp: " + hpInt;
    }
}
