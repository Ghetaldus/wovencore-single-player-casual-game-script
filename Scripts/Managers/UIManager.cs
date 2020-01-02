// =======================================================================================
// Wovencore by Wovencode (c)
// =======================================================================================
using System;
using System.Collections.Generic;
using UnityEngine;
using woco.core;

namespace woco.core
{
	
	// ===================================================================================
	// UIManager
	// ===================================================================================
	[DisallowMultipleComponent]
	public partial class UIManager : _BaseManager
	{
	
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
		// PROPERTIES
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
		
		[Header("[WINDOWS]")]
		public _BaseWindow[] windows;
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
		// PUBLIC FUNCTIONS
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
		// EVENTS
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

		// -------------------------------------------------------------------------------
		// OnReset
		// -------------------------------------------------------------------------------
		public override void OnReset() {}
		
		// -------------------------------------------------------------------------------
		// OnLoad
		// -------------------------------------------------------------------------------
		public override void OnLoad() {}
		
		// -------------------------------------------------------------------------------
		// OnSave
		// -------------------------------------------------------------------------------
		public override void OnSave() {}
		
		// -------------------------------------------------------------------------------
		// OnData
		// -------------------------------------------------------------------------------
		public override DataHolder OnData()
		{
			return null;
		}
		
		// -------------------------------------------------------------------------------
	
	}
	
	// ===================================================================================
	
}