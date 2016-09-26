using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class jiexi : MonoBehaviour {
	public Text textt;
	// Use this for initialization
	void Start () {
//		print (myClass.GetInstance ().num);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void click(){
//		//textt.text = (int.Parse (textt.text) += 1).ToString ();
//		int a = int.Parse (textt.text);
//		a += 1;
//		textt.text = a.ToString ();
//		if (int.Parse (textt.text) > myClass.GetInstance ().num) {
//			myClass.GetInstance ().SetWenjian (textt.text);
//		}


		int a = int.Parse (textt.text);
				a += 1;
				textt.text = a.ToString ();
		if (int.Parse (textt.text) > theClass.getInstance().num) {
			theClass.getInstance().num = int.Parse (textt.text);
				}
	}
	public void qiehuan(){
		Application.LoadLevel (0);
	}
	public void xianshi(){
		print(theClass.getInstance().num );
	}
}
//gaibiangaibiangaibian