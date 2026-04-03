namespace PionereeDemo.Storage.FileValidator;
public interface IFileValidator
{
    void Validate(IFileValidateInput file);
    bool CanValidate(IFileValidateInput file);
}