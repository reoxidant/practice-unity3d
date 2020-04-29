﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
	
	[TextArea(10,15)] [SerializeField] string storyText;
	[SerializeField] State[] states;

	public string GetStateStory()
	{
		return storyText;
	}

	public State[] GetAnotherStates()
	{
		return states;
	}
}