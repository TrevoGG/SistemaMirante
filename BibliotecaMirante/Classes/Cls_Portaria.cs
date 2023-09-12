using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaMirante.Classes
{
    public class Portaria
    {
        public class Unit
        {
            [Required(ErrorMessage = "data é obrigatorio")]
            public string Data { get; set; }

            public string Id { get; set; }
    
            [Required(ErrorMessage = "total é obrigatorio")]
            public string Total { get; set; }
            public void Valida()
            {

                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }

            }

        }
        public class List
        {
            public List<Unit> ListUnity { get; set; }
        }

        public static Unit DeserealizedClassUnity(string json)
        {
            return JsonSerializer.Deserialize<Unit>(json);

        }
        public static string SerealizedClassUnity(Unit unit)
        {

            return JsonSerializer.Serialize(unit);

        }
    }
}
    
