﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riley : Interactable {
	public Riley() {
		menus = new Menu[] {
			new Menu(
			"You see a disheveled stranger.",
			new MenuOption[] {
				new MenuOption() { value = "Ignore them.", action = MenuOption.Action.DoNothing },
				new MenuOption() { value = "Ask, 'How did you end up here?'", action = MenuOption.Action.Progress }
			}),
			new Menu(
			"The stranger says, 'I was hired to stay here and wait for when I am needed.'",
			new MenuOption[] {
				new MenuOption() { value = "Ask, 'What would you be needed for?'", action = MenuOption.Action.Progress }
			}),
			new Menu(
			"The stranger says, 'That's between me and my employer.'",
			new MenuOption[] {
				new MenuOption() { value = "Fight", action = MenuOption.Action.DoNothing },
				new MenuOption() { value = "Say, 'How would you like a new job as my first mate?'", action = MenuOption.Action.Progress }, 				
			}),
			new Menu(
			"The stranger says, 'You can't offer me more than my current employer.'",
			new MenuOption[] {
				new MenuOption() { value = "Say, 'Not in gold, but I can offer the freedom and adventure of the life of a pirate!'", action = MenuOption.Action.Progress }
			}),
			new Menu(
			"The stranger grins and says, 'I have been dying of boredom...'",
			new MenuOption[] {
				new MenuOption() { value = "You have gained First Mate Riley.", action = MenuOption.Action.Progress },
			})
		};
		goalOffered = new Goal("MakeFriend");
	}
}