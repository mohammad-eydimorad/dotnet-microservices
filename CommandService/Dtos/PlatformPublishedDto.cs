using CommandsService.Dtos;

namespace CommandService.Dtos
{
    public class PlatformPublishedDto : GenericEventDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}