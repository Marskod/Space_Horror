using UnityEngine;
using System.Collections;

public class savePlayerLocation : MonoBehaviour {

	public Transform cube; 
	float x,y,z;

	void OnGUI()
	{
		//Debug.Log(cube.position.x);
		
		if(GUILayout.Button("Save Position"))
		{
			 x = cube.position.x; 
			 y = cube.position.y;
			 z = cube.position.z; 	
			
			PlayerPrefs.SetFloat("player_x",x);
			PlayerPrefs.SetFloat("player_y",y);
			PlayerPrefs.SetFloat("player_z",z);
			PlayerPrefs.Save();
 	
		}
		if(GUILayout.Button("Load Position"))
		{
			cube.position = new Vector3(PlayerPrefs.GetFloat("player_x"),PlayerPrefs.GetFloat("player_y"),PlayerPrefs.GetFloat("player_z")); 
		}
	}
}
