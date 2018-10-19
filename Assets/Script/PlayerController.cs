using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float speed = 10;

    private void FixedUpdate()
    {
        //入力をx,zに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //同一のGameObjectが持つRigidBodyコンポーネントの取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        //rigidbodyのxとy行くに力を加える
        rigidbody.AddForce(x*speed, 0, z*speed);

    }

}
