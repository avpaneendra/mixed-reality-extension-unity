// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using MixedRealityExtension.Behaviors.ActionData;
using MixedRealityExtension.Behaviors.Actions;
using MixedRealityExtension.Core.Interfaces;

namespace MixedRealityExtension.Behaviors
{
	internal interface IActionHandler
	{
		void HandleActionStateChanged(IUser user, ActionState oldState, ActionState newState, BaseActionData actionData);

		void HandleActionPerforming(IUser user, BaseActionData actionData);
	}
}
