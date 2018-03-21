using UnityEngine;
using System.Collections;
using System.IO;

public class CSVLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int i=0, j;
		TextAsset csv = Resources.Load ("CSV/sample") as TextAsset;
		StringReader reader = new StringReader (csv.text);
		while (reader.Peek () > -1) {
			i++;
			Debug.Log (i+"回目");
			string line = reader.ReadLine ();
			string[] values = line.Split (',');
			for (j = 0; j < values.Length; j++) {
				Debug.Log (values [j]);
			}
		}
	}
}