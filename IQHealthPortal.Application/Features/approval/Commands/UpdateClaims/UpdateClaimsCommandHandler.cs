using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;

namespace IQHealthPortal.Application.Features.approval.Commands.UpdateClaims
{
    public class UpdateClaimsCommandHandler
        : IRequestHandler<UpdateClaimsCommand, ServiceResponse<string>>
    {
        // Roles allowed to update claims (Java: role == 1 || role == 4).
        private static readonly int[] AllowedRoles = { 1, 4 };

        private readonly IUnitOfWork _uow;

        public UpdateClaimsCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ServiceResponse<string>> Handle(
            UpdateClaimsCommand request,
            CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<string> { Status = 200, Success = true };

            var dto = request.Request;
            var user = request.CurrentUser;

            // 1) VALIDATION: an approved quantity may never exceed the claimed quantity.
            //    (Java treated "NaN" as 0; with a typed int DTO that maps to Qty == 0.)
            var quantitiesValid = dto.Items.All(item => item.Qty <= item.Claimed);

            // 2) AUTHORIZATION: only roles 1 or 4 may update claims.
            var roleAllowed = user.RoleId.HasValue && AllowedRoles.Contains(user.RoleId.Value);

            if (!quantitiesValid || !roleAllowed)
            {
                response.Data = "-1";
                return response;
            }

            // 3) UPDATE
            var acode = await _uow.ApprovalRepository.UpdateClaimsAsync(dto, user);

            // 4) RESULT + side effects
            // sendToLocal runs fire-and-forget (the Java used background threads) so the
            // response is not blocked on the remote replication call. The repository resolves
            // its connection strings synchronously before awaiting, so this is safe to discard.
            if (acode > 100)
            {
                response.Data = "1";

                _ = _uow.ApprovalRepository.SendToLocalAsync(dto.ApprovalId, 2);
                _ = _uow.ApprovalRepository.SendToLocalAsync("10" + acode, 1);
            }
            else
            {
                response.Data = "0";

                _ = _uow.ApprovalRepository.SendToLocalAsync(dto.ApprovalId, 2);
            }

            return response;
        }
    }
}
