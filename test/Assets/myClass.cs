using UnityEngine;
using System.Collections;
using System.Xml ;
using System.IO ;

public class myClass  {
	private  static myClass _instance;
	public int num;
	private string name1;
	private string path1;

	public myClass ()
	{
//		name1 = "/wenjian.xml";
//		path1 = Application.streamingAssetsPath + name1;
//		XmlDocument doc = new XmlDocument ();
//		doc.Load (path1);
//		XmlNode root = doc.SelectSingleNode ("maxscore");
//		num = int.Parse (root.InnerText);

//		path1 = Application.streamingAssetsPath + "/wenjian.xml";
//		XmlDocument doc= new XmlDocument();
//		doc.Load(path1);
//		XmlNode root=doc.SelectSingleNode("maxscore");
//		num = int.Parse (root.InnerText);

//		path1 = Application.streamingAssetsPath + "/wenjian.xml";
//		XmlDocument doc = new XmlDocument ();
//		doc.Load (path1);
//		XmlNode root = doc.SelectSingleNode ("maxscore");
//		num=int.Parse (root.InnerText);



		path1 = Application.streamingAssetsPath + "/wenjian.xml";
		XmlDocument doc = new XmlDocument ();
		doc.Load (path1);
		XmlNode root = doc.SelectSingleNode ("maxscore");
		num = int.Parse (root.InnerText);
	}
	public static myClass GetInstance(){
		if(_instance==null){

			_instance=new myClass();
		}
		return _instance;
	}
	public void SetWenjian(string  num){
		XmlDocument doc = new XmlDocument ();
		doc.Load (path1);
		XmlNode root = doc.SelectSingleNode("maxscore");
		root.InnerText = num;
		doc.Save (path1);
	}

}
