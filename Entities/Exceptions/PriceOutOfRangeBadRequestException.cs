namespace Entities.Exceptions
{
    public class PriceOutOfRangeBadRequestException : BadRequestException
    {
        public PriceOutOfRangeBadRequestException() : base("Maximum price should be less than  and greater than 10.")
        {
            
        }
    }
}
