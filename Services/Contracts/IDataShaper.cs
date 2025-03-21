using System.Dynamic;

namespace Services.Contracts
{
    public interface IDataShaper<T>
    {
        IEnumerable<ExpandoObject> ShapeData(IEnumerable<T> entities, string filedsString); 
        ExpandoObject ShapeData(T entity, string filedsString); 
    }
}
