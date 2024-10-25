namespace NetByForms.Domain.Entities
{
    public class FormInput
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FormId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string InputType { get; set; } = "text"; // Ej: text, number, date, dropdown, etc.
        public bool IsRequired { get; set; }
        public Form Form { get; set; }
        public ICollection<FormInputOption> Options { get; set; } = new List<FormInputOption>();
    }
}