public class Orm
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Write(string data)
    {
        using Database db = this.database;
        db.BeginTransaction();
        db.Write(data);
        db.EndTransaction();
    }

    public bool WriteSafely(string data)
    {
        bool res;
        using Database db = this.database;
        try{
            db.BeginTransaction();
            db.Write(data);
            db.EndTransaction();
            res = true;
        } catch (InvalidOperationException){
            db.Dispose();
            res = false;
        }
        
        return res;
    }
}
