public class EternalGoal : Goal
{
    public override void RecordEvent() {  }
    public override bool IsComplete() { return false; }
    public override string GetStringRepresentation() { return "";  }
}