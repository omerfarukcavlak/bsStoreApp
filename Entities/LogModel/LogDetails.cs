using System.Text.Json;

namespace Entities.LogModel
{
    public class LogDetails
    {
        public LogDetails()
        {
                CreateAt = DateTime.Now;
        }
        public Object? ModelName { get; set; }
        public Object? Controller { get; set; }
        public Object? Action { get; set; }
        public Object? Id { get; set; }
        public Object? CreateAt { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
