using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookandMember.Data;
using BookandMember.Entities;

namespace BookandMember.Repositories
{
    internal class MemberRepository
    {
        // List all members
        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStore.Members;
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members,
            };
        }

        // Get a member by ID
        public GenericResponse<Member> GetMemberById(int id)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Id == id);
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }

        // Get a member by name
        public GenericResponse<Member> GetMemberByName(string name)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Name == name);
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }

        // Get a member by email
        public GenericResponse<Member> GetMemberByEmail(string email)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Email == email);
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }
    }
}
