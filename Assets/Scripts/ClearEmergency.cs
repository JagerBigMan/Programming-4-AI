using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Actions {

	public class ClearEmergency : ActionTask {

		public BBParameter<bool> EmergencyActive;
		protected override void OnExecute() 
		{
			EmergencyActive.value = false;
			EndAction(true);
		}
	}
}