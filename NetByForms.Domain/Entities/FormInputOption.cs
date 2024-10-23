namespace NetByForms.Domain.Entities
{
    public class FormInputOption
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FormInputId { get; set; }
        public string OptionValue { get; set; } = string.Empty;
        public string DisplayText { get; set; } = string.Empty;
        public required FormInput FormInput { get; set; }
    }
}
