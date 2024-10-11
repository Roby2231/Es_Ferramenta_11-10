namespace Task_Ferramenta.Services
{
    public interface IServices<T>
    {
        IEnumerable<T> Lista();
        T? Cerca(string varCod);

    }
}
