using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Dto
{
    public  class MemberDto
    {
        public Guid? Id { get; set; } = Guid.NewGuid();    
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Gender { get; private set; }
        public string? Email { get; private set; }
        public bool? IsActive { get; private set; }

        public MemberDto(Guid? id, string? firstName, string? lastName, string? gender, string? email, bool? isAcitve) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            IsActive = isAcitve;
        }

        public MemberDto() { }

        public MemberDto(string firstName, string lastName, string gender, string email, bool? isAcitve)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            IsActive = isAcitve;
        }
    }

}
