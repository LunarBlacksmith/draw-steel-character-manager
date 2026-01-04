using Godot;
using System;

public partial class MainMenu : Control
{
	public override void _EnterTree()
	{
		GD.Print($"MainMenu enter tree, {Name}, {GetInstanceId()}");
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// GD.Print("MainMenu ready");
		GD.Print($"MainMenu ready, {Name}, {GetInstanceId()}");
	}

	public override void _ExitTree()
	{
		GD.Print($"MainMenu exit tree, {Name}, {GetInstanceId()}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
