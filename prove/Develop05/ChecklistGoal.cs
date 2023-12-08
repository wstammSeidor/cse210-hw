public class ChecklistGoal : Goal
{
    private int _timesCompleted;

    private List<Goal> _goals;

    public override void RecordEvent() {  }
    public override bool IsComplete() { return false;  }
    public override string GetDetailsString() { return $"{base.GetDetailsString()} - Times Completed: {_timesCompleted}"; }
    public override string GetStringRepresentation() { return "";  }
}