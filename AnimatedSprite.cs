using Godot;
using System;

public class AnimatedSprite : Godot.AnimatedSprite
{
    private Timer _time;
    private Random _random = new Random();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _time = GetNode<Timer>("Timer");
        _time.Connect("timeout", this, nameof(OnTimerTimeout));
        // _time.Start();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        this.Play("default");

    }
    
    private void OnTimerTimeout()
    {
        this.FlipH = !this.FlipH;
        float randomTime = (float)_random.NextDouble();
        _time.WaitTime = randomTime;
    }
}
