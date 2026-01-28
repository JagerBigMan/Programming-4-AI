using NodeCanvas.Framework;
using ParadoxNotion.Design;


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