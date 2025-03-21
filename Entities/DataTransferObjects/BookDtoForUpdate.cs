namespace Entities.DataTransferObjects
{
    public record BookDtoForUpdate : BookDtoForManipulation
    {
        public int Id { get; set; }
    }
}
