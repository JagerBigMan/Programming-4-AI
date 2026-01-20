using System;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class RepairTick : ActionTask 
	{
		public BBParameter<float> structuralIntegrity;
		public BBParameter<bool> isRepairing;

		public float repairPerSecond = 6f;
		public float maxIntegrity = 100f;
		protected override void OnExecute() 
		{
			isRepairing.value = true;
		}
		protected override void OnUpdate()
		{
			structuralIntegrity.value = Mathf.Min(maxIntegrity,structuralIntegrity.value + repairPerSecond * Time.deltaTime);
		}


		protected override void OnStop()
		{
			isRepairing.value = false;
		}

	}
}