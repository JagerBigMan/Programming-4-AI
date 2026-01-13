using System.Security.Cryptography;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;



namespace NodeCanvas.Tasks.Actions {

	public class Telekinesis : ActionTask 
	
	{
		public BBParameter<Transform> target;						//Blackboard parameter allows NodeCanvas FSM to use these values. 
		public BBParameter<Transform> destination;
		public BBParameter<float> speed = 5f;
		public BBParameter<float> arriveDistance = 0.15f;

        protected override void OnUpdate() //only using OnUpdate because Telekinesis is a continuous action that runs every frame until it finishes
        {
            if (target.value == null || destination.value == null)		//Safety check
			{
				EndAction(false);
				return;
			}

		Vector3 currentPos = target.value.position;
		Vector3 targetPos = destination.value.position;

			target.value.position = Vector3.MoveTowards						//Moves the target to the destination, Vector3.Movetowards moves the object from point A toward point B by a certain distance
				(currentPos, targetPos, speed.value * Time.deltaTime);

			if (Vector3.Distance(target.value.position, targetPos) <= arriveDistance.value)
			{
				EndAction (true);
			}
        }
	}
}