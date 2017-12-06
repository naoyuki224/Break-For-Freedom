using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectbutton : MonoBehaviour {
    Button start;　//スタートボタン
    Button end;   //エンドボタン
 
    public bool LoadGames;//セーブデータの有無

	// Use this for initialization
    void Start()
    {
        //StartUIと言うキャンバスのSTARTという名前のボタンオブジェクトを取得
        start = GameObject.Find("Canvas/startbutton").GetComponent<Button>();

        //StartUIと言うキャンバスのLoadという名前のボタンオブジェクトを取得
        end = GameObject.Find("Canvas/endbutton").GetComponent<Button>();

        if (!LoadGames)
        {　　//セーブデータがなかったら

            start.Select();

        }else{　　　　　　//それ以外(セーブデータがあるとき)

            end.Select();

        }
    }
	
	// Update is called once per frame
	void Update () {
		
    }
}
