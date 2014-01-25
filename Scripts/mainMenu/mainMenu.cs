using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	public GUISkin menuSkin; 
	public GUISkin titleSkin; 
	public float offset = 50; 
	
	public bool mainWindow = true; 
	
	public float sliderValue = 0.0f; 
	
	//Option menu + sub menus 
	public bool optionMenu = false; 
	public bool soundWindow = false; 
	public bool graphicsWindow = false; 
	public bool resolutionWindow = false; 
	public bool qualityWindow = false;
	
	private string[] gfxList = new string[]{"Fastest","Fast","Simple","Good","Beautiful","Fantastic"};
	public int gfxInc; 
	
	
	void OnGUI()
	{
		GUI.skin = titleSkin; 
		GUI.Label(new Rect(Screen.width/8,Screen.height/2.5f,300,100),"Attack of the\n toaster Kitty");
		GUI.skin = menuSkin; 
		
		//Main Menu 
		if(mainWindow)
		{
			GUILayout.Window(0,new Rect(Screen.width/2f,Screen.height/3.5f,Screen.width/2,Screen.height/2),mainWind, "");
		}
		
		//Option Menu + Sub Menus 
		if(optionMenu)
		{
			GUILayout.Window(0,new Rect(Screen.width/2,Screen.height/3.5f,Screen.width/2,Screen.height/2),opMenu, "");
		}
		if(soundWindow)
		{
			GUILayout.Window(0,new Rect(Screen.width/1.5f,Screen.height/3.5f,200,Screen.height/2),soundMenu, "");
		}
		if(graphicsWindow)
		{
			GUILayout.Window(0,new Rect(Screen.width/2,Screen.height/3.5f,Screen.width/2,Screen.height/2),graphicsMenu, "");
		}
		if(qualityWindow)
		{
			GUILayout.Window(0,new Rect(Screen.width/2,Screen.height/3.5f,Screen.width/2,Screen.height/2),qualityMenu, "");
		}
		if(resolutionWindow)
		{
			GUILayout.Window(0,new Rect(Screen.width/2,Screen.height/3.5f,Screen.width/2,Screen.height/2),resolutionMenu, "");	
		}
		
		
	}
	void mainWind(int windID)
	{	
		
		//GUILayout.BeginArea(area);
		GUILayout.Button("Continue");
        GUILayout.Button("Start new game");
        //GUILayout.Button("Load Game");
		if(GUILayout.Button("Options"))
			optionMenu = true;
		GUILayout.Button("Exit");
        //GUILayout.EndArea();
	}	


//********************************	option menus **********************************
	
	void soundMenu(int windID)
	{
		GUILayout.Label("Master Volume: "); 
		sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, 2.0f); 
		if(GUILayout.Button("back"))
		{
			soundWindow = false;
			optionMenu = true;
		}
	}
	
	void graphicsMenu(int windID)
	{
		if(GUILayout.Button("Quality"))
		{
			graphicsWindow = false;
			qualityWindow = true;
		}
		
		if(GUILayout.Button("Resolution"))
		{
			graphicsWindow = false;
			resolutionWindow = true;
		}
		
		if(GUILayout.Button("back"))
		{
			graphicsWindow = false;
			optionMenu = true;
		}
	}
	
	void qualityMenu(int windID)
	{		
		if(GUILayout.Button("Previous"))
		{
			if(gfxInc != 0)
				gfxInc--;
		}
		
		GUILayout.Label(""+gfxList[gfxInc]);	
		
		if(GUILayout.Button("Next"))
		{
			if(gfxInc != 5)
				gfxInc++; 
		}	
		
		if(GUILayout.Button("Back"))
		{
			graphicsWindow = true;
			qualityWindow = false;
		}
	}
	
	void resolutionMenu(int windID)
	{
		if(GUILayout.Button("back"))
		{
			graphicsWindow = true;
			resolutionWindow = false;
		}
	}
	
	void opMenu(int windID)
	{	
		
		//GUILayout.BeginArea(area);
		if(GUILayout.Button("Graphics"))
		{
			graphicsWindow = true;
			optionMenu = false;
		}
		if(GUILayout.Button("Sound"))
		{
			soundWindow = true;
			optionMenu = false;
		}
		if(GUILayout.Button("Back"))
		{
			optionMenu = false;
			mainWindow = true;
		}
        //GUILayout.EndArea();
	}
	
//*********************************************** End option Menu *******************************

}
