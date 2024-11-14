using CleanArch.Application.Dto;
using CleanArch.Domain.Abstractions;
using MediatR;
using CleanArch.Application.Utils;

namespace CleanArch.Application.Members.Queries;

public class GetMemberByIdQuery : IRequest<MemberDto>
{
    public Guid Id { get; set; }

    public class GetMemberByIdQueryHandler : IRequestHandler<GetMemberByIdQuery, MemberDto>
    {
        private readonly IMemberRepository _memberRepository;

        public GetMemberByIdQueryHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public async Task<MemberDto> Handle(GetMemberByIdQuery request, CancellationToken cancellationToken)
        {
            var member = await _memberRepository.GetMemberById(request.Id);

            if (member == null)
            {
                throw new NotFoundException($"Member with Id {request.Id} not found.");
            }

            var memberDto = new MemberDto(
                member.Id,
                member.FirstName,
                member.LastName,
                member.Gender,
                member.Email,
                member.IsActive
            );

            return memberDto;
        }

    }
}