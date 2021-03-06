﻿using RPGCore.Behaviour.Manifest;

namespace RPGCore.Demo.BoardGame.Models
{
	[EditorType]
	public class ResourceTemplate
	{
		public string Identifier { get; set; }
		public string DisplayName { get; set; }
		public VoxelColour Colour { get; set; }
	}
}
