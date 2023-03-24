using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatApi.Data.Validation
{
    public class Validation : AbstractValidator<Staff>
    {
        public Validation()
        {
            RuleFor(Staff => Staff.Id).NotNull().NotEmpty().WithMessage("Id Can Not Be Null");
            RuleFor(Staff => Staff.FirstName).NotNull().NotEmpty().Length(1, 250).WithMessage("First Name Can Not Be Null");
            RuleFor(Staff => Staff.LastName).NotNull().NotEmpty().Length(1, 250).WithMessage("Last Name Can Not Be Null");

            
            RuleFor(Staff => Staff.Phone).NotEmpty().WithMessage("Please add a phone number");
            RuleFor(Staff => Staff.AddressLine1).InjectValidator().NotNull().NotEmpty().Length(1, 500);
        }
    }
}
