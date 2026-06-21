using System;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Player;

[RegisterTypeInIl2Cpp]
public class InfoBillboard : MonoBehaviour
{
	
	public InfoBillboard(IntPtr ptr) : base(ptr) {}
	public InfoBillboard() : base(ClassInjector.DerivedConstructorPointer<InfoBillboard>()) => ClassInjector.DerivedConstructorBody(this);
	
	private Transform cam;
	private Transform textTransform;
	private TextMesh nameMesh;
	private TextMesh outlineMesh;
	
	void Start()
	{
		cam = Camera.main.transform;
		
		GameObject textObj = new GameObject("PlayerNameTag");
		textObj.transform.SetParent(transform);
		textObj.transform.localPosition = new Vector3(0, 20, 0);
		
		nameMesh = textObj.AddComponent<TextMesh>();
		nameMesh.font = Font.GetDefault();
		nameMesh.text = gameObject.name;
		nameMesh.characterSize = 0.07f;
		nameMesh.fontSize = 30;
		nameMesh.alignment = TextAlignment.Center;
		nameMesh.anchor = TextAnchor.MiddleCenter;
		nameMesh.color = Color.white;
		
		GameObject outlineObj = new GameObject("outline");
		outlineObj.transform.SetParent(textObj.transform);
		outlineObj.transform.localPosition = new Vector3(0, 0, 0.05f);
		
		outlineMesh = outlineObj.AddComponent<TextMesh>();
		outlineMesh.font = Font.GetDefault();
		outlineMesh.text = gameObject.name;
		outlineMesh.characterSize = 0.071f;
		outlineMesh.fontSize = 30;
		outlineMesh.alignment = TextAlignment.Center;
		outlineMesh.anchor = TextAnchor.MiddleCenter;
		outlineMesh.color = Color.black;
		
		textTransform = textObj.transform;
	}

	public void SetName(string username)
	{
		gameObject.name = username;
		if (nameMesh != null) nameMesh.text = username;
		if (outlineMesh != null) outlineMesh.text = username;
	}

	void Update()
	{
		if (cam != null)
			textTransform.LookAt(textTransform.position + cam.forward);
	}
}
