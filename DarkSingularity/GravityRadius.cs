using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Darkhitori.PlaymakerActions._Singularity
{
	using HutongGames.PlayMaker;

	[ActionCategory("Dark Singularity")]
	[Tooltip("")]
	public class GravityRadius : FsmStateAction
	{
        #region Variables
		[Tooltip("")]
		public FsmFloat gravityRadius;
        
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
        
		
        #endregion
        
        #region Reset Values
		public override void Reset()
		{
			gravityRadius = 1f;
			everyFrame = false;
		}
        #endregion
        
        #region Methods
		// Code that runs on entering the state.
		public override void OnEnter()
		{
			DoMethod();
			if (!everyFrame)
			{
				Finish();
			}
		}
        
		// Code that runs every frame.
		public override void OnUpdate()
		{
			DoMethod();
		}

		void DoMethod()
		{
			Singularity.m_GravityRadius = gravityRadius.Value;
            
		}
        #endregion
	}

}
