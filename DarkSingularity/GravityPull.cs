using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Darkhitori.PlaymakerActions._Singularity
{
	using HutongGames.PlayMaker;

	[ActionCategory("Dark Singularity")]
	[Tooltip("")]
	public class GravityPull : FsmStateAction
	{
        #region Variables
		[RequiredField]
		[CheckForComponent(typeof(Singularity))]
		public FsmOwnerDefault gameObject;
        
		[Tooltip("")]
		public FsmFloat gravityPull;
        
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
        
		Singularity darkComp;
        #endregion
        
        #region Reset Values
		public override void Reset()
		{
			gameObject = null;
			gravityPull = 100f;
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
			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			if(go == null)
			{
				return;
			}
            
			darkComp = go.GetComponent<Singularity>();
            
			darkComp.GRAVITY_PULL = gravityPull.Value;
            
		}
        #endregion
	}

}
