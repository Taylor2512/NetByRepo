namespace NetByForms.Application.Models.Dto
{
    public class FormDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<FormInputDto>? Inputs { get; set; }
    }
}