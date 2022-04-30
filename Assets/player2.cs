using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {

    public float speed; //プレイヤーの動くスピード

    private Vector3 Player_pos; //プレイヤーのポジション
    private float x; //x方向のImputの値
    private float z; //z方向のInputの値
    private Rigidbody rigd;

    void Start()
    {
        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
        rigd = GetComponent<Rigidbody>(); //プレイヤーのRigidbodyを取得
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
      transform.position += new Vector3(-0.1f,0,0);
      }
      if(Input.GetKey(KeyCode.S)){
      transform.position += new Vector3(0.1f,0,0);
      }
      if(Input.GetKey(KeyCode.D)){
      transform.position += new Vector3(0,0,0.1f);
      }
      if(Input.GetKey(KeyCode.A)){
      transform.position += new Vector3(0, 0,-0.1f);
      }
    

	void OnTriggerEnter(Collider other)
	{
		Debug.Log (other.name + "Enter");
	}

	// 重なり中の判定
	void OnTriggerStay(Collider other)
	{
			Debug.Log (other.name + "Stay");
	}

	// 重なり離脱の判定
	void OnTriggerExit(Collider other)
	{
		Debug.Log (other.name + "Exit");
	}
        x = Input.GetAxis("Horizontal"); //x方向のInputの値を取得
        z = Input.GetAxis("Vertical"); //z方向のInputの値を取得

        rigd.velocity = new Vector3(x * speed, 0, z * speed); //プレイヤーのRigidbodyに対してInputにspeedを掛けた値で更新し移動

        Vector3 diff = transform.position - Player_pos; //プレイヤーがどの方向に進んでいるかがわかるように、初期位置と現在地の座標差分を取得

        if (diff.magnitude > 0.01f) //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
        {
            transform.rotation = Quaternion.LookRotation(diff);  //ベクトルの情報をQuaternion.LookRotationに引き渡し回転量を取得しプレイヤーを回転させる
        }

        Player_pos = transform.position; //プレイヤーの位置を更新


    }

}