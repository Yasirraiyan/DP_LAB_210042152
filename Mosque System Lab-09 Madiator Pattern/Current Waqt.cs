public class CurrentWaqt : IWidget
{
    private WaqtTimesTable _timesTable;
    public void setCurrentWaqt(WaqtTimesTable timesTable)
    { 
        this._timesTable = timesTable; 
    }
}
