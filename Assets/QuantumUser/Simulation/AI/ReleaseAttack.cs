﻿using Photon.Deterministic;

namespace Quantum
{
	[System.Serializable]
	public unsafe class ReleaseAttack : AIAction
	{
		public AIParamFP BasicAttackError;
		public AIParamFP SpecialAttackError;

		public override void Execute(Frame frame, EntityRef entity, ref AIContext aiContext)
		{
			AIBlackboardComponent* blackboard = frame.Unsafe.GetPointer<AIBlackboardComponent>(entity);
			AIConfig aiConfig = frame.FindAsset<AIConfig>(frame.Get<HFSMAgent>(entity).Config.Id);

			FPVector2 agentPosition = frame.Get<Transform2D>(entity).Position;

			EntityRef targetEntity = blackboard->GetEntityRef(frame, AIConstants.KEY_TARGET);
			if (targetEntity == default)
				return;

			FPVector2 targetPosition = frame.Get<Transform2D>(targetEntity).Position;

			FPVector2 targetDirection = FPVector2.Zero;
			if (frame.Unsafe.TryGetPointer<KCC>(targetEntity, out var kcc)) {
				targetDirection = kcc->Velocity.Normalized;
			}

			FPVector2 predictedPosition = targetPosition + targetDirection * 2;

			Bot* bot = frame.Unsafe.GetPointer<Bot>(entity);
			AttributeData specialAttribute = AttributesHelper.GetAttributeData(frame, entity,  EAttributeType.Special);
			if (specialAttribute.IsFull == true)
			{
				FP errorRange = SpecialAttackError.Resolve(frame, entity, blackboard, aiConfig);
				FP randomX = frame.RNG->NextInclusive(errorRange, -errorRange);
				FP randomY = frame.RNG->NextInclusive(errorRange, -errorRange);
				predictedPosition += new FPVector2(randomX, randomY);

				bot->Input.AltFire.Update(frame.Number, false);
			}
			else
			{
				FP errorRange = BasicAttackError.Resolve(frame, entity, blackboard, aiConfig);
				FP randomX = frame.RNG->NextInclusive(errorRange, -errorRange);
				FP randomY = frame.RNG->NextInclusive(errorRange, -errorRange);
				predictedPosition += new FPVector2(randomX, randomY);

				bot->Input.Fire.Update(frame.Number, false);
			}

			bot->Input.AimDirection = predictedPosition - agentPosition;
		}
	}
}
