namespace NetByForms.Application.Models.Dto
{
    public class FormInputDto
    {
        public Guid? Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; } = string.Empty;
        public string? InputType { get; set; } = "text";
        public bool? IsRequired { get; set; }
        public List<FormInputOptionDto>? Options { get; set; } = new List<FormInputOptionDto>();
    }
}