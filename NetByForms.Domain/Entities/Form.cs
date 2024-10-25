namespace NetByForms.Domain.Entities
{
    public class Form
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<FormInput> Inputs { get; set; } = new List<FormInput>();
    }
}