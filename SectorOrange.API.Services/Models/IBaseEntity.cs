namespace SectorOrange.API.Services.Models
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
    }
}
