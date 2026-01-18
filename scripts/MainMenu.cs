using Godot;
using System;

public partial class MainMenu : Control
{

	// Declare custom signals.
	[Signal]
	public delegate void MySignalEventHandler();

	[Signal]
	public delegate void MySignalWithArgumentEventHandler(string myParameterString_p);

	public override void _EnterTree()
	{
		GD.Print($"MainMenu enter tree, {Name}, {GetInstanceId()}");
		// GD.PrintErr("This is an error message from MainMenu.");
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// GD.Print("MainMenu ready");
		GD.Print($"MainMenu ready, {Name}, {GetInstanceId()}");
		// Connect custom signal to the Print method.
		MySignal += () => GD.Print("Aliqua cillum ut eiusmod.");
		// Connect custom signal with argument to the CastSpell method.
		MySignalWithArgument += CastSpell;

		MyMethodEmittingSignals();
	}

	public override void _ExitTree()
	{
		GD.Print($"MainMenu exit tree, {Name}, {GetInstanceId()}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// Method to be called when MySignalWithArgument custom signal is emitted.
	private void CastSpell(string spellName_p)
	{
		GD.Print($"I cast {spellName_p}!");
	}

	// Method that emits the custom signals.
	public void MyMethodEmittingSignals()
	{
    	EmitSignal(SignalName.MySignal);
    	EmitSignal(SignalName.MySignalWithArgument, "FIREBALL");
	}
}
