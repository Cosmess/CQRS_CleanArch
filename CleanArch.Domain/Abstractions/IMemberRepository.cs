﻿using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Abstractions;

public interface IMemberRepository
{
    Task<IEnumerable<Member>> GetMembers();
    Task<Member> GetMemberById(Guid memberId);
    Task<Member> AddMember(Member member);
    void UpdateMember(Member member);
    Task<Member> DeleteMember(Guid memberId);
}