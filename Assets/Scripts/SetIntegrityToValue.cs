using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Actions {

	public class SetIntegrityToValue : ActionTask {

		public BBParameter<float> StructuralIntegrity;
		public float SetValue = 95f;
		protected override void OnExecute() 
		{
			StructuralIntegrity.value = SetValue;
			EndAction(true);
		}
	}
}