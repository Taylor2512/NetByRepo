namespace NetByForms.Application.Models.Dto
{
    public class FormInputOptionDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string OptionValue { get; set; } = string.Empty;
        public string DisplayText { get; set; } = string.Empty;
    }
}
