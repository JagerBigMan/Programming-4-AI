using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class RetreatWait : ActionTask {
		public BBParameter<float> RetreatTime = 2f;
		private float timer;
		protected override void OnExecute() 
		{
			timer = 0f;
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{
			timer += Time.deltaTime;
			if (timer >= RetreatTime.value)
			{
				EndAction(true);
			}
		}
	}
}