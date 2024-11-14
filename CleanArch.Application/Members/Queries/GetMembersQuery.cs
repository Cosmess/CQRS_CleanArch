using CleanArch.Domain.Abstractions;
using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Members.Queries;

public class GetMembersQuery : IRequest<IEnumerable<Member>>
{
    public class GetMembersQueryHandler : IRequestHandler<GetMembersQuery, IEnumerable<Member>>
    {
        private readonly IMemberRepository _memberRepository  ;

        public GetMembersQueryHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public async Task<IEnumerable<Member>> Handle(GetMembersQuery request, CancellationToken cancellationToken)
        {
            var members = await _memberRepository.GetMembers();
            return members;
        }
    }
}

