public abstract class Goal{

    private string _name;
    private string _description;

    private bool _isComplete;



    public abstract void RecordEvent();

    public abstract bool IsComplete(); // Abstract method

    public virtual string GetDetailsString() { return ""; } // Virtual method

    public abstract string GetStringRepresentation();

}