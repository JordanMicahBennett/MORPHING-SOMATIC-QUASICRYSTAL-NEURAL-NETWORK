//Author Data >> Scratch written by Jordan Micah Bennett  (  manufactured mind  ( c )  2014  ) 


using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class MorphingSomaticQuasicrystalPathAlgorithmGenerator : MonoBehaviour 
{
	private MorphingSomaticQuasicrystalPathAlgorithmDiffractionPatternFieldGenerator fieldGenerator; 
	private MorphingSomaticQuasicrystalPathAlgorithm model;


	void Awake  (   ) 
	{
		fieldGenerator = GameObject.FindGameObjectWithTag ( Tags.gameController ).GetComponent <MorphingSomaticQuasicrystalPathAlgorithmDiffractionPatternFieldGenerator> ( );
		model = GameObject.FindGameObjectWithTag ( Tags.gameController ).GetComponent <MorphingSomaticQuasicrystalPathAlgorithm> ( );

		//establish agents, by providing center, and spacing
		model.establishAgents ( new Vector3 ( 617f, 0f, 217f ), 10f, 15f );
	}
}
