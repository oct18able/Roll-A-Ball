﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform target;

    private Vector3 offset;


    // Use this for initialization
    void Start () {
        offset = GetComponent<Transform>().position - target.position;
	}

    

	// Update is called once per frame
	void Update () {

        //自分の座標にtargetの座標の代入
        GetComponent<Transform>().position = target.position + offset;

	}
}
