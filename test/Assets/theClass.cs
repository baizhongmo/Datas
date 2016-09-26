using UnityEngine;
using System.Collections;

public class theClass  {

	public  int num=0;
	private static theClass _instance;
	public static theClass getInstance(){

		if (_instance == null) {
		
			_instance = new theClass ();
		}
		return _instance;
	}

}
