using System;

public class Orm : IDisposable
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Begin()
    {
        try{
            if (database.DbState == Database.State.Closed){
                this.database.BeginTransaction();
            }
        } catch (InvalidOperationException e){
            this.Dispose();
        }
    }

    public void Write(string data)
    {
       try{
            if (database.DbState == Database.State.TransactionStarted){
                this.database.Write(data);
            }
        } catch (InvalidOperationException e){
            this.Dispose();
        }
    }

    public void Commit()
    {
        try{
            if (database.DbState == Database.State.DataWritten){
                this.database.EndTransaction();
            }
        } catch (InvalidOperationException e){
            this.Dispose();
        }
    }

    public void Dispose(){
        this.database.Dispose();
    }
}
