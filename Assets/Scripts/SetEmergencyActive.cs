using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions {

	public class SetEmergencyActive : ActionTask {

		public BBParameter<bool> EmergencyActive;
		protected override void OnExecute() 
		{
            EmergencyActive.value = true;
            EndAction(true);
		}
	}
}