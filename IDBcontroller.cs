namespace SqliteDemo
{
    public interface IDBcontroller {

        void DbOpen();
        void DbClose();
        void Query(string cmd);

    }
}
